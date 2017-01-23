using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Abstrakcyjna klasa Invader posłuży jako fundament do tworzenia typów przeciwników. Każdy typ będzie z niej dziedziczył.
//Własności virtualne pozwolą na modyfikację ilości punktów życia, a także szybkości poruszania.
//Metoda virtualna może zostać użyta do modyfikacji w jaki sposób otrzymywane są obrażenia.

namespace Ragnarok {
    abstract class Invader : IInvader {
        private Path path { get; }
        private int pathStep = 0;

        protected virtual int stepSize { get; } = 1;

        public MapLocation location => path.GetLocationAt(pathStep);
        public bool PathEnded { get { return pathStep >= path.Length; } }

        public abstract int HP { get; protected set; }

        public bool IsDestroyed => HP <= 0;
        public bool IsActive => !(IsDestroyed || PathEnded);
        public Invader(Path path) {
            this.path = path;
        }

        public void Move() => pathStep += stepSize;

        public virtual void TakeDamage(int damage) {
            HP -= damage;
        }
    }
}