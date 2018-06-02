using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NaturesLament.Items
{
    [AutoloadEquip(EquipType.Head)]
    public class SquidMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Squid Mask");
            Tooltip.SetDefault("May or may not be wearing you");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 36;
            item.maxStack = 1;
            item.value = 500000;
            item.rare = 12;
            item.vanity = true;
            item.expert = true;
            // Set other item.X values here
        }

        public override bool DrawHead()
        {
            return true;     //this make so the player head does not disappear when the vanity mask is equipped.  return false if you want to not show the player head.
        }
        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawHair = drawAltHair = false;  //this make so the player hair does not show when the vanity mask is equipped.  add true if you want to show the player hair.
        }
    }
}
