using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Klasa MapLocation służy do utworzenia obiektów, które reprezentują jeden element siatki mapy (jeden kwadrat). 
//Na tych elementach mogą znaleźć się: 
//- ścieżka, po której poruszają się przeciwnicy, 
//- przeciwnicy, 
//- wieże
//Odwzorowanie w formsach - jeden button na jeden obiekt typu MapLocation

namespace Ragnarok {
	class MapLocation {
		private Point location { get; set; } //Współrzędne jednego elementu siatki
	}
}
