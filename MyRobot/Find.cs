using System;
using BitsGalaxy;
using System.Collections.Generic;

using State = System.Collections.Generic.Dictionary<string, object>;
using System.Collections;

namespace MyRobot {
	public class Find: IRobot {
		//s = { player-info: (x, y, r), enemy-pos: (x, y) }
		//p[0] = "action1-action2-action3- ... -actionn", p[1] = {pA1, pA2, pA3 ... pAn}
		public ActionBlock Update(State s) {
			var ps = new List<object> { null };

			var distance = Distance((ArrayList) s["player-info"],
				(ArrayList) s["enemy-pos"]);

			if (distance == 15)
				ps.Add(0.0);
			else if (distance > 15)
				ps.Add(100.0);
			else
				ps.Add(-100.0);

			ps.Add(20.0 / 3.0 * distance);

			return new ActionBlock("DoAction", new List<object> { "look_to_enemy-move-fire", ps });
		}

		double Distance(ArrayList player_info, ArrayList enemy_pos) {
			double pX = (double) player_info[0], pY = (double) player_info[1],
				eX = (double) enemy_pos[0], eY = (double) enemy_pos[1];

			return Math.Sqrt(Math.Pow(pX - eX, 2) + Math.Pow(pY - eY, 2));
		}
	}
}
