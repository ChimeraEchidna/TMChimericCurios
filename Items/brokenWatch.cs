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
    class brokenWatch : ModItem
    {
        
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();

            //Name
            String name_of_item = "Broken Watch";
            DisplayName.SetDefault(name_of_item);

            //Tool Tip
            String item_tool_tip = "Does funny things when you use it \n Left-Click Adjusts the weather \n <right> Adjusts time ";
            Tooltip.SetDefault(item_tool_tip);
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            //remember to cut fluff
            item.UseSound = SoundID.Item35; //https://forums.terraria.org/index.php?threads/dust-and-sound-catalogue-2.42370/
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useTurn = true;

            item.maxStack = 1;
            item.consumable = false;

            item.rare = ItemRarityID.Quest;
            

        }
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }


        public override bool UseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            { Main.time = 54000; }
            else
            {
                if (Main.raining == true){ Main.raining = false; }
                else { Main.raining = true; }
            }
            return true;
        }


        public override void HoldItem(Player player)
        {
            base.HoldItem(player);
            player.accWatch = 54000;
            player.accWeatherRadio = true;
        }



        public override void AddRecipes()
        {
            base.AddRecipes();
            ModRecipe r = new ModRecipe(mod);

            //ingredients
            r.AddIngredient(ItemID.CopperWatch, 01);
            r.AddIngredient(ItemID.WoodenHammer, 01);
            //tiles
            r.AddTile(TileID.WorkBenches);

            r.SetResult(this);
            r.AddRecipe();

            r = new ModRecipe(mod);
            //ingredients
            r.AddIngredient(ItemID.TinWatch, 01);
            r.AddIngredient(ItemID.WoodenHammer, 01);
            //tiles
            r.AddTile(TileID.WorkBenches);

            r.SetResult(this);
            r.AddRecipe();
        }




    }
}
