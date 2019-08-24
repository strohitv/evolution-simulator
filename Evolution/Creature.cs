using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Evolution
{
	public class Creature
	{
		private static Random rand = new Random();
		private static int radius = 0;
		private static int maxSensePoints = 100;
		private static List<Point> sensablePoints = new List<Point>();

		private int childrenId = 0;

		public List<int> Ids { get; private set; } = new List<int>();

		public static IReadOnlyList<Point> SensablePoints => sensablePoints.AsReadOnly();

		static Creature()
		{
			RebuildSensablePoints();
		}

		public Creature(int id)
		{
			Ids.Add(id);
		}

		public Creature(IEnumerable<int> ids, int id)
		{
			Ids = new List<int>(ids);
			Ids.Add(id);
		}

		public int X { get; set; }
		public int Y { get; set; }

		public bool IsDead => Energy == 0;

		public int Energy { get; set; } = 0;
		public int Age { get; set; } = 0;

		public int AgeBase { get; private set; } = 25;

		public int Speed { get; private set; } = 10;
		public int MovePoints { get; private set; } = 0;

		private int sensePoints = maxSensePoints;
		public int SensePoints
		{
			get
			{
				return sensePoints;
			}
			private set
			{
				sensePoints = value;

				if (maxSensePoints < value)
				{
					maxSensePoints = value;
				}

				if (Math.Pow(radius * 2 + 1, 2) - 1 < sensePoints)
				{
					RebuildSensablePoints();
				}
			}
		}

		public Point LastMovePoint { get; set; } = new Point(0, 0);

		public void ExpandMovePoints()
		{
			MovePoints += Speed;
		}

		public int GetMoveFieldsCount()
		{
			int fields = MovePoints / 10;
			MovePoints -= fields * 10;

			return fields;
		}

		public Creature Clone()
		{
			Energy /= 2;

			Creature clone = new Creature(Ids, childrenId);
			clone.Energy = Energy;
			clone.AgeBase = AgeBase;
			clone.SensePoints = SensePoints;
			clone.Speed = Speed;
			clone.X = X;
			clone.Y = Y;

			if (rand.Next(0, 25) == 0)
			{
				// Eine Eigenschaft verändern
				var change = 1;

				if (rand.Next(0, 200) % 2 == 0)
				{
					change = -1;
				}

				var value = rand.Next(0, 3) % 3;
				switch (value)
				{
					case 0:
						clone.AgeBase += change;
						break;
					case 1:
						clone.Speed += change;
						break;
					case 2:
						clone.SensePoints += change;
						break;
				}
			}

			childrenId++;

			return clone;
		}

		private static void RebuildSensablePoints()
		{
			sensablePoints = new List<Point>();

			radius = 1;

			while (maxSensePoints > Math.Pow(radius * 2 + 1, 2))
			{
				radius++;
			}

			for (int x = -radius; x <= radius; x++)
			{
				for (int y = -radius; y <= radius; y++)
				{
					sensablePoints.Add(new Point(x, y));
				}
			}

			sensablePoints.Sort(new PointComparer());
		}

		public override string ToString()
		{
			return Ids.Select(id => id.ToString()).Aggregate((first, second) => $"{first} | {second}");
		}
	}
}
