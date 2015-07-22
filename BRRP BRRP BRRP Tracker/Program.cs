using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRRP_BRRP_BRRP_Tracker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Give user instuctions
            if (!Properties.Settings.Default.seenInfo)
            {
                MessageBox.Show("Start playing an audio file using the \"Play\" button then just click the blank\npart of the window to simulator a 'Brrp'\n\nYeah It was really hard to automatically detect it. Props to an0nymooose.\n\nThis message only displays once.", "Info");
                Properties.Settings.Default.seenInfo = true;
                Properties.Settings.Default.Save();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
