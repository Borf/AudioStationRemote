using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioStationRemote
{
    public partial class AudioStationRemote : Form
    {

		AudioStation audioStation = new AudioStation();
		private ToolStripTraceBarItem volumeSlider;
		private ToolStripTraceBarItem playbackSlider;
		bool mouseDownVolume = false;

		dynamic config;

		string playState;
		private PlayList queuePlayList;

		public AudioStationRemote()
        {
            InitializeComponent();
        }

        private void AudioStationRemote_Load(object sender, EventArgs e)
        {
			config = json.Value.fromString(File.ReadAllText("config.json"));
			audioStation.login(config["user"], config["pass"]);

			volumeSlider = new ToolStripTraceBarItem();
			volumeSlider.tb.TickStyle = TickStyle.None;
			volumeSlider.tb.AutoSize = false;
			volumeSlider.tb.Size = new Size(200, 32);
			volumeSlider.tb.Minimum = 0;
			volumeSlider.tb.Maximum = 100;

			volumeSlider.tb.MouseDown += (o, args) => { mouseDownVolume = true;  };
			volumeSlider.tb.MouseUp += (o, args) => { pingTimer.Stop(); mouseDownVolume = false;  audioStation.setVolume(volumeSlider.tb.Value); pingTimer.Start(); };
			volumeSlider.tb.ValueChanged += (o, args) =>{ pingTimer.Stop(); if (!mouseDownVolume) audioStation.setVolume(volumeSlider.tb.Value); lblVolume.Text = "Volume: " + volumeSlider.tb.Value; pingTimer.Start(); };
			volumeSlider.ToolTipText = "Volume";
			volumeSlider.Alignment = ToolStripItemAlignment.Right;
			toolStrip1.Items.Add(volumeSlider);


			playbackSlider = new ToolStripTraceBarItem();
			playbackSlider.tb.TickStyle = TickStyle.None;
			playbackSlider.tb.AutoSize = false;
			playbackSlider.tb.Size = new Size(500, 32);
			playbackSlider.tb.Minimum = 0;
			playbackSlider.tb.Maximum = 1000;
			playbackSlider.ToolTipText = "Playback";
			toolStrip1.Items.Insert(toolStrip1.Items.Count-2, playbackSlider);

			Hooker.callback += (Keys key) =>
			{
				if (key == Keys.MediaNextTrack)
					audioStation.next();
				else if (key == Keys.MediaPreviousTrack)
					audioStation.prev();
				else if (key == Keys.MediaPlayPause)
				{
					btnPlayPause_Click(null, null);
                }
				

			};

			Task.Run(async () =>
			{
				var rootDir = await audioStation.getDirectory();
                for (int i = 0; i < rootDir.data.items.Count; i++)
				{
                    TreeNode n = new TreeNode(rootDir.data.items[i].title.Value) { Tag = rootDir.data.items[i].id.Value };
					n.Nodes.Add(new TreeNode("...") { Tag = "dummy" });
					Invoke(() => treeView1.Nodes.Add(n));
                }
			});


			Task.Run(async () =>
			{
				var queueData = await audioStation.getplaylist();

				PlayListItem playlistItem = new PlayListItem();
				List<ListViewItem> rows = new List<ListViewItem>();
				queuePlayList = new PlayList(null, null);
				queuePlayList.listview = queue;

				for (int i = 0; i < queueData.data.songs.Count; i++)
				{
					if (i > 0)
					{
						rows.Add(playlistItem.listViewItem());
						queuePlayList.items.Add(playlistItem);
						playlistItem = new PlayListItem();
					}
					playlistItem.Set(queueData.data.songs[i]);


				}
				rows.Add(playlistItem.listViewItem());
				queuePlayList.items.Add(playlistItem);
				Invoke(() =>
				{
					queue.Items.Clear();
					queue.Items.AddRange(rows.ToArray());
					queue.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
				});



			});
			


		}

		private void btnPrev_Click(object sender, EventArgs e)
		{
			audioStation.prev();
		}

		private void btnPlayPause_Click(object sender, EventArgs e)
		{
			if (playState == "pause")
				audioStation.play();
			else
				audioStation.pause();
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			audioStation.stop();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			audioStation.next();
		}

		private async void pingTimer_Tick(object sender, EventArgs e)
		{
			var status = await audioStation.getStatus();

			this.Text = status.data.song.title;
			playState = status.data.state;

			if (playState == "paused")
				this.Text += " [ PAUSED ]";

			if(!mouseDownVolume)
				volumeSlider.tb.Value = status.data.volume;


			playbackSlider.tb.Maximum = status.data.song.additional.song_audio.duration;
			if(status.data.position < playbackSlider.tb.Maximum)
				playbackSlider.tb.Value = status.data.position;

			//Console.WriteLine(status.ToString());

		}

		public void Invoke(Action action)
		{
			Invoke((Delegate)action);
		}

		private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
		{
			TreeNode eventNode = e.Node;
			Task.Run(() =>
			{
				var dirContents = audioStation.getDirectory(e.Node.Tag.ToString()).Result;
				Invoke(() => eventNode.Nodes.Clear());
				for (int i = 0; i < dirContents.data.items.Count; i++)
				{
					TreeNode n = new TreeNode(dirContents.data.items[i].title.Value) { Tag = dirContents.data.items[i].id.Value };
					if (dirContents.data.items[i].type == "folder")
						n.Nodes.Add(new TreeNode("...") { Tag = "dummy" });
					else
					{
						n.Text = dirContents.data.items[i].path;
						n.Text = n.Text.Substring(n.Text.LastIndexOf("/") + 1);
						n.ImageIndex = 1;
						n.SelectedImageIndex = 1;
					}

					Invoke(() => eventNode.Nodes.Add(n));
				};
			});

		}
	}
}
