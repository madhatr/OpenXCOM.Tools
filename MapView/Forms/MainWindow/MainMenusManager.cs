﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

using MapView.Forms.MapObservers.RouteViews;
using MapView.Forms.MapObservers.TileViews;
using MapView.Forms.MapObservers.TopViews;


namespace MapView.Forms.MainWindow
{
	internal sealed class MainMenusManager
	{
		private readonly MenuItem _viewsMenu;
		private readonly MenuItem _helpMenu;

		private readonly List<MenuItem> _allItems = new List<MenuItem>();
		private readonly List<Form>     _allForms = new List<Form>();

		private Settings _settings;

		private bool _quitting;

		private const string Divider = "-";


		internal MainMenusManager(MenuItem show, MenuItem help)
		{
			_viewsMenu = show; // why are these MenuItems
			_helpMenu  = help;
		}


		/// <summary>
		/// Adds menuitems to MapView's dropdown list.
		/// </summary>
		/// <param name="console">pointer to the console-form</param>
		/// <param name="settings">pointer to MV_SettingsFile options</param>
		internal void PopulateMenus(Form console, Settings settings)
		{
			_settings = settings;

			CreateMenuitem(ViewerFormsManager.TileView,     "Tile View",     _viewsMenu);

			_viewsMenu.MenuItems.Add(new MenuItem(Divider));

			CreateMenuitem(ViewerFormsManager.TopView,      "Top View",      _viewsMenu);
			CreateMenuitem(ViewerFormsManager.RouteView,    "Route View",    _viewsMenu);
			CreateMenuitem(ViewerFormsManager.TopRouteView, "TopRoute View", _viewsMenu);

			_viewsMenu.MenuItems.Add(new MenuItem(Divider));

			CreateMenuitem(console,                         "Console",       _viewsMenu);


			CreateMenuitem(ViewerFormsManager.HelpScreen,   "Quick Help",    _helpMenu);
			CreateMenuitem(ViewerFormsManager.AboutScreen,  "About",         _helpMenu);

			AddMenuitemSettings();
		}

		private void CreateMenuitem(
				Form f,
				string text,
				Menu parent)
		{
			f.Text = text;

			var it = new MenuItem(text);
			it.Tag = f;

			parent.MenuItems.Add(it);

			it.Click += OnMenuitemClick;

			f.Closing += (sender, e) =>
			{
				e.Cancel = true;
				it.Checked = false;
				f.Hide();
			};

			_allItems.Add(it);
			_allForms.Add(f);
		}

		private static void OnMenuitemClick(object sender, EventArgs e)
		{
			var it = (MenuItem)sender;

			if (!it.Checked)
			{
				it.Checked = true;
				((Form)it.Tag).Show();
				((Form)it.Tag).WindowState = FormWindowState.Normal;
			}
			else
			{
				it.Checked = false;
				((Form)it.Tag).Close();
			}
		}

		private void AddMenuitemSettings()
		{
			foreach (MenuItem it in _viewsMenu.MenuItems)
			{
				string key = GetWindowSettingKey(it);
				if (!String.IsNullOrEmpty(key))
				{
					_settings.AddSetting(
									key,
//									!(it.Tag is XCom.ConsoleForm) && !(it.Tag is MapView.Forms.MapObservers.TileViews.TopRouteViewForm),	// q. why is TopRouteViewForm under 'TileViews'
									(it.Tag is TopViewForm) || (it.Tag is RouteViewForm) || (it.Tag is TileViewForm),						// a. why not.
									"Viewer - " + it.Text,	// NOTE: Console is not technically a viewer, but I don't see this being used anyway.
									"Windows");				// nor do i see this used in any meaningful way yet.

					var f = it.Tag as Form;
					if (f != null)
					{
						f.VisibleChanged += (sender, e) =>
						{
							if (!_quitting)
							{
								var fsender = sender as Form;
								if (fsender != null)
									_settings[key].Value = fsender.Visible;
							}
//							if (_quitting) return;
//							var fsender = sender as Form;
//							if (fsender == null) return;
//							_settings[key].Value = fsender.Visible;
						};
					}
				}
			}
		}

		/// <summary>
		/// Opens the subsidiary viewers. All viewers will open and those that
		/// the user has flagged closed (in Options) will be re-closed.
		/// </summary>
		internal void StartViewers()
		{
			foreach (MenuItem it in _viewsMenu.MenuItems)
			{
				string key = GetWindowSettingKey(it);
				if (key != null)
				{
					if (_settings[key].IsTrue)
					{
						it.PerformClick();
					}
					else					// NOTE: does not run unless a viewer's key was
					{						// set "false" in AddMenuItemSettings() above^
						it.PerformClick();	// not sure that this double-click gimmick
						it.PerformClick();	// is necessary even then ...
					}
				}
			}
//			foreach (MenuItem it in _show.MenuItems) // NOTE: Don't do this. Go figure.
//			{
//				it.PerformClick();
//				var key = GetWindowSettingName(it);
//				if (!(_settings[key].IsTrue))
//					it.PerformClick();
//			}
			_viewsMenu.Enabled = true;
		}

		private static string GetWindowSettingKey(MenuItem it)
		{
			string suffix = it.Text;
			return (suffix != Divider) ? "Window" + Divider + suffix
									   : null;
		}

		internal ShowHideManager CreateShowAllManager()
		{
			return new ShowHideManager(_allForms, _allItems);
		}

		/// <summary>
		/// Effectively disables the VisibleChanged event for all subsidiary
		/// viewers.
		/// </summary>
		internal void IsQuitting()
		{
			_quitting = true;
		}
	}
}
