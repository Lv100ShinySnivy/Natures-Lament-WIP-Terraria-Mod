using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NaturesLament
{
    public class NLPlayer : ModPlayer
    {
        public bool ChronosSlow = false;

        public override void ResetEffects()
        {
            ChronosSlow = false;
        }

        
    }
}