using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Evolution
{
	public partial class MainForm : Form
	{
		Random r = new Random();
		List<int[]> positions = new List<int[]>();

		int clock = 0;

		public MainForm()
		{
			InitializeComponent();

			SpawnFood(2000);
			SpawnCreatures(500);
			welt.Invalidate();
		}

		public void SpawnFood(int count)
		{
			for (int i = 0; i < count; i++)
			{
				int x = r.Next(0, 499);
				int y = r.Next(0, 499);

				welt.Map[x][y].FoodPoints++;
			}
		}

		public void SpawnCreatures(int count)
		{
			for (int i = 0; i < count; i++)
			{
				int x = r.Next(0, 499);
				int y = r.Next(0, 499);

				welt.Map[x][y].AddCreature(new Creature(i) { Energy = 200 });
			}
		}

		int currentFoodSpawn = 1000;
		int minFoodSpawn = 20;

		private void ticker_Tick(object sender, EventArgs e)
		{
			//SpawnFood(r.Next(0, 200));
			SpawnFood(currentFoodSpawn);
			if (currentFoodSpawn > minFoodSpawn)
			{
				currentFoodSpawn--;
			}

			var creatures = welt.Map.SelectMany(line => line.SelectMany(cell => cell.Creatures).Where(cell => cell.Energy > 0)).ToArray();
			var creatureCount = creatures.Length;

			foreach (var creature in creatures)
			{
				creature.Age++;

				if (r.Next(0, creature.Age) >= creature.AgeBase)
				//if (r.Next(0, creature.Age) >= 250)
				{
					// Kreatur ist an Alterschwäche gestorben.
					creature.Energy = 0;
					welt.Map[creature.X][creature.Y].RemoveCreature(creature);
					continue;
				}

				creature.ExpandMovePoints();

				var cloneValue = r.Next(0, creature.Age);
				if (creature.Energy > 100 && cloneValue >= 10 && cloneValue <= 40)// ) // 
				{
					Creature clone = creature.Clone();

					welt.Map[creature.X][creature.Y].AddCreature(clone);
					creatureCount++;
				}

				int allowedFieldsToMove = creature.GetMoveFieldsCount();

				for (int i = 0; i < allowedFieldsToMove; i++)
				{
					Point p = GetNextMovingPoint(creature);
					creature.LastMovePoint = p;

					welt.Map[creature.X][creature.Y].RemoveCreature(creature);
					welt.Map[(500 + creature.X + p.X) % 500][(500 + creature.Y + p.Y) % 500].AddCreature(creature);
				}
			}

			var allLivingCreatures = welt.Map.SelectMany(line => line.SelectMany(cell => cell.Creatures).Where(cell => cell.Energy > 0)).ToArray();
			var maxEnergy = 0;
			var minEnergy = 0;
			var maxSpeed = 0;
			var minSpeed = 0;
			var maxAgeBase = 0;
			var minAgeBase = 0;
			var maxSensePoints = 0;
			var minSensePoints = 0;
			var maxGeneration = 0;
			var minGeneration = 0;
			var dominantSpecies = 0;

			if (allLivingCreatures.Length > 0)
			{
				maxEnergy = allLivingCreatures.Max(c => c.Energy);
				minEnergy = allLivingCreatures.Min(c => c.Energy);

				maxSpeed = allLivingCreatures.Max(c => c.Speed);
				minSpeed = allLivingCreatures.Min(c => c.Speed);

				maxAgeBase = allLivingCreatures.Max(c => c.AgeBase);
				minAgeBase = allLivingCreatures.Min(c => c.AgeBase);

				maxSensePoints = allLivingCreatures.Max(c => c.SensePoints);
				minSensePoints = allLivingCreatures.Min(c => c.SensePoints);

				maxGeneration = allLivingCreatures.GroupBy(cr => cr.Ids.Count).Max(group => group.Key);
				minGeneration = allLivingCreatures.GroupBy(cr => cr.Ids.Count).Min(group => group.Key);

				dominantSpecies = allLivingCreatures.GroupBy(cr => cr.Ids.First()).OrderByDescending(group => group.Key).First().Select(group => group.Ids.First()).First();
			}

			creatureCountLabel.Text = $"Anzahl Kreaturen: {creatureCount}";

			maxEnergyLabel.Text = $"Energie der lebendigsten Kreatur: {maxEnergy}";
			minEnergyLabel.Text = $"Energie der schwächsten Kreatur: {minEnergy}";

			maxSpeedLabel.Text = $"Höchster Speed: {maxSpeed}";
			minSpeedLabel.Text = $"Niedrigster Speed: {minSpeed}";

			maxAgeBaseLabel.Text = $"Höchste AgeBase: {maxAgeBase}";
			minAgeBaseLabel.Text = $"Niedrigste AgeBase: {minAgeBase}";

			maxSensePointsLabel.Text = $"Höchste SensePoints: {maxSensePoints}";
			minSensePointsLabel.Text = $"Niedrigste SensePoints: {minSensePoints}";

			maxGenerationLabel.Text = $"Höchste Generation: {maxGeneration}";
			minGenerationLabel.Text = $"Niedrigste Generation: {minGeneration}";

			dominantSpeciesLabel.Text = $"Startwesen mit den meisten Nachkommen: {dominantSpecies}";

			var deadCreatures = welt.Map.SelectMany(line => line.SelectMany(cell => cell.Creatures).Where(cell => cell.Energy <= 0)).ToArray();
			foreach (var cr in deadCreatures)
			{
				welt.Map[cr.X][cr.Y].RemoveCreature(cr);
			}

			welt.Invalidate();
		}

		private Point GetNextMovingPoint(Creature creature)
		{
			Point nextPoint = new Point(0, 0);

			if (!PointSensed(creature, welt.Map, ref nextPoint))
			{
				nextPoint = creature.LastMovePoint;

				if (nextPoint.X == 0 && nextPoint.Y == 0 || r.Next(0, 25) == 0)
				{
					bool swap = r.Next(0, 10) % 2 == 0;

					if (swap)
					{
						nextPoint = new Point(nextPoint.Y, nextPoint.X);
					}
					
					if (nextPoint.X == 0)
					{
						nextPoint.X = r.Next(0, 10) % 2 == 0 ? 1 : -1;
					}
					else if (nextPoint.Y == 0)
					{
						nextPoint.Y = r.Next(0, 10) % 2 == 0 ? -1 : 1;
					}
					else
					{
						if (r.Next(0, 10) % 2 == 0)
						{
							nextPoint.Y = 0;
						}
						else
						{
							nextPoint.X = 0;
						}
					}

					if (swap)
					{
						nextPoint = new Point(nextPoint.Y, nextPoint.X);
					}
				}
			}

			return nextPoint;
		}

		private bool PointSensed(Creature creature, MapLocation[][] map, ref Point nextPoint)
		{
			bool pointSensed = false;

			for (int i = 0; i < creature.SensePoints; i++)
			{
				Point sensablePoint = Creature.SensablePoints[i];
				Point lookAt = new Point(creature.X + sensablePoint.X, creature.Y + sensablePoint.Y);

				if (welt.Map[(500 + lookAt.X) % 500][(500 + lookAt.Y) % 500].FoodPoints > 0)
				{
					pointSensed = true;

					nextPoint = new Point(0, 0);

					if (sensablePoint.X < 0)
					{
						nextPoint.X = -1;
					}
					else if (sensablePoint.X > 0)
					{
						nextPoint.X = 1;
					}

					if (sensablePoint.Y < 0)
					{
						nextPoint.Y = -1;
					}
					else if (sensablePoint.Y > 0)
					{
						nextPoint.Y = 1;
					}

					break;
				}
			}

			return pointSensed;
		}

		private int RollDirection()
		{
			int dice = r.Next(0, 29);

			return (dice % 3) - 1;
		}
	}
}
