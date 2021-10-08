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
    class CharmOfSentries : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();

            //Name
            String name_of_item = "Charm of the Sentries";
            DisplayName.SetDefault(name_of_item);

            //Tool Tip
            String item_tool_tip = "Converts max minions into max turrets";
            Tooltip.SetDefault(item_tool_tip);
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            //remember to cut fluff

            item.maxStack = 1;
            item.consumable = false;
            item.accessory = true;


            item.rare = ItemRarityID.Blue;

        }   

        public override bool CanUseItem(Player player){return false;}

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            base.UpdateAccessory(player, hideVisual);
            int minMax = player.maxMinions;
            player.maxMinions = 1;
            player.maxTurrets += minMax;

            //player.ownedProjectileCounts[ModContent.ProjectileType<>()]

            //player.ownedProjectileCounts[Main.pr]

        }


        public override void AddRecipes()
        {
            base.AddRecipes();
            ModRecipe r = new ModRecipe(mod);

            //ingredients
            r.AddIngredient(ItemID.DirtBlock, 01);

            //tiles
            r.AddTile(TileID.WorkBenches);

            r.SetResult(this);
            //r.AddRecipe();

            /////////////////////////////////////////////////////////////////////////////////////
            r = new ModRecipe(mod);

            //ingredients
            r.AddIngredient(ItemID.DirtBlock, 01);

            //tiles
            r.AddTile(TileID.WorkBenches);

            r.SetResult(ItemID.QueenSpiderStaff);
           // r.AddRecipe();

            r = new ModRecipe(mod);

            //ingredients
            r.AddIngredient(ItemID.DirtBlock, 01);

            //tiles
            r.AddTile(TileID.WorkBenches);

            r.SetResult(ItemID.ManaCrystal);
           // r.AddRecipe();


            r = new ModRecipe(mod);

            //ingredients
            r.AddIngredient(ItemID.DirtBlock, 01);

            //tiles
            r.AddTile(TileID.WorkBenches);

            r.SetResult(ItemID.BeeBreastplate);
           // r.AddRecipe();
            r = new ModRecipe(mod);

            //ingredients
            r.AddIngredient(ItemID.DirtBlock, 01);

            //tiles
            r.AddTile(TileID.WorkBenches);

            r.SetResult(ItemID.BeeHeadgear);
           // r.AddRecipe();
            r = new ModRecipe(mod);

            //ingredients
            r.AddIngredient(ItemID.DirtBlock, 01);

            //tiles
            r.AddTile(TileID.WorkBenches);

            r.SetResult(ItemID.BeeGreaves);
           // r.AddRecipe();
        }




    }
}
