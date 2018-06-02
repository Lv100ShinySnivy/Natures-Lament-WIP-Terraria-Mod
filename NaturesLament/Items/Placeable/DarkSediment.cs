using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NaturesLament.Items.Placeable
{
    public class DarkSediment : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dark Sediment");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            item.value = 10;
            item.useStyle = 1;
            item.useTime = 10;
            item.useAnimation = 15;
            item.autoReuse = true;
            item.rare = 0;
            item.UseSound = SoundID.Item1;
            item.consumable = true;
            item.createTile = mod.TileType("DarkSedimentTile");
            // Set other item.X values here
        }
    }
}