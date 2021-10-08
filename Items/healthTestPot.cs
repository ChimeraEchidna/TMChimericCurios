using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.IO;
using Terraria.ModLoader;

namespace ChimericCurios.Items
{
    class healthTestPot : ModItem
    {
        public override void SetDefaults()
        {
            //Tooltip.SetDefault("This will heal 50% of your total health");
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useTime = 1;
            item.useAnimation = 2;
            item.maxStack = 1;
            item.consumable = false;
            item.rare = ItemRarityID.Quest;
            item.useTurn = true;
            //item.potion = true;
            //item.healLife = -100;
            //item.buffType = ModContent.BuffType<slowdebuff>();
            //item.buffType = BuffID.Slow;
            //item.buffTime = 200;
        }
        public override bool CanUseItem(Player player)
        {
            return true;
        }

        public override bool UseItem(Player player)
        {

            int test = player.statLifeMax2;
            //item.healLife = (test / 2);
            //item.
            player.statLife -= (test - 200);
            return true;
        }



        public override void AddRecipes()
        {
            base.AddRecipes();
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(ItemID.DirtBlock, 01);
            r.AddTile(TileID.WorkBenches);
            r.SetResult(this);
            //r.AddRecipe();

        }

    }
}
