using System;
using System.Collections.Generic;
using System.Text;

namespace TheHeist
{
    class Bank
    {
        public int Difficulty { get; set; }
        public int Luck { get; set; }

        public Bank(int difficulty)
        {
            Difficulty = difficulty;
        }

        public void LadyLuck()
        {
            var random = new Random();
            Luck = random.Next(-10, 10);
        }
    }
}
