using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

using Terraria;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.IO;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace ChimericCurios
{
	class CCPlayer : ModPlayer
	{
		public bool hasWarpPendant = false;
		public int warpPendantCD = 0; //what the cool down is currently at
		public int warpPendantCDT = 1200; //What the cool down will be set to on use

		public bool warpScroll = false;
		//public Player[] potentialTeleportTargets;
		public List<Player> potentialTeleportTargets = new List<Player>();
		public Random rand = new Random();

		public override void ProcessTriggers(TriggersSet triggersSet)
		{
			base.ProcessTriggers(triggersSet);

			//if(Main.mapFullscreen  && Main.)
			if (warpScroll) { thisIsAFunction(); }

		}
        public override void ResetEffects()
        {
            base.ResetEffects();
			hasWarpPendant = false;
			warpScroll = false;
        }
		public override void PostUpdate()
		{
			base.PostUpdate();
			warpPendantCD -= 1;
			//warpScroll = false;
		}

		public void thisIsAFunction()
		{
			//mod.Logger.Info("Function Called");
			//potentialTeleportTargets = empty;
			potentialTeleportTargets.Clear();
			List<PlayerFileData> allPlayersList = Main.PlayerList;
			int lengthOfPlayerList = allPlayersList.Count();
			for (int i = 0; i < lengthOfPlayerList; i++)
			{
				
				if (Main.player[Main.myPlayer].team > 0 &&
					Main.player[Main.myPlayer].team == Main.player[i].team &&
					Main.player[Main.myPlayer]		!= Main.player[i])
				{

					potentialTeleportTargets.Add(Main.player[i]);
					
				}
			}
			int thisone = 0;
			int limit = potentialTeleportTargets.Count();
			if (limit > 0) {
				thisone = rand.Next(limit);

				player.UnityTeleport(potentialTeleportTargets[thisone].position);
			}
			warpScroll = false;
		
        }

	}
}
