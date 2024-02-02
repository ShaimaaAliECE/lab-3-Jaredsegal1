using System;
using System.Collections.Generic;

namespace Lab3App{
	public class Diamond : Treasure
	{

		public Diamond(string description, int score) : base(description, score)
		{
			
		}

        public override void Display()
        {
			Console.WriteLine($"Diamond {Description} is diplayed");
        }
    }
}
