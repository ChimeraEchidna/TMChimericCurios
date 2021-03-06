using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
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
            //for (int i = 0; i < 5; i++) {
            int res = Main.rand.Next(3);
            Vector2 basePose = new Vector2();
            basePose.X = player.position.X;
            basePose.Y = player.position.Y -2;
            switch (res)
            {
                case 0:
                    Dust.NewDust(basePose, player.width, player.height, DustID.Firework_Red, 0f, -4f);
                    break;
                case 1:
                    Dust.NewDust(basePose, player.width, player.height, DustID.Ash, 0f, -4f);
                    break;
                case 2:
                    Dust.NewDust(basePose, player.width, player.height,DustID.FlameBurst, 0f, -4f);
                    break;
                default: break;
            }

        }
        


    }
}
