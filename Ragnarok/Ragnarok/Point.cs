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
	}
}
