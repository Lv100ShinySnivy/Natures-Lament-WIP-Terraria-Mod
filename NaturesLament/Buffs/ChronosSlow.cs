using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NaturesLament.Buffs
{
    public class ChronosSlow : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chronos Slow");
            Tooltip.SetDefault("Time seems to speed up around you");
        }

        public override void SetDefaults()
        {
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            this.canBeCleared = false;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
		{
			player.GetModPlayer<NLPlayer>(mod).ChronosSlow = true;
		}

		public override void Update(NPC npc, ref int buffIndex)
		{
			npc.GetGlobalNPC<NPCsGLOBAL>(mod).ChronosSlow = true;
		}
    }
}