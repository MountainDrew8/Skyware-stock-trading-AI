﻿using System;
using System.Collections.Generic;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpiritMod.Items.Armor.LeatherArmor
{
    public class LeatherBoots : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Leather Boots";
            item.width = 22;
            item.height = 18;
            item.toolTip = "Increases ranged damage by 4% and increases movement speed by 5%";
            item.value = 100;
            item.rare = 1;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.05F;
            player.rangedDamage += 0.04F;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "OldLeather", 4);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
