using System;
using System.Collections;
using KeyData;

namespace XMLParser
{
	public class XMLParser
	{
		public XMLParser ()
		{

		}

		public void parseXML (string strPath)
		{
			try {
				XmlTextReader reader = new XmlTextReader (strPath);
				reader.Read ();
				Console.WriteLine ("--- Dateianfang ---");
				Console.WriteLine (reader.ReadToEnd ());
				Console.WriteLine ("--- Dateiende -----");

				Console.WriteLine (reader.NodeType); // It prints "XmlDeclaration"

				reader.MoveToContent ();
				Console.WriteLine (reader.NodeType); // It prints "Element"
				Console.WriteLine (reader.Name); // "rss"
				Console.WriteLine (reader.GetAttribute ("version")); // Maybe "0.92"

				// proceed content until we reach "item" element
				while (!reader.EOF && reader.Name != "item")
					reader.Read ();

				reader.Read (); // Move from "item" to "title"
				while (reader.NodeType == XmlNodeType.Whitespace)
					reader.Read ();
				Console.WriteLine ("Title : " + reader.ReadString ());

				reader.Read (); // from "</title>" to whitespace
				reader.Read (); // from whitespace to <link>
				Console.WriteLine ("Link  : " + reader.ReadString ());

				reader.Read (); // from "</link>" to whitespace
				reader.Read (); // from whitespace to <pubDate>
				Console.WriteLine ("Date  : " + reader.ReadString ());

				reader.Read (); // from "</pubDate>" to whitespace
				reader.Read (); // from whitespace to <description>
				Console.WriteLine ("Description : " + reader.ReadString ());

			}

			// Datei nicht gefunden

			catch (FileNotFoundException ex) {
				Console.WriteLine (ex.Message);
			} 

			// Verzeichnis existiert nicht

			catch (DirectoryNotFoundException ex) {
				Console.WriteLine (ex.Message);
			}

			// Pfadangabe war 'null'

			catch (ArgumentNullException ex) {
				Console.WriteLine (ex.Message);
			}

			// Pfadangabe war leer ("")

			catch (ArgumentException ex) {
				Console.WriteLine (ex.Message);
			}

			// allgemeine Exception

			catch (Exception ex) {
				Console.WriteLine (ex.Message);
			}
		}

		private ArrayList GetKeyData ()
		{
			ArrayList KeyData = new ArrayList (KeyData);


		}
	}
}

