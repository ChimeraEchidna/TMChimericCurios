using Terraria;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.IO;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace ChimericCurios
{
	public class ChimericCurios : Mod
	{

        public override void AddRecipeGroups()
        {
            base.AddRecipeGroups();
            RecipeGroup HM_Mob_Drop_Mats = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "Cursed Flames/Ichor/Pixie Dust ", new int[]
            {
                ItemID.PixieDust,
                ItemID.Ichor,
                ItemID.CursedFlame
            });
            RecipeGroup.RegisterGroup("CC:CF/I/P", HM_Mob_Drop_Mats);




        }
    }
}