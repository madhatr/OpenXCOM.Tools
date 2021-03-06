﻿using System;
using System.IO;

using DSShared.Windows;


namespace MapView.SettingServices
{
	/// <summary>
	/// Deals with Volutar's MCD Editor app.
	/// </summary>
	internal sealed class VolutarSettingService
	{
		private const string VolutarMcdEditorPath = "VolutarMcdEditorPath";

		private readonly Settings _settings;

		private string _fullpath;
		internal string FullPath
		{
			get
			{
				var setting = _settings.GetSetting(VolutarMcdEditorPath, String.Empty);

				_fullpath = setting.Value as String;
				if (!File.Exists(_fullpath))
				{
					using (var f = new InputBox("Enter the Volutar MCD Editor Path in full"))
					{
						if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK
							&& File.Exists(f.InputString))
						{
							_fullpath = f.InputString;
							setting.Value = (object)f.InputString;
						}
						// TODO: Error handling. As is the input form simply disappears.
					}
				}
				return _fullpath;
			}
		}


		internal VolutarSettingService(Settings settings)
		{
			_settings = settings;
		}


		public static void LoadSettings(Settings settings)
		{
			settings.AddSetting(
							VolutarMcdEditorPath,
							String.Empty,
							"Path to Volutar MCD Editor",
							"TileView");
		}
	}
}
