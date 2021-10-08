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
    class blankWormHoleBuff: ModBuff
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            DisplayName.SetDefault("Wormhole Scroll");
            Description.SetDefault("One use teleports you to someone random on your team.");
            
        }
        public override void Update(Player player, ref int buffIndex)
        {

        }
    }
}
