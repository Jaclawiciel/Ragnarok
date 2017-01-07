using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragnarok {
	class Path {
		private readonly MapLocation[] path;
		public int Length => path.Length; //Wyrażenie Lambda

		public Path(MapLocation[] path) {
			this.path = path;
		}
	}
}
