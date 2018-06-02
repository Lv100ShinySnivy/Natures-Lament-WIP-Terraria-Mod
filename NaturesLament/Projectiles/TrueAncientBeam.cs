using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NaturesLament.Projectiles
{
    public class TrueAncientBeam : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("True Ancient Beam");
        }

        public override void SetDefaults()
        {
            projectile.width = 16;
            projectile.height = 16;
            projectile.aiStyle = 0;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.scale = 2f;
            projectile.timeLeft = 60;
            projectile.penetrate = 2;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
        }

        public override void AI()
       	{
            Player owner = Main.player[projectile.owner]; //Makes a player variable of owner set as the player using the projectile
            projectile.light = 0.9f; //Lights up the whole room
            projectile.alpha = 128; //Semi Transparent
            projectile.rotation += (float)projectile.direction * 0.2f; //Spins in a good speed
            int DustID = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y + 2f), projectile.width + 4, projectile.height + 4, 36, projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 120, default(Color), 0.75f); //Spawns dust
            Main.dust[DustID].noGravity = true; //Makes dust not fall
        }


        public override void OnHitNPC(NPC n, int damage, float knockback, bool crit)
        {
            n.AddBuff(BuffID.Slow, 180);
        }
    }
}