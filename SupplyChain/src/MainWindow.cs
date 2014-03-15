using System;
using Gtk;

namespace SupplyChain
{
	public partial class MainWindow: Gtk.Window
	{
		public MainWindow () : base (Gtk.WindowType.Toplevel)
		{
			Build ();
		}

		private void ReadImportData ()
		{
			String strPlanningData = ""
			XMLParser Parser = new XMLParser()

		}

		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			Application.Quit ();
			a.RetVal = true;
		}
	}
}