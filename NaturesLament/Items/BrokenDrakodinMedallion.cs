using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NaturesLament.Items
{
    public class BrokenDrakodinMedallion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Broken Drakodin Medallion");
            Tooltip.SetDefault("It is broken as is he");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.maxStack = 1;
            item.value = 0;
            item.rare = 12;
            // Set other item.X values here
        }
    }
}