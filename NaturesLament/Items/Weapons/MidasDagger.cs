using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NaturesLament.Items.Weapons
{
	public class MidasDagger : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Midas Dagger");
			Tooltip.SetDefault("Essential for any aspiring leprechaun");
		}
		public override void SetDefaults()
		{
			item.damage = 60;
			item.melee = true;
			item.width = 26;
			item.height = 26;
			item.scale = 1;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.knockBack = 3;
			item.value = 100000;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			// Add Onfire buff to the NPC for 1 second
			// 60 frames = 1 second
			target.AddBuff(BuffID.Midas, 300);
			player.AddBuff(BuffID.Swiftness, 300);
		}
	}
}
