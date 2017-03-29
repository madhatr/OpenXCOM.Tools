using System;
using System.IO;
using System.Collections.Generic;


namespace DSShared
{
	/// <summary>
	/// This is used with VarCollection_Structure for PckView.
	/// </summary>
	internal sealed class Variable
	{
		private static int count = 0;

		private readonly string varName;
		private string varValue;
		private readonly List<string> list;

		/// <summary>
		/// </summary>
		public Variable(string prefix, string post)
		{
			varName = "${var" + (count++) + "}";
			varValue = post;
			list = new List<string>();
			list.Add(prefix);
		}

		/// <summary>
		/// </summary>
		public string Name
		{
			get { return varName; }
		}

		/// <summary>
		/// </summary>
		public string Value
		{
			get { return varValue; }
			set { varValue = value; }
		}

		/// <summary>
		/// </summary>
		public Variable(string baseVar, string prefix, string post)
		{
			varName = "${var" + baseVar + (count++) + "}";
			varValue = post;
			list = new List<string>();
			list.Add(prefix);
		}

		/// <summary>
		/// </summary>
		public void Inc(string prefix)
		{
			list.Add(prefix);
		}

		/// <summary>
		/// </summary>
		public void Write(StreamWriter sw)
		{
			Write(sw, String.Empty);
		}

		/// <summary>
		/// </summary>
		public void Write(StreamWriter sw, string pref)
		{
			if (list.Count > 1)
			{
				sw.WriteLine(pref + varName + Varidia.Separator + varValue);
				foreach (string pre in list)
					sw.WriteLine(pref + pre + varName);
			}
			else
				sw.WriteLine(pref + (string)list[0] + varValue);
		}
	}
}
