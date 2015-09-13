using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AudioStationRemote
{
	public class PlayList
	{
		public List<PlayListItem> items = new List<PlayListItem>();

		public string name;
		public TabPage tab;
		public ListView listview;

		public PlayList(string value, AudioStationRemote mainForm)
		{
			if (value == null || mainForm == null)
				return;
			this.name = value;

			tab = new System.Windows.Forms.TabPage();
			tab.Name = value;
			tab.Text = value;


			ColumnHeader playingIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			ColumnHeader Track = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			ColumnHeader Artist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			ColumnHeader Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			ColumnHeader Album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			ColumnHeader Filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			playingIndex.Text = "";
			playingIndex.Width = 14;

			Artist.Text = "Artist/Album";
			Track.Text = "Track";
			Title.Text = "Title";
			Filename.Text = "Filename";

			

			this.listview = new ListView();
			this.listview.AllowColumnReorder = true;
			this.listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            playingIndex,
            Artist,
            Track,
            Title,
            Filename});
			this.listview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listview.FullRowSelect = true;
			this.listview.Location = new System.Drawing.Point(3, 3);
			this.listview.Name = "queue";
			this.listview.ShowGroups = false;
			this.listview.Size = new System.Drawing.Size(1048, 540);
			this.listview.SmallImageList = mainForm.treeList;
			this.listview.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listview.TabIndex = 0;
			this.listview.UseCompatibleStateImageBehavior = false;
			this.listview.HideSelection = false;
			this.listview.View = System.Windows.Forms.View.Details;


		/*	this.listview.DoubleClick += (sender, args) =>
			{
				if(listview.SelectedItems.Count > 0)
					mainForm.activateItem(listview.SelectedItems[0]);
			};*/

			this.tab.Controls.Add(listview);
		}

		/// <returns>Returns true if the item is added, false if it is updated</returns>
		public bool update(PlayListItem playlistItem)
		{
			for (int i = 0; i < items.Count; i++)
			{
				if (items[i].id == playlistItem.id)
				{
					if (items[i].id != playlistItem.id )//|| items[i].title != playlistItem.title || items[i].artist != playlistItem.artist || items[i].album != playlistItem.album || items[i].number != playlistItem.number)
					{
						//while (playlistItem.pos > listview.Items.Count)
						//	listview.Items.Add(new ListViewItem("..."));
						listview.Items.Add(playlistItem.listViewItem());
					}
					items[i].Set(playlistItem);
					return false;
				}
			}

			listview.Items.Add(playlistItem.listViewItem());
			items.Add(playlistItem);
			return true;
		}


		public void setSize(int size)
		{
			if(items.Count > size)
				items.RemoveRange(size, items.Count-size);

			while(listview.Items.Count > size)
				listview.Items.RemoveAt(listview.Items.Count-1);
		}
	}
}