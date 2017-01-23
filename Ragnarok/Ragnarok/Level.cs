using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragnarok {
    class Level {
        public Map map = new Map(15, 10);
        public List<Tower> towers = new List<Tower>(); //nie można zrobić get; set;
        public List<IInvader> invaders = new List<IInvader>();
        public Path path = new Path(new[] { new MapLocation(0, 5, map), new MapLocation(1, 5, map), new MapLocation(2, 5, map), new MapLocation(3, 5, map),
             new MapLocation(4, 5, map), new MapLocation(5, 5, map), new MapLocation(6, 5, map), new MapLocation(7, 5, map),
             new MapLocation(8, 5, map), new MapLocation(9, 5, map), new MapLocation(10, 5, map), new MapLocation(11, 5, map),
             new MapLocation(12, 5, map), new MapLocation(13, 5, map), new MapLocation(14, 5, map), new MapLocation(15, 5, map)});
    }
}
