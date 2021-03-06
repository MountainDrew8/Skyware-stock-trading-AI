using System;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using SpiritMod.NPCs;

namespace SpiritMod.Buffs
{
    public class Shadowflame : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffName[this.Type] = "Shadowflame";
            Main.buffTip[Type] = "The Umbra burns.";

            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoTimeDisplay[Type] = false;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.lifeRegen -= 14;
            if (Main.rand.Next(2) == 1)
            {
                Dust.NewDust(player.position, player.width, player.height, 173);
            }
        }
    }
}
