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

		public MapLocation GetLocationAt(int pathStep) {
			if (pathStep < Length) {
				return path[pathStep];
			} else {
				return null;
			}
		}

		public bool IsOnPath(MapLocation location) {
			foreach (var pathLocation in path) {
				if(location.Equals(pathLocation)) {
					return true;
				}
			}
			return false;
		}
	}
}
