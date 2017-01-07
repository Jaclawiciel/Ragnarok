using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Klasa Map służy do utworzenia Mapy, na której będzie toczyć się cała rozgrywka. 

namespace Ragnarok
{
	class Map
	{
		public int Width { get; private set; }
		public int Height { get; private set; }

		public Map(int width, int height) {
			Width = width;
			Height = height;
		}

		//Metoda sprawdzająca czy element siatki (obiekt typu MapLocation) znajduje się w obrębie mapy. 
		public bool OnMap(MapLocation location) {
			return location.X >= 0 && location.X < Width &&
				   location.Y >= 0 && location.Y < Height;
		}
	}
}
