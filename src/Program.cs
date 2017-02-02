using System;
using System.Threading;
using System.Windows.Forms;

namespace SirCheese {
	static class Program {

		public static frmSplash splash = null;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Thread thred = new Thread(new ThreadStart( delegate {
				splash = new frmSplash();
				Application.Run(splash);
			}));
			thred.SetApartmentState(ApartmentState.STA);
			thred.Start();

			frmCheese cheese = new frmCheese();
			cheese.Load += new EventHandler(cheese_Load);
			Application.Run(cheese);
		}

		static void cheese_Load(object sender, EventArgs e) {
			if (splash == null) return;
			splash.Invoke(new Action(splash.Close));
			splash.Dispose();
			splash = null;
		}
	}
}
