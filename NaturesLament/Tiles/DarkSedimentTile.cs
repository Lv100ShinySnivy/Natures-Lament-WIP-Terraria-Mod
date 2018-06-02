using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NaturesLament.Tiles
{
    public class DarkSedimentTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileNoAttach[Type] = false;
            drop = mod.ItemType("DarkSediment");
            AddMapEntry(new Color(31, 43, 81));
            minPick = 100;
        }
    }
}