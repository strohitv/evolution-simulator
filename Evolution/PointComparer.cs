using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution
{
	public class PointComparer : IComparer<Point>
	{
		public int Compare(Point first, Point second)
		{
			int firstDistance = Math.Abs(first.X) + Math.Abs(first.Y);
			int secondDistance = Math.Abs(second.X) + Math.Abs(second.Y);

			if (firstDistance == secondDistance)
			{
				if (Math.Abs(first.X) > Math.Abs(second.X)
				   || Math.Abs(first.Y) > Math.Abs(second.Y))
				{
					return 1;
				}
				else if (Math.Abs(second.X) > Math.Abs(first.X)
					|| Math.Abs(second.Y) > Math.Abs(first.Y))
				{
					return -1;
				}
				else
				{
					return 0;
				}
			}
			else
			{
				return firstDistance.CompareTo(secondDistance);
			}
		}
	}
}
