using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.IO;
using Terraria.ModLoader;
using ChimericCurios.Buffs;

namespace ChimericCurios.Items
{
    class warpPendant : ModItem
    {

        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            //Name
            String name_of_item = "warp Pendant";
            DisplayName.SetDefault(name_of_item);

            //Tool Tip
            String item_tool_tip = "With this in hand you can freely teleport across this plane \n Open your map and <right> to teleport. \n Remember to thank your local alchemist.";
            Tooltip.SetDefault(item_tool_tip);
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            //remember to cut fluff
            item.UseSound = SoundID.Item6; //https://forums.terraria.org/index.php?threads/dust-and-sound-catalogue-2.42370/
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useTurn = true;
            item.scale = 1.2f;

            item.maxStack = 1;
            item.consumable = false;

            item.rare = ItemRarityID.Quest;

            //item.type = ItemID.WormholePotion;

        }
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }
        public override bool CanUseItem(Player player)
        {
            return false;
        }

        public override bool UseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {// player.Spawn();
            }
            else
            {
                //Main.mapFullscreen = true;
            }
            return true;
        }


        public override void UpdateInventory(Player player)
        {
           // ((CCPlayer)player.GetModPlayer(mod, "CCPlayer")).hasWarpPendant = true;
        }


        public override void AddRecipes()
        {
            base.AddRecipes();
            ModRecipe r = new ModRecipe(mod);

            //ingredients
            r.AddIngredient(ItemID.MagicMirror, 01);
            r.AddIngredient(ItemID.WormholePotion, 05);
            r.AddIngredient(ItemID.TeleportationPotion, 05);
            //tiles
            r.AddTile(TileID.WorkBenches);

            r.SetResult(this);
            //r.AddRecipe();


             r = new ModRecipe(mod);

            //ingredients
            r.AddIngredient(ItemID.DirtBlock, 01);
            //tiles
            r.AddTile(TileID.WorkBenches);

            r.SetResult(this);
            //r.AddRecipe();
        }


    }
}
