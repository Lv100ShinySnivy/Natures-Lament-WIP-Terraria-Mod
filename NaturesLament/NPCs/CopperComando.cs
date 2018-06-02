using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NaturesLament.NPCs
{
    public class CopperCommando : ModNPC
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Copper Commando");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
		}

        public override void SetDefaults()
        {
            npc.height = 480;
            npc.width = 18;
            npc.damage = 70;
            npc.defense = 60;
            npc.lifeMax = 2000;
            npc.soundHit = 21;
            npc.soundKilled = SoundID.CreateTrackable("dd2_explosive_trap_explode", 3, SoundType.Sound);
            npc.value = 10f;
            npc.knockBackResist = 1f;
            npc.aiStyle = 3;

        }

        public override void SelectFrame(int frameSize);
        {
            
        }
    }
}