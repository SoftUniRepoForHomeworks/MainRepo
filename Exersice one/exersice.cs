using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Globalization;
using System.Numerics;
using System.Text;

namespace currentProjectForSolvingTest
{
	class MainClass
	{
		public static void Main ()
		{
			int firstNum = int.Parse (Console.ReadLine ());
			int secondNum = int.Parse (Console.ReadLine ());
			int thirdNum = int.Parse (Console.ReadLine ());
			int forthNum = int.Parse (Console.ReadLine ());

			Console.WriteLine ($"{firstNum:D4} {secondNum:D4} {thirdNum:D4} {forthNum:D4}");
		}
	}
}
