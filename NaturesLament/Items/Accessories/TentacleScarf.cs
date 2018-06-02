using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NaturesLament.Items.Accessories
{
    [AutoloadEquip(EquipType.Neck)]
    public class TentacleScarf : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tentacle Scarf");
            Tooltip.SetDefault("10% Increased critical strike chance"
                + "\n12% Reduced damage taken"
                + "\n15% Increased life regen"
                + "\n50% Increased breathing capacity"
                + "\nSuprisingly comfy");
        }

        public override void SetDefaults()
        {
            item.width = 15;
            item.height = 15;
            item.maxStack = 1;
            item.value = 500000;
            item.rare = 12;
            item.accessory = true;
            item.expert = true;
            // Set other item.X values here
        }

        public override void UpdateAccessory(Player p, bool hideVisual)
        {
            p.breathMax = 300;
            p.lifeRegenTime = p.lifeRegenTime * (100 / 85);
            p.thrownCrit += 10;
            p.meleeCrit += 10;
			p.thrownCrit += 10;
			p.rangedCrit += 10;
			p.magicCrit += 10;
            p.endurance += 0.12f;
        }
    }
}
