using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.IO;
using Terraria.ModLoader;
namespace ChimericCurios.Buffs
{
    class slowdebuff: ModBuff
    {

        public override void SetDefaults()
        {
            base.SetDefaults();
            DisplayName.SetDefault("Gift of the flame ");
            Description.SetDefault("You are rapidly regenerating.");
            canBeCleared = false;
            Main.debuff[Type] = true;
        }



        public override void Update(Player player, ref int buffIndex)
        {
            //player.accRunSpeed = 0f;
            //player.runAcceleration -= 0.09f;
            //player.maxRunSpeed = .56f;
            int ammt = player.statLifeMax2 / 8;
            player.lifeRegen += ammt;

             
            
        }
        


    }
}
