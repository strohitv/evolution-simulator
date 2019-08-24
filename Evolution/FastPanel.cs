using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evolution
{
	public class FastPanel : Panel
	{
		private const int size = 500;
		public MapLocation[][] Map { get; } = new MapLocation[size][];
		private bool backgroundDrawn = false;

		public FastPanel()
		{
			bitmap = DrawFilledRectangle(1000, 1000);

			for (int i = 0; i < size; i++)
			{
				Map[i] = new MapLocation[size];

				for (int j = 0; j < Map[i].Length; j++)
				{
					Map[i][j] = new MapLocation() { X = i, Y = j };
				}
			}
		}

		protected override void OnPaintBackground(PaintEventArgs e)
		{
			if (!backgroundDrawn)
			{
				base.OnPaintBackground(e);
				backgroundDrawn = true;
			}
		}

		Bitmap bitmap;

		protected override void OnPaint(PaintEventArgs e)
		{
			var pointsToDraw = getInvalidatedPoints();
			foreach (var pointToDraw in pointsToDraw)
			{
				int i = pointToDraw.X;
				int j = pointToDraw.Y;
				
				bitmap.SetPixel(i * 2, j * 2, Map[i][j].Color);
				bitmap.SetPixel(i * 2 + 1, j * 2, Map[i][j].Color);
				bitmap.SetPixel(i * 2, j * 2 + 1, Map[i][j].Color);
				bitmap.SetPixel(i * 2 + 1, j * 2 + 1, Map[i][j].Color);

				Map[i][j].MarkAsDrawn();
			}

			e.Graphics.DrawImage(bitmap, 0, 0);
			e.Graphics.Save();
		}

		private MapLocation[] getInvalidatedPoints()
		{
			return Map.SelectMany(row => row.Where(cell => cell.Invalidated)).ToArray();
		}

		private Bitmap DrawFilledRectangle(int x, int y)
		{
			Bitmap bmp = new Bitmap(x, y);
			using (Graphics graph = Graphics.FromImage(bmp))
			{
				Rectangle ImageSize = new Rectangle(0, 0, x, y);
				graph.FillRectangle(Brushes.Black, ImageSize);
			}
			return bmp;
		}
	}
}
