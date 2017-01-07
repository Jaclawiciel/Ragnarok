using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragnarok {
	class RagnarokException : Exception {
		public RagnarokException() {

		}

		public RagnarokException(string message) : base(message) {

		}
	}

	class OutOfBoundsException : RagnarokException {
		public OutOfBoundsException() {

		}

		public OutOfBoundsException(string message) : base(message) {

		}
	}
}
