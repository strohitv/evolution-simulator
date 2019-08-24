using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Evolution
{
	public class MapLocation
	{
		//private Color color = Color.Black;
		private int foodPoints = 0;

		private List<Creature> creatures = new List<Creature>();

		public bool Invalidated { get; private set; } = false;

		public int FoodPoints
		{
			get => foodPoints;

			set
			{
				if (value < 0)
				{
					value = 0;
				}
				else if (value > 3)
				{
					value = 3;
				}

				if (foodPoints != value)
				{
					foodPoints = value;
					Invalidated = true;
				}
			}
		}

		public List<Creature> Creatures { get => creatures; private set => creatures = value; }

		public void AddCreature(Creature animal)
		{
			animal.X = X;
			animal.Y = Y;
			animal.Energy += FoodPoints * 50;
			FoodPoints = 0;
			Creatures.Add(animal);

			Invalidated = true;
		}

		public void RemoveCreature(Creature animal)
		{
			Creatures.Remove(animal);

			var moveCost = animal.Speed / 20;
			if (moveCost == 0)
			{
				moveCost++;
			}

			animal.Energy -= moveCost;

			Invalidated = true;
		}

		public int X { get; set; }
		public int Y { get; set; }

		public Color Color
		{
			get
			{
				Color color = Color.Black;
				
				if (Creatures.Count(c => !c.IsDead) > 0)
				{
					color = Color.AliceBlue;
				}
				else if (foodPoints > 0)
				{
					color = Color.FromArgb(0, foodPoints * 85, 0);
				}

				return color;
			}
		}

		public void MarkAsDrawn()
		{
			Invalidated = false;
		}
	}
}
