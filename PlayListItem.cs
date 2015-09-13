using json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioStationRemote
{
	public class PlayListItem
	{
		public string id;

		string path;
		string title;
		int track;
		string album;
		string artist;


		public void Set(PlayListItem item)
		{
			this.id = item.id;
			this.path = item.path;
			this.title = item.title;
			this.track = item.track;
			this.album = item.album;
			this.artist = item.artist;
		}

		public void Set(dynamic v)
		{
			this.id = v.id;
			this.path = v.path;
			this.title = v.title;
			this.track = v.additional.song_tag.track;
			this.artist = v.additional.song_tag.artist;
			this.album = v.additional.song_tag.album;
		}


		public ListViewItem listViewItem()
		{
			var item = new ListViewItem(new string[]
								{
									null,
									track+"",
									artist + " - " + album,
									title,
									path,
								})
			{ Tag = this };
			return item;
		}
	}
}
