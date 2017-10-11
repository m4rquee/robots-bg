using BitsGalaxy;
using System;
using System.Collections;
using System.Collections.Generic;

using State = System.Collections.Generic.Dictionary<string, object>;

namespace MyRobot {
	public class MyRobot: IRobot {
		//s = { ball-pos: (x, y), player-pos: (x, y) }

		private Random rnd;

		public ActionBlock Update(State s) {
			double bY = (double) (((ArrayList) s["ball-pos"])[1]);
			double pY = (double) (((ArrayList) s["player-pos"])[1]);

			return new ActionBlock("move", new List<object> { (double) this.rnd.Next(-5, 5) });
		}

		public MyRobot() {
			this.rnd = new Random();
		}
	}
}

