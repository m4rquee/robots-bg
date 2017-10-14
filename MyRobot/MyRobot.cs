using System;
using BitsGalaxy;
using System.Collections;
using System.Collections.Generic;

using State = System.Collections.Generic.Dictionary<string, object>;

namespace MyRobot {
	public class MyRobot: IRobot {
		//s = { player-info: (x, y, r), enemy-pos: (x, y) }
		//p[0] = "action1-action2-action3- ... -actionn", p[1] = {pA1, pA2, pA3 ... pAn}
		public ActionBlock Update(State s) {


			return new ActionBlock("DoAction", new List<object> { "move-fire-turn", new List<object> { 100.0, 100.0, 100.0 } });
		}
	}
}

