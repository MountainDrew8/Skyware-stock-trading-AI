using Terraria;
using System;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpiritMod.Items.Weapon.Magic
{
	public class MythrilStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Mythril Staff";
			item.damage = 44;
			item.magic = true;
            item.toolTip = "Shoots a splitting Mythril Bolt";
			item.mana = 10;
			item.width = 40;
			item.height = 40;
			item.useTime = 27;
			item.useAnimation = 27;
			item.useStyle = 5;
			Item.staff[item.type] = true;
			item.noMelee = true; 
			item.knockBack = 5;
            item.useTurn = true;
            item.value = Terraria.Item.sellPrice(0, 3, 0, 0);
            item.rare = 5;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("MythrilStaffProj");
			item.shootSpeed = 8f;
		}
		
		    public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
    {
        int amountOfProjectiles = 2;
        for (int i = 0; i < amountOfProjectiles; ++i)
        {
            float sX = speedX;
            float sY = speedY;
            sX += (float)Main.rand.Next(-60, 61) * 0.05f;
            sY += (float)Main.rand.Next(-60, 61) * 0.05f;
            Projectile.NewProjectile(position.X, position.Y, sX, sY, type, damage, knockBack, player.whoAmI);
        }
        return false;
    }
		
				        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(382 , 12);
             recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
	}
}
