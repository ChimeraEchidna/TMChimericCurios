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
    class EstusFlask: ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("It tastes a little like old Sunny D with a hint of Fireball");
            DisplayName.SetDefault(" Estus Flask");
        }
        public override void SetDefaults()
        {
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useTime = 250;
            item.useAnimation = 250;
            item.maxStack = 1;
            item.consumable = false;
            item.rare = ItemRarityID.Quest;
            item.UseSound = SoundID.Item3;
            item.useTurn = true;
            item.buffType = ModContent.BuffType<slowdebuff>();
            item.buffTime = 200;
            item.scale = .7f;
            
        }
        public override bool CanUseItem(Player player)
        {
            return true;
        }

        public override bool UseItem(Player player)
        {
            //var dust = Dust.NewDust(player.position, player.width, player.height, 79, 1f, 1f);
            //Main.dust[dust].velocity *= 2f;


            return true;
        }



        public override void AddRecipes()
        {
            base.AddRecipes();
            ModRecipe r = new ModRecipe(mod);
            //r.AddIngredient(ItemID.DirtBlock, 01);

            r.AddIngredient(ItemID.Bottle, 01);
            r.AddIngredient(ItemID.LunarBar, 03);
            r.AddIngredient(ItemID.GreaterHealingPotion, 10);
            r.AddIngredient(ItemID.LivingFireBlock, 05);

            r.AddTile(TileID.WorkBenches);
            r.SetResult(this);
            r.AddRecipe();
            
        }

    }
}
