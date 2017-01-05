using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Klasa Point służy do tworzenia obiektów reprezentujących współrzędne (X, Y) na mapie. 

namespace Ragnarok
{
	class Point
	{
		public int X { get; private set; } //Współrzędna X
		public int Y { get; private set; } //Współrzędna Y

		Point(int x, int y) {
			X = x;
			Y = y;
		}
	}
}
