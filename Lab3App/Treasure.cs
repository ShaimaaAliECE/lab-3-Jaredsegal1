using Lab3App;
using System;
using System.Collections.Generic;

namespace Lab3App{
	public abstract class Treasure : Collectable
	{
		public int Score { get; protected set; }
		public virtual void UpdateTotalScore()
		{
			Board.TotalScore += Score;
			Console.WriteLine($"Total Score is updated to {Board.TotalScore}");
		}

		public override void AddMe(List<Collectable> collected)
		{
			base.AddMe(collected);
			UpdateTotalScore();
		}
		public Treasure(string description, int score) : base(description) {Score = score }

	}
}
