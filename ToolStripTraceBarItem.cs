using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace AudioStationRemote
{
	[
	ToolStripItemDesignerAvailability
		(ToolStripItemDesignerAvailability.ToolStrip | ToolStripItemDesignerAvailability.StatusStrip)
	]


	public class ToolStripTraceBarItem : ToolStripControlHost
	{
		public bool isMouseDown = false;

		public TrackBar tb { get { return (TrackBar)this.Control; } }
		public ToolStripTraceBarItem()
			: base(new TrackBar())
		{
			tb.MouseDown += (sender, args) => isMouseDown = true;
			tb.MouseUp += (sender, args) => isMouseDown = false;

		}
	}

}
