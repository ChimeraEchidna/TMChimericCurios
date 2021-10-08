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
    class builderToken : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();

            //Name
            String name_of_item = "";
            DisplayName.SetDefault(name_of_item);

            //Tool Tip
            String item_tool_tip = "";
            Tooltip.SetDefault(item_tool_tip);
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            //remember to cut fluff
            item.UseSound = SoundID.Item3; //https://forums.terraria.org/index.php?threads/dust-and-sound-catalogue-2.42370/
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTime = 0;
            item.useAnimation = 0;
            item.useTurn = true;
            item.maxStack = 1;
            item.consumable = false;
            item.rare = ItemRarityID.Red;

            item.accessory = true;



        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            base.UpdateAccessory(player, hideVisual);
            player.pickSpeed -= 10;



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
            r.AddRecipe();
        }




    }
}
