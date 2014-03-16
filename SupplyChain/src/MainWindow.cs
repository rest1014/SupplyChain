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
			String strPlanningData = "/Users/steffen/Public/Dropbox/IBSYS 2/Daten Simulator/Periode2_Eingabedaten.xml";
			XMLParser Parser = new XMLParser ();
			Parser.parseXML (strPlanningData);

		}

		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			Application.Quit ();
			a.RetVal = true;
		}
	}
}