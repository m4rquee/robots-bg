﻿using BitsGalaxy;
using System.Collections;
using System.Collections.Generic;

using State = System.Collections.Generic.Dictionary<string, object>;

namespace MyRobot {
	public class MyRobot: IRobot {
		//s = { ball-pos: (x, y), player-pos: (x, y) }
		public ActionBlock Update(State s) {
			double bY = (double) (((ArrayList) s["ball-pos"])[1]);
			double pY = (double) (((ArrayList) s["player-pos"])[1]);

			return new ActionBlock("move", new List<object> { bY - pY });
		}
	}
}

