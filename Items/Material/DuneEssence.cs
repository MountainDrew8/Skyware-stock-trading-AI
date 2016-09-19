﻿using System;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;

namespace SpiritMod.Items.Material
{
    public class DuneEssence : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Dune Essence";
            item.width = item.height = 16;
            item.toolTip = "The Essence of those preserved and revived";
            item.rare = 8;
            item.maxStack = 999;

            ItemID.Sets.ItemNoGravity[item.type] = true;
            ItemID.Sets.AnimatesAsSoul[item.type] = true;
        }

        public override DrawAnimation GetAnimation()
        {
            return new DrawAnimationVertical(5, 4);
        }
    }
}