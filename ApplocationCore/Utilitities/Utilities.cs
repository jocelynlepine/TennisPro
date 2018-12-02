using System;
using System.Collections.Generic;
using System.Text;

namespace ApplocationCore.Utilities
{
    public static class Utilities
    {
        public static int getRandomInt(int minValue, int maxValue)
        {
            Random rnd = new Random();
            return rnd.Next(minValue, maxValue); // creates a number between minValue and maxValue
        }
    }
}
