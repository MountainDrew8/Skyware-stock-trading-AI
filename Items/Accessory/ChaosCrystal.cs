using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;

namespace SpiritMod.Items.Accessory
{
	public class ChaosCrystal : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Chaos Crystal";
			item.width = 18;
            item.height = 18;
			item.toolTip = "Getting hit has a chance to teleport you to somewhere nearby";
			item.value = Item.buyPrice(0, 5, 0, 0);
            item.rare = 4;
			item.accessory = true;
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
		{
            player.GetModPlayer<MyPlayer>(mod).ChaosCrystal = true;
        }

	}
}
