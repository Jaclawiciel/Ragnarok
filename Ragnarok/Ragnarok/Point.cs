using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Klasa Point służy do tworzenia obiektów reprezentujących współrzędne (X, Y). 
//Z klasy Point dziedziczy klasa MapLocation
//Raz napisana klasa Point może być wykorzystywana w innych projektach, ponieważ nie posiada żadnych charakterystycznych funkcji dla gry Ragnarok

namespace Ragnarok
{
	class Point
	{
		public int X { get; private set; } //Współrzędna X
		public int Y { get; private set; } //Współrzędna Y

		public Point(int x, int y) {
			X = x;
			Y = y;
		}

		//Metoda obliczająca odległość między dwoma punktami
		public int DistanceTo(int x, int y) {
			//Wzór na odległość między punktami -> http://matematyka.pisz.pl/strona/1248.html
			
			//Odejmowanie w nawiasach
			int subX = x - X;
			int subY = y - Y;

			//Podniesienie nawiasów do kwadratu
			int powX = (int)Math.Pow(subX, 2);
			int powY = (int)Math.Pow(subY, 2);

			//Suma nawiasów podniesionych do kwadratu
			int sum = powX + powY;

			//Pierwiastek
			int distance = (int)Math.Sqrt(sum);

			return distance; //Zwracamy wynik
		}

		//Możliwość obliczenia odległości między punktami z przekazaniem obiektu typu Point poprzez przeciążenie
		public int DistanceTo(Point point) {
			return DistanceTo(point.X, point.Y);
		}

		public override string ToString() {
			return X + ", " + Y;
		}

		//Można jeszcze dopisać override metody Equal do sprawdzania czy różne Punkty są równe i GetHashCode do nadawania ID obiektom
		
		public override bool Equals(object obj) {
			if (!(obj is Point)) { //Jeśli obiekt obj nie jest typem Point (nie powstał z klasy Point, ani nie dziedziczy po klasie Point) to obiekty nie mogą być takie same (zwracamy false)
				return false;
			} else {
				Point that = obj as Point; //Tworzę obiekt "that" castując obiekt obj do typu Point
				return this.X == that.X && this.Y == that.Y;
			}
		}
		/*
		public override int GetHashCode() {
			return base.GetHashCode();
		}
		*/
	}
}
