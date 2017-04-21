﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using MapView.Properties;


namespace MapView.Forms.MainWindow
{
	internal sealed class EditButtonsFactory
	{
		private readonly MainViewPanel _mainViewPanel;

		private readonly List<ToolStripButton> _pasteButtons = new List<ToolStripButton>();


		public EditButtonsFactory(MainViewPanel panel)
		{
			_mainViewPanel = panel;
		}


		/// <summary>
		/// Adds buttons for Up,Down,Cut,Copy,Paste and Fill to the specified
		/// toolstrip as well as sets some properties for the toolstrip.
		/// </summary>
		/// <param name="toolStrip"></param>
		public void BuildEditStrip(ToolStrip toolStrip)
		{
			//
			// toolStripButtons
			//
			//var tssDivider1 = new ToolStripSeparator();
			var tsbUp       = new ToolStripButton();
			var tsbDown     = new ToolStripButton();
			//var tssDivider2 = new ToolStripSeparator();
			var tsbCut      = new ToolStripButton();
			var tsbCopy     = new ToolStripButton();
			var tsbPaste    = new ToolStripButton();
			//var tssDivider3 = new ToolStripSeparator();
			var tsbFill     = new ToolStripButton();
			//var tssDivider4 = new ToolStripSeparator();
			//
			// toolStrip
			//
			var tsItems = new ToolStripItem[] // NOTE: c# cant figure out how to use 1 separator 3 times.
			{
				tsbUp,
				tsbDown,
                new ToolStripSeparator(),
				tsbCut,
				tsbCopy,
				tsbPaste,
                new ToolStripSeparator(),
				tsbFill,
                new ToolStripSeparator()
            };
			toolStrip.Items.AddRange(tsItems);
			//
			// tsbUp
			//
			tsbUp.AutoSize = false;
			tsbUp.DisplayStyle = ToolStripItemDisplayStyle.Image;
			tsbUp.ImageScaling = ToolStripItemImageScaling.None;
			tsbUp.ImageTransparentColor = Color.Magenta;
			tsbUp.Name = "tsbUp";
			tsbUp.Size = new Size(25, 25);
//			tsbUp.Text = "Level Up";
			tsbUp.ToolTipText = "Level Up";
			tsbUp.Click += OnUpClick;
			//
			// tsbDown
			//
			tsbDown.AutoSize = false;
			tsbDown.DisplayStyle = ToolStripItemDisplayStyle.Image;
			tsbDown.ImageScaling = ToolStripItemImageScaling.None;
			tsbDown.ImageTransparentColor = Color.Magenta;
			tsbDown.Name = "tsbDown";
			tsbDown.Size = new Size(25, 25);
//			tsbDown.Text = "Level Down";
			tsbDown.ToolTipText = "Level Down";
			tsbDown.Click += OnDownClick;
			//
			// tsbCut
			//
			tsbCut.AutoSize = false;
			tsbCut.DisplayStyle = ToolStripItemDisplayStyle.Image;
			tsbCut.ImageScaling = ToolStripItemImageScaling.None;
			tsbCut.ImageTransparentColor = Color.Magenta;
			tsbCut.Name = "tsbCut";
			tsbCut.Size = new Size(25, 25);
//			tsbCut.Text = "Cut";
			tsbCut.ToolTipText = "Cut";
			tsbCut.Click += (sender, e) =>
			{
				EnablePasteButton();
				_mainViewPanel.OnCut(sender, e);
				Refresh();
			};
			//
			// tsbCopy
			//
			tsbCopy.AutoSize = false;
			tsbCopy.DisplayStyle = ToolStripItemDisplayStyle.Image;
			tsbCopy.ImageScaling = ToolStripItemImageScaling.None;
			tsbCopy.ImageTransparentColor = Color.Magenta;
			tsbCopy.Name = "tsbCopy";
			tsbCopy.Size = new Size(25, 25);
//			tsbCopy.Text = "Copy";
			tsbCopy.ToolTipText = "Copy";
			tsbCopy.Click += (sender, e) =>
			{
				EnablePasteButton();
				_mainViewPanel.OnCopy(sender, e);
			};
			//
			// tsbPaste
			//
			tsbPaste.AutoSize = false;
			tsbPaste.DisplayStyle = ToolStripItemDisplayStyle.Image;
			tsbPaste.ImageScaling = ToolStripItemImageScaling.None;
			tsbPaste.ImageTransparentColor = Color.Magenta;
			tsbPaste.Name = "tsbPaste";
			tsbPaste.Size = new Size(25, 25);
//			tsbPaste.Text = "Paste";
			tsbPaste.ToolTipText = "Paste";
			tsbPaste.Click += (sender, e) =>
			{
				_mainViewPanel.OnPaste(sender, e);
				Refresh();
			};
			tsbPaste.Enabled = false;
			_pasteButtons.Add(tsbPaste);
			//
			// tsbFill
			//
			tsbFill.AutoSize = false;
			tsbFill.DisplayStyle = ToolStripItemDisplayStyle.Text;
			tsbFill.Name = "tsbFill";
			tsbFill.Size = new Size(25, 25);
			tsbFill.Text = "Fill";
			tsbFill.ToolTipText = "Fill";
			tsbFill.Click += (sender, e) =>
			{
				_mainViewPanel.OnFill(sender, e);
				Refresh();
			};
			tsbUp.Image    = Resources.up;
			tsbDown.Image  = Resources.down;
			tsbCut.Image   = Resources.cut;
			tsbCopy.Image  = Resources.copy;
			tsbPaste.Image = Resources.paste;
//			tsbFill.Image  = ; // TODO: embed a Fill image.
		}

		private static void Refresh()
		{
//			MainViewPanel.Instance.Refresh();			// either this
			MainViewPanel.Instance.MainView.Refresh();	// or this, both works

			ViewerFormsManager.TopView.Refresh();
			ViewerFormsManager.RouteView.Refresh();

			// TODO: refresh TopRouteView (both Top & Route panels) also.
		}

		/// <summary>
		/// Enables the paste button in each viewer after cut or copy is clicked.
		/// </summary>
		private void EnablePasteButton()
		{
			foreach (var tsb in _pasteButtons)
				tsb.Enabled = true;
		}

		private void OnDownClick(object sender, EventArgs e)
		{
			if (MainViewPanel.Instance.MainView.Map != null)
				MainViewPanel.Instance.MainView.Map.Down();
		}

		private void OnUpClick(object sender, EventArgs e)
		{
			if (MainViewPanel.Instance.MainView.Map != null)
				MainViewPanel.Instance.MainView.Map.Up();
		}
	}
}
