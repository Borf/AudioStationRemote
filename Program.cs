using AudioStationRemote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioStationRemote
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			bool hooked = false;
			//if (!System.Diagnostics.Debugger.IsAttached)
			{
				Hooker.Init();
				hooked = true;
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new AudioStationRemote());
			if (hooked)
				Hooker.Dispose();

        }
    }
}
