﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Klasa MapLocation służy do utworzenia obiektów, które reprezentują jeden element siatki mapy (jeden kwadrat). 
//Dziedziczy ona swoje podstawowe funkcje z bardzo ogólnej klasy Point. 
//Na tych elementach mogą znaleźć się: 
//- ścieżka, po której poruszają się przeciwnicy, 
//- przeciwnicy, 
//- wieże
//Odwzorowanie w formsach - jeden button na jeden obiekt typu MapLocation

namespace Ragnarok {
	class MapLocation : Point {
		public MapLocation(int x, int y, Map map) : base(x, y) {
			if (!map.OnMap(this)) {
				throw new OutOfBoundsException(this + " is outside of the boundaries of the map.");
			}
		}

		//Metoda sprawdzająca czy obiekt MapLocation jest w zasięgu
		public bool InRangeOf(MapLocation location, int range) {
			bool isInRange = DistanceTo(location) <= range; //Obiekt typu MapLocation dziedziczy z Point (przez co także jest obiektem typu Point) więc mogę wywołać na nim metody klasy Point. 
			return isInRange;
		}
	}
}
