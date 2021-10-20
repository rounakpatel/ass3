using System;

using A3.Eggs;
namespace A3.Birds
{
	class Bird
	{
		public static Random Rand = new Random(1);
		public virtual Egg[] LayEggs(int numEggs)
		{
			Console.Error.WriteLine("Bird.LayEggs should not be called!");
			return new Egg[0];
		}
	}

	class Chicken : Bird
	{
     public override Egg[] LayEggs (int numEggs)

			for (int i = 0; i < numEggs; ++1)
	{
	  double eggsize = Math.Round(Rand.NextDouble() * (4 - 2) + 2, 1);
		// egg
		Egg egg = new Egg(eggsize, Eggs.Egg.Colors.brown);

		// broken egg
		BrokenEgg Br_egg = new BrokenEgg(eggsize, Eggs.BrokenEgg.Colors.brown);
	}

	class Ostrich : Bird 
	{
		public override Egg[] LayEggs(int numEggs)
		{ 

			for (int i = 0; i < numEggs; ++1)
			{
				double eggsize = Math.Round(Rand.NextDouble() * (15 - 10) + 10, 1);
				// egg
				Egg egg = new Egg(eggsize, eggsize.Egg.Colors.speckled);

				// broken egg
				BrokenEgg Br_egg = new BrokenEgg(eggsize, eggsize.BrokenEgg.Colors.speckled);
	}
}
