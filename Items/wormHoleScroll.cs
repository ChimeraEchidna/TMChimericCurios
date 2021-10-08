using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.IO;
using Terraria.ModLoader;
using Terraria.Localization;
using ChimericCurios.Buffs;

namespace ChimericCurios.Items
{
    class wormHoleScroll : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();

            //Name
            String name_of_item = "Wormhole Scroll";
            DisplayName.SetDefault(name_of_item);

            //Tool Tip
            String item_tool_tip = "Teleports you to one of your allys!";
            Tooltip.SetDefault(item_tool_tip);
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            //remember to cut fluff
            item.UseSound = SoundID.Item123; //https://forums.terraria.org/index.php?threads/dust-and-sound-catalogue-2.42370/
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useTime = 2;
            item.useAnimation = 2;
            item.useTurn = true;

            item.maxStack = 999;
            item.consumable = true;

            item.rare = ItemRarityID.Blue;
            item.buffType = ModContent.BuffType<blankWormHoleBuff>();
            item.buffTime = 3;

        }

        public override bool CanUseItem(Player player) {return true;}

        public override bool UseItem(Player player)
        {
            ((CCPlayer)player.GetModPlayer(mod, "CCPlayer")).warpScroll = true;
            return base.UseItem(player);
        }

        public override void AddRecipes()
        {
            base.AddRecipes();

            ModRecipe r = new ModRecipe(mod);

            // Dev Recipe
            r = new ModRecipe(mod);
            //ingredients
            r.AddIngredient(ItemID.DirtBlock, 01);
            //tiles
            r.AddTile(TileID.WorkBenches);
            r.SetResult(this, 05);
            r.AddRecipe();




            // PH base
            r = new ModRecipe(mod);
            //ingredients
            r.AddIngredient(ItemID.Silk, 01);
            r.AddIngredient(ItemID.FallenStar, 01);
            //tiles
            r.AddTile(TileID.WorkBenches);
            r.SetResult(this, 01);
            r.AddRecipe();


            // H base
            r = new ModRecipe(mod);
            //ingredients
            r.AddIngredient(ItemID.Silk, 01);
            r.AddRecipeGroup("CC:CF/I/P", 01);
            //tiles
            r.AddTile(TileID.WorkBenches);
            r.SetResult(this, 05);
            r.AddRecipe();


            // PH with WormHole
            r = new ModRecipe(mod);
            //ingredients
            r.AddIngredient(ItemID.Silk, 01);
            r.AddIngredient(ItemID.FallenStar, 01);
            r.AddIngredient(ItemID.WormholePotion, 01);
            //tiles
            r.AddTile(TileID.WorkBenches);
            r.SetResult(this, 10);
            r.AddRecipe();


            // H with WormHole
            r = new ModRecipe(mod);
            //ingredients
            r.AddIngredient(ItemID.Silk, 01);
            r.AddRecipeGroup("CC:CF/I/P", 01);
            r.AddIngredient(ItemID.WormholePotion, 01);
            //tiles
            r.AddTile(TileID.WorkBenches);
            r.SetResult(this, 20);
            r.AddRecipe();
        }




    }
}
