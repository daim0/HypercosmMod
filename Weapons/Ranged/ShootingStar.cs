using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using System.Diagnostics;
using System;

namespace HypercosmMod.Items.Weapons.Ranged
{
    public class ShootingStar : ModItem
    {
        public override void SetStaticDefaults()
        {
	   DisplayName.SetDefault("Shooting Star");
	    Tooltip.SetDefault("Turns Wooden Arrows into jester's arrows");
	}
        public override void SetDefaults()
        {
            item.value = Item.buyPrice(gold: 2);
            item.damage = 31;
            item.noMelee = true;
            item.ranged = true;
            item.width = 69;
            item.height = 40;
            item.useTime = 21;
            item.useAnimation = 21;
            item.useStyle = 5;
            item.knockBack = 1;
            item.value = 1000;
            item.rare = 3;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
            item.shootSpeed = 15f;
            item.shoot = 1;
            item.useAmmo = AmmoID.Arrow;
            item.shootSpeed = 10f;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.WoodenArrowFriendly) 
                        {
                        type = ProjectileID.JestersArrow;

			}

			 
        
		
            int numberOfProjectiles = Main.rand.Next(1, 4); 
            for(int i =0; i < numberOfProjectiles; i++)
            {
                Projectile.NewProjectile(position, new Vector2(speedX, speedY).RotatedByRandom((float)Math.PI/16f), type, damage, knockBack, player.whoAmI);
            }
            return false;
        
        }

		
                        
        public override Vector2? HoldoutOffset()

		{

			return new Vector2(0, 0);

	   }
        }
    }