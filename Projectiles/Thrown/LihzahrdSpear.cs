using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace SpiritMod.Projectiles.Thrown
{
    public class LihzahrdSpear : ModProjectile
    {
        private int Counter = 0;
        public override void SetDefaults()
        {
            projectile.name = "Lihzahrd Spear";
            projectile.width = 18;
            projectile.height = 18;
            projectile.aiStyle = 113;
            projectile.friendly = true;
            projectile.thrown = true;
            projectile.penetrate = 4;
            projectile.timeLeft = 600;
            projectile.alpha = 255;
            projectile.extraUpdates = 1;
            projectile.light = 0;
            ProjectileID.Sets.TrailCacheLength[projectile.type] = 9;
            ProjectileID.Sets.TrailingMode[projectile.type] = 0;
            aiType = ProjectileID.ThrowingKnife;
        }
        public override void Kill(int timeLeft)
        {
            Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 14);
            projectile.position.X = projectile.position.X + (float)(projectile.width / 2);
            projectile.position.Y = projectile.position.Y + (float)(projectile.height / 2);
            projectile.width = 50;
            projectile.height = 50;
            projectile.position.X = projectile.position.X - (float)(projectile.width / 2);
            projectile.position.Y = projectile.position.Y - (float)(projectile.height / 2);
            for (int num621 = 0; num621 < 20; num621++)
            {
                int num622 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 244, 0f, 0f, 100, default(Color), 2f);
                Main.dust[num622].velocity *= 3f;
                if (Main.rand.Next(2) == 0)
                {
                    Main.dust[num622].scale = 0.5f;
                    Main.dust[num622].fadeIn = 1f + (float)Main.rand.Next(10) * 0.1f;
                }
            }
            for (int num623 = 0; num623 < 35; num623++)
            {
                int num624 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 244, 0f, 0f, 100, default(Color), 3f);
                Main.dust[num624].noGravity = true;
                Main.dust[num624].velocity *= 5f;
                num624 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 244, 0f, 0f, 100, default(Color), 2f);
                Main.dust[num624].velocity *= 2f;
            }
            for (int num625 = 0; num625 < 3; num625++)
            {
                float scaleFactor10 = 0.33f;
                if (num625 == 1)
                {
                    scaleFactor10 = 0.66f;
                }
                if (num625 == 2)
                {
                    scaleFactor10 = 1f;
                }
                int num626 = Gore.NewGore(new Vector2(projectile.position.X + (float)(projectile.width / 2) - 24f, projectile.position.Y + (float)(projectile.height / 2) - 24f), default(Vector2), Main.rand.Next(61, 64), 1f);
                Main.gore[num626].velocity *= scaleFactor10;
                Gore expr_13AB6_cp_0 = Main.gore[num626];
                expr_13AB6_cp_0.velocity.X = expr_13AB6_cp_0.velocity.X + 1f;
                Gore expr_13AD6_cp_0 = Main.gore[num626];
                expr_13AD6_cp_0.velocity.Y = expr_13AD6_cp_0.velocity.Y + 1f;
                num626 = Gore.NewGore(new Vector2(projectile.position.X + (float)(projectile.width / 2) - 24f, projectile.position.Y + (float)(projectile.height / 2) - 24f), default(Vector2), Main.rand.Next(61, 64), 1f);
                Main.gore[num626].velocity *= scaleFactor10;
                Gore expr_13B79_cp_0 = Main.gore[num626];
                expr_13B79_cp_0.velocity.X = expr_13B79_cp_0.velocity.X - 1f;
                Gore expr_13B99_cp_0 = Main.gore[num626];
                expr_13B99_cp_0.velocity.Y = expr_13B99_cp_0.velocity.Y + 1f;
                num626 = Gore.NewGore(new Vector2(projectile.position.X + (float)(projectile.width / 2) - 24f, projectile.position.Y + (float)(projectile.height / 2) - 24f), default(Vector2), Main.rand.Next(61, 64), 1f);
                Main.gore[num626].velocity *= scaleFactor10;
                Gore expr_13C3C_cp_0 = Main.gore[num626];
                expr_13C3C_cp_0.velocity.X = expr_13C3C_cp_0.velocity.X + 1f;
                Gore expr_13C5C_cp_0 = Main.gore[num626];
                expr_13C5C_cp_0.velocity.Y = expr_13C5C_cp_0.velocity.Y - 1f;
                num626 = Gore.NewGore(new Vector2(projectile.position.X + (float)(projectile.width / 2) - 24f, projectile.position.Y + (float)(projectile.height / 2) - 24f), default(Vector2), Main.rand.Next(61, 64), 1f);
                Main.gore[num626].velocity *= scaleFactor10;
                Gore expr_13CFF_cp_0 = Main.gore[num626];
                expr_13CFF_cp_0.velocity.X = expr_13CFF_cp_0.velocity.X - 1f;
                Gore expr_13D1F_cp_0 = Main.gore[num626];
                expr_13D1F_cp_0.velocity.Y = expr_13D1F_cp_0.velocity.Y - 1f;
            }
            projectile.position.X = projectile.position.X + (float)(projectile.width / 2);
            projectile.position.Y = projectile.position.Y + (float)(projectile.height / 2);
            projectile.width = 10;
            projectile.height = 10;
            projectile.position.X = projectile.position.X - (float)(projectile.width / 2);
            projectile.position.Y = projectile.position.Y - (float)(projectile.height / 2);
        }

      /*  public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
        {
            ProjectileExtras.DrawAroundOrigin(projectile.whoAmI, lightColor);
            return false;
        }
        */
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 300, true);
        }
    }
}
