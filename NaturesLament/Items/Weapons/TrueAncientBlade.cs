using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NaturesLament.Items.Weapons
{
	public class TrueAncientBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Ancient Blade");
			Tooltip.SetDefault("Time heals all wounds, and also causes them");
		}
		public override void SetDefaults()
		{
			item.damage = 1000;
			item.melee = true;
			item.width = 26;
			item.height = 26;
			item.scale = 4;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 1;
			item.knockBack = 11;
			item.value = 1000000;
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
			item.shoot = mod.ProjectileType("TrueAncientBeam");
			item.shootSpeed = 16f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "AncientBlade", 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			// Add Onfire buff to the NPC for 1 second
			// 60 frames = 1 second
			target.AddBuff(BuffID.Ichor, 180);
		}
	}
}
