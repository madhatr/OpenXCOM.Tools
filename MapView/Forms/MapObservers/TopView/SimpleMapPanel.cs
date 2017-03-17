using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using MapView.Forms.MapObservers.RouteViews;

using XCom;
using XCom.Interfaces.Base;


namespace MapView.Forms.MapObservers.TopViews
{
	public class SimpleMapPanel
		:
		Map_Observer_Control
	{
		private int _offX = 0;
		private int _offY = 0;

		private readonly GraphicsPath _cell;
		private readonly GraphicsPath _copy;
		private readonly GraphicsPath _sel;

		private int _mR = -1;
		private int _mC = -1;

		private DrawContentService _drawService = new DrawContentService();

		protected DrawContentService DrawService
		{
			get { return _drawService; }
		}

		private int _heightMin = 4;

		public int MinHeight
		{
			get { return _heightMin; }
			set
			{
				_heightMin = value;
				ParentSize(Width, Height);
			}
		}


		public SimpleMapPanel()
		{
			_cell	= new GraphicsPath();
			_sel	= new GraphicsPath();
			_copy	= new GraphicsPath();
		}


		public void ParentSize(int width, int height)
		{
			if (map != null)
			{
				var hWidth  = _drawService.HWidth;
				var hHeight = _drawService.HHeight;
				
				int curWidth = hWidth;

				if (map.MapSize.Rows > 0 || map.MapSize.Cols > 0)
				{
					if (height > width / 2) // use width
					{
						hWidth = width / (map.MapSize.Rows + map.MapSize.Cols);

						if (hWidth % 2 != 0)
							hWidth--;

						hHeight = hWidth / 2;
					}
					else // use height
					{
						hHeight = height / (map.MapSize.Rows + map.MapSize.Cols);
						hWidth = hHeight * 2;
					}
				}

				if (hHeight < _heightMin)
				{
					hWidth  = _heightMin * 2;
					hHeight = _heightMin;
				}

				_drawService.HWidth  = hWidth;
				_drawService.HHeight = hHeight;

				_offX = 4 + map.MapSize.Rows * hWidth;
				_offY = 4;

				if (curWidth != hWidth)
				{
					Width  = 8 + (map.MapSize.Rows + map.MapSize.Cols) * hWidth;
					Height = 8 + (map.MapSize.Rows + map.MapSize.Cols) * hHeight;

					Refresh();
				}
			}
		}

		[Browsable(false), DefaultValue(null)] // NOTE: this is only for the designer, it doesn't actually set the default-value.
		public override IMap_Base Map
		{
			set
			{
				map = value;
				_drawService.HWidth = 7;
				ParentSize(Parent.Width, Parent.Height);

				Refresh();
			}
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			SetSelectionRect();
		}

		protected void ViewDrag(object sender, EventArgs e)
		{
			SetSelectionRect();
		}

		private void SetSelectionRect()
		{
			var s = GetDragStart();
			var e = GetDragEnd();

			var hWidth  = _drawService.HWidth;
			var hHeight = _drawService.HHeight;

			var sel1 = new Point(
							_offX + (s.X - s.Y) * hWidth,
							_offY + (s.X + s.Y) * hHeight);
			var sel2 = new Point(
							_offX + (e.X - s.Y) * hWidth + hWidth,
							_offY + (e.X + s.Y) * hHeight + hHeight);
			var sel3 = new Point(
							_offX + (e.X - e.Y) * hWidth,
							_offY + (e.X + e.Y) * hHeight + hHeight + hHeight);
			var sel4 = new Point(
							_offX + (s.X - e.Y) * hWidth - hWidth,
							_offY + (s.X + e.Y) * hHeight + hHeight);

			_copy.Reset();
			_copy.AddLine(sel1, sel2);
			_copy.AddLine(sel2, sel3);
			_copy.AddLine(sel3, sel4);
			_copy.CloseFigure();

			Refresh();
		}

		private static Point GetDragStart()
		{
			var s = new Point(0, 0);
			s.X = Math.Min(
						MapViewPanel.Instance.MapView.DragStart.X,
						MapViewPanel.Instance.MapView.DragEnd.X);
			s.Y = Math.Min(
						MapViewPanel.Instance.MapView.DragStart.Y,
						MapViewPanel.Instance.MapView.DragEnd.Y);
			return s;
		}

		private static Point GetDragEnd()
		{
			var e = new Point(0, 0);
			e.X = Math.Max(
						MapViewPanel.Instance.MapView.DragStart.X,
						MapViewPanel.Instance.MapView.DragEnd.X);
			e.Y = Math.Max(
						MapViewPanel.Instance.MapView.DragStart.Y,
						MapViewPanel.Instance.MapView.DragEnd.Y);
			return e;
		}

		[Browsable(false), DefaultValue(null)] // NOTE: DefaultValue has meaning only for the designer. Fortunately the default value of the class variable *is* null.
		public Dictionary<string, SolidBrush> Brushes
		{ get; set; }

		[Browsable(false), DefaultValue(null)] // NOTE: DefaultValue has meaning only for the designer. Fortunately the default value of the class variable *is* null.
		public Dictionary<string, Pen> Pens
		{ get; set; }

		public override void SelectedTileChanged(IMap_Base sender, SelectedTileChangedEventArgs e)
		{
			MapLocation pt = e.MapPosition;
//			Text = "c: " + pt.Col + " r: " + pt.Row; // I don't think this actually prints anywhere.

			var hWidth  = _drawService.HWidth;
			var hHeight = _drawService.HHeight;

			int xc = (pt.Col - pt.Row) * hWidth;
			int yc = (pt.Col + pt.Row) * hHeight;

			_sel.Reset();
			_sel.AddLine(
					xc, yc,
					xc + hWidth, yc + hHeight);
			_sel.AddLine(
					xc + hWidth, yc + hHeight,
					xc, yc + 2 * hHeight);
			_sel.AddLine(
					xc, yc + 2 * hHeight,
					xc - hWidth, yc + hHeight);
			_sel.CloseFigure();

			ViewDrag(null, null);

			Refresh();
		}

		private Point ConvertCoordsDiamond(int x, int y)
		{
			// 16 is half the width of the diamond
			// 24 is the distance from the top of the diamond to the very top of the image

			var hWidth  = (double)_drawService.HWidth;
			var hHeight = (double)_drawService.HHeight;

			double x1 =  (x          / (hWidth * 2)) + (y / (hHeight * 2));
			double x2 = -(x - y * 2) / (hWidth * 2);

			return new Point(
						(int)Math.Floor(x1),
						(int)Math.Floor(x2));
		}

		protected virtual void RenderCell(
				MapTileBase tile,
				Graphics g,
				int x, int y)
		{}

		protected GraphicsPath CellPath(int x, int y)
		{
			var hWidth  = _drawService.HWidth;
			var hHeight = _drawService.HHeight ;

			_cell.Reset();
			_cell.AddLine(
						x, y,
						x + hWidth, y + hHeight);
			_cell.AddLine(
						x + hWidth, y + hHeight,
						x, y + 2 * hHeight);
			_cell.AddLine(
						x, y + 2 * hHeight,
						x - hWidth, y + hHeight);
			_cell.CloseFigure();
			return _cell;
		}

		protected override void Render(Graphics backBuffer)
		{
			backBuffer.FillRectangle(SystemBrushes.Control, ClientRectangle);

			var hWidth  = _drawService.HWidth;
			var hHeight = _drawService.HHeight;

			if (map != null)
			{
				for (int
						r = 0, startX = _offX, startY = _offY;
						r < map.MapSize.Rows;
						r++, startX -= hWidth, startY += hHeight)
				{
					for (int
							c = 0, x = startX, y = startY;
							c < map.MapSize.Cols;
							c++, x += hWidth, y += hHeight)
					{
						MapTileBase mapTile = map[r, c];

						if (mapTile != null)
							RenderCell(mapTile, backBuffer, x, y);
					}
				}

				for (int i = 0; i <= map.MapSize.Rows; i++)
					backBuffer.DrawLine(
									Pens["GridColor"],
									_offX - i * hWidth,
									_offY + i * hHeight,
									(map.MapSize.Cols - i) * hWidth  + _offX,
									(map.MapSize.Cols + i) * hHeight + _offY);

				for (int i = 0; i <= map.MapSize.Cols; i++)
					backBuffer.DrawLine(
									Pens["GridColor"],
									_offX + i * hWidth,
									_offY + i * hHeight,
									i * hWidth  - map.MapSize.Rows * hWidth  + _offX,
									i * hHeight + map.MapSize.Rows * hHeight + _offY);

				if (_copy != null)
					backBuffer.DrawPath(Pens["SelectColor"], _copy);

//				if (selected != null) // clicked on
//					backBuffer.DrawPath(new Pen(Brushes.Blue, 2), selected);

				if (   _mR > -1
					&& _mC > -1
					&& _mR < map.MapSize.Rows
					&& _mC < map.MapSize.Cols)
				{
					int x = (_mC - _mR) * hWidth  + _offX;
					int y = (_mC + _mR) * hHeight + _offY;

					GraphicsPath selPath = CellPath(x, y);
					backBuffer.DrawPath(Pens["MouseColor"], selPath);
				}
			}
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			if (map != null)
			{
				var pt = ConvertCoordsDiamond(
											e.X - _offX,
											e.Y - _offY);
				map.SelectedTile = new MapLocation(
												pt.Y,
												pt.X,
												map.CurrentHeight);

				_mDown = true;
				MapViewPanel.Instance.MapView.SetDrag(pt, pt);
			}
		}

		private bool _mDown = false;

		protected override void OnMouseUp(MouseEventArgs e)
		{
			_mDown = false;
			MapViewPanel.Instance.MapView.Refresh();

			Refresh();
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			var pt = ConvertCoordsDiamond(
										e.X - _offX,
										e.Y - _offY);
			if (pt.X != _mC || pt.Y != _mR)
			{
				_mC = pt.X;
				_mR = pt.Y;

				if (_mDown)
					MapViewPanel.Instance.MapView.SetDrag(
													MapViewPanel.Instance.MapView.DragStart,
													pt);

				Refresh(); // mouseover refresh for TopView.
			}
		}

/*		protected override void OnMouseWheel(MouseEventArgs e) // doesn't appear to do anything.
		{
//			base.OnMouseWheel(e);
//			if		(e.Delta < 0) map.Up();
//			else if	(e.Delta > 0) map.Down();
		} */
	}
}
