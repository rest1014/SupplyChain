using System;
using ExtensionMethods;

namespace KeyData
{
	public class KeyData: Object
	{
		//Properties.
		private string _Description;
		private double _Current;
		private double _Average;
		private double _Sum;
		// Instance Constructor.
		public KeyData (String current, String average, String sum)
		{
			_Description = MyExtensions.TestString (desctription);
			_Current = MyExtensions.TestString (current);
			_Average = MyExtensions.TestString (average);
			_Sum = MyExtensions.TestString (sum);

		}
		//Getter & Setter
		public string Description {
			get {
				return _Description;
			}
			set {
				_Description = MyExtensions.TestString (value);
			}

		}

		public double Current {
			get {
				return _Current; 
			}
			set {
				_Current = MyExtensions.TestString (value);
			}
		}

		public double Average {
			get {
				return _Average; 
			}
			set {
				_Average = MyExtensions.TestString (value);
			}
		}

		public double Sum {
			get {
				return _Sum; 
			}
			set {
				_Sum = MyExtensions.TestString (value);
			}
		}

		public override string ToString ()
		{
			return this.Description & "<Current: " & this.Current & " Average: " & this.Average &
			" Sum: " & this.Sum & ">"; 
		}

		public override bool Equals (Object obj)
		{
			if (obj == null || GetType () != obj.GetType ())
				return false;

			KeyData kd = (KeyData)obj;
			return (_Description == kd.Description) &&
			(_Current == kd.Current) &&
			(_Average == kd.Average) &&
			(_Sum == kd.Sum);
		}

		public override int GetHashCode ()
		{

			return this.Description.GetHashCode & this.Current.GetHashCode &
			this.Average.GetHashCode & this.Sum.GetHashCode;
		}
	}
}

