﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragnarok
{
	class Point
	{
		public int X { get; private set; }
		public int Y { get; private set; }

		Point(int x, int y) {
			X = x;
			Y = y;
		}
	}
}
