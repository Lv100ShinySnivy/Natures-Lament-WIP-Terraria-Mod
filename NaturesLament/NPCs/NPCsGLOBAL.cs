using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NaturesLament.NPCs
{
    public class NPCsGLOBAL : GlobalNPC
    {
        public bool ChronosSlow = false;

        public override void ResetEffects(NPC npc)
        {
            ChronosSlow = false;
        }

        public override void DrawEffects(NPC npc, ref Color drawColor)
		{
			if (ChronosSlow)
			{

            }
        }
    }
}