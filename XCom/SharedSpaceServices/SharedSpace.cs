using System;
using System.Collections.Generic;
using XCom.Interfaces;


namespace XCom
{
	public sealed class SharedSpace
	{
		private static SharedSpace _instance;

		private readonly Dictionary<string, object> _share;

		public const string ApplicationDirectory = "ApplicationDirectory";
		public const string SettingsDirectory    = "SettingsDirectory";

		public const string CustomDirectory   = "CustomDirectory"; // for PckView ->
		public const string Palettes          = "Palettes";
		public const string ImageTypes        = "ImageTypes";

		public const string CursorFile  = "cursorFile";
		public const string Cursor      = "CURSOR";


		public SharedSpace()
		{
			_share = new Dictionary<string, object>();
		}


		public static SharedSpace Instance
		{
			get
			{
				if (_instance == null)
					_instance = new SharedSpace();

				return _instance;
			}
		}

		/// <summary>
		/// Allocates a key-val pair in the SharedSpace and returns the value
		/// that is assigned. This does not change the value of an existing key
		/// unless its value is null.
		/// </summary>
		/// <param name="key">the key to look for</param>
		/// <param name="value">the object to add if the current value doesn't
		/// exist or is null</param>
		/// <returns>the value associated with the key as an object</returns>
		public object SetShare(string key, object value = null)
		{
			if (!_share.ContainsKey(key))
			{
				_share.Add(key, value);
			}
			else if (_share[key] == null)
			{
				_share[key] = value;
			}

			return _share[key];
		}

		public object this[string key]
		{
			get { return _share[key]; }
			set { _share[key] = value; }
		}

		public string GetString(string key)
		{
			return (string)_share[key];
		}

		public int GetIntegralValue(string key) // not used.
		{
			return (int)_share[key];
		}

		public double GetDouble(string key) // not used.
		{
			return (double)_share[key];
		}

		public List<XCImageFile> GetImageModList()
		{
			return (List<XCImageFile>)_share[ImageTypes];
		}

		public Dictionary<string, Palette> GetPaletteTable()
		{
			return (Dictionary<string, Palette>)_share[Palettes];
		}
	}
}
