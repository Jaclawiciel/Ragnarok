using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragnarok {
	//Klasa statyczna Random służy do generowania losowych wartości. Dzięki niej wprowadzimy do rozgrywki czynnik prawdopodobieństwa trafienia przeciwnika. Różne wieże będą posiadały różną skuteczność ataku. 
	static class Random {
		private static System.Random random = new System.Random();

		public static double NextDouble() {
			return random.NextDouble();
		}
        public static int Random123() {
            double temp = random.NextDouble();
            if (temp < .40) return 1;
            else if (temp < .70) return 2;
            else return 3;
        }
	}
}
