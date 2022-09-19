using Terraria;
using Terraria.ModLoader;
using Terraria.Audio;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.GameContent.ItemDropRules;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
//using RuinMod.Content.Classes.ChainClass;
using System.Collections.Generic;
using Terraria.DataStructures;
using Terraria.GameContent.Bestiary;
using RuinMod.Common.Systems;
using RuinMod.Assets.Textures.BossBars;
using System.Diagnostics;
using RuinMod.Assets.Music;
using RuinMod.Content.Armor.GamerClassArmor.Hardmode.KratosArmor;
using RuinMod.Content.Armor.GamerClassArmor.Hardmode.SansArmor;

namespace RuinMod.Common.Global.GlobalNPCS
{
    internal class GlobalNPCS : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type == NPCID.EyeofCthulhu || npc.type == NPCID.SkeletronHead || npc.type == NPCID.KingSlime || npc.type == NPCID.WallofFlesh|| npc.type == NPCID.Retinazer|| npc.type == NPCID.Spazmatism|| npc.type == NPCID.SkeletronPrime || npc.type == NPCID.TheDestroyer|| npc.type == NPCID.QueenBee||npc.type == NPCID.Plantera|| npc.type == NPCID.BrainofCthulhu|| npc.type == NPCID.DukeFishron|| npc.type == NPCID.MartianSaucer|| npc.type == NPCID.CultistBoss|| npc.type == NPCID.HallowBoss|| npc.type == NPCID.QueenSlimeBoss|| npc.type == NPCID.Deerclops|| npc.type == NPCID.EaterofWorldsHead||npc.type == ModContent.NPCType<Content.NPCS.Bosses.MechBrain.MechBrain>())
            {
                npc.BossBar = ModContent.GetInstance<Assets.Textures.BossBars.RuinBossBar>();
            }
            else
            {
                npc.BossBar = null;
            }
        }

        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if(npc.type == NPCID.ArmsDealer)
            {
                npcLoot.Add(ItemDropRule.Common(ItemID.Minishark, 8,1,1));
            }
            if (npc.type == NPCID.Nurse)
            {
                npcLoot.Add(ItemDropRule.Common(ItemID.GreaterHealingPotion, 8, 1, 3));
            }
            if (npc.type == NPCID.Demolitionist)
            {
                npcLoot.Add(ItemDropRule.Common(ItemID.Dynamite, 8, 1, 10));
            }
            if (npc.type == NPCID.GoblinTinkerer)
            {
                npcLoot.Add(ItemDropRule.Common(ItemID.Ruler, 8, 1, 1));
            }
            if (npc.type == NPCID.Dryad)
            {
                npcLoot.Add(ItemDropRule.Common(ItemID.Sunflower, 8, 1, 1));
            }
            if (npc.type == NPCID.Merchant)
            {
                npcLoot.Add(ItemDropRule.Common(ItemID.BugNet, 8, 1, 1));
            }
            if (npc.type == NPCID.Wizard)
            {
                npcLoot.Add(ItemDropRule.Common(ItemID.CrystalBall, 8, 1, 1));
            }
            if (npc.type == NPCID.OldMan)
            {
                npcLoot.Add(ItemDropRule.Common(ItemID.ClothierVoodooDoll, 8, 1, 1));
            }
            if (npc.type == NPCID.BigMimicHallow || npc.type == NPCID.BigMimicCorruption|| npc.type == NPCID.BigMimicCrimson|| npc.type == NPCID.BigMimicJungle)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Content.Items.DarkEssence.DarkEssence>(), 1, 1, 10));
            }
            if (npc.type == NPCID.SkeletronPrime)
            {
                LeadingConditionRule notExpertRule = new LeadingConditionRule(new Conditions.NotExpert());

                notExpertRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<Content.Weapons.RangeWeapons.Hardmode.PrimalSkullForce.PrimalSkullForce>(), 4, 1, 1));
                notExpertRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<Content.Items.Ammo.MiniSkull.MiniSkull>(), 1, 125, 150));
                notExpertRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<Content.Armor.Hardmode.TitanArmor.TitanHelmet>(), 7, 1, 1));
                notExpertRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<Content.Armor.Hardmode.TitanArmor.TitanMail>(), 7, 1, 1));
                notExpertRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<Content.Armor.Hardmode.TitanArmor.TitanLeggings>(), 7, 1, 1));
                npcLoot.Add(notExpertRule);
            }
            if (npc.type == NPCID.Retinazer || npc.type == NPCID.Spazmatism)
            {
                LeadingConditionRule notExpertRule = new LeadingConditionRule(new Conditions.NotExpert());

                notExpertRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<Content.Weapons.MagicWeapons.Hardmode.BookOfBreath.BookOfBreath>(), 4, 1, 1));
                notExpertRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<Content.Armor.Hardmode.SpectralArmor.SpectralHeadgear>(), 7, 1, 1));
                notExpertRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<Content.Armor.Hardmode.SpectralArmor.SpectralArmor>(), 7, 1, 1));
                notExpertRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<Content.Armor.Hardmode.SpectralArmor.SpectralSubligar>(), 7, 1, 1));
                npcLoot.Add(notExpertRule);
            }
            if (npc.type == NPCID.TheDestroyer)
            {
                LeadingConditionRule notExpertRule = new LeadingConditionRule(new Conditions.NotExpert());

                notExpertRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<Content.Weapons.SummonerWeapons.Hardmode.ProbeWhip.ProbeWhip>(), 4, 1, 1));
                notExpertRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<Content.Armor.Hardmode.EdgeArmor.EdgeHelmet>(), 7, 1, 1));
                notExpertRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<Content.Armor.Hardmode.EdgeArmor.EdgeChestplate>(), 7, 1, 1));
                notExpertRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<Content.Armor.Hardmode.EdgeArmor.EdgeLeggings>(), 7, 1, 1));
                npcLoot.Add(notExpertRule);
            }
            if (npc.type == NPCID.Golem)
            {
                LeadingConditionRule notExpertRule = new LeadingConditionRule(new Conditions.NotExpert());

                notExpertRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<Content.Armor.Hardmode.DragonArmor.DragonHelmet>(), 7, 1, 1));
                notExpertRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<Content.Armor.Hardmode.DragonArmor.DragonChestplate>(), 7, 1, 1));
                notExpertRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<Content.Armor.Hardmode.DragonArmor.DragonLeggings>(), 7, 1, 1));
                npcLoot.Add(notExpertRule);
            }
            if (npc.type == NPCID.DukeFishron)
            {
                LeadingConditionRule notExpertRule = new LeadingConditionRule(new Conditions.NotExpert());

                notExpertRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<Content.Weapons.RangeWeapons.Hardmode.Dukezooka.Dukezooka>(), 4, 1, 1));
                npcLoot.Add(notExpertRule);
            }
            if (npc.type == NPCID.CultistBoss)
            {
                LeadingConditionRule notExpertRule = new LeadingConditionRule(new Conditions.NotExpert());

                notExpertRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<Content.Armor.Accesories.Hardmode.OrbOfPain.OrbOfPain>(), 4, 1, 1));

                notExpertRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<SansHead>(), 7, 1, 1));
                notExpertRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<SansBody>(), 7, 1, 1));
                notExpertRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<SansLegs>(), 7, 1, 1));
                npcLoot.Add(notExpertRule);

                npcLoot.Add(ItemDropRule.BossBag(ItemID.CultistBossBag));

            }

            if (npc.type == NPCID.WallofFlesh)
            {
                LeadingConditionRule notExpertRule = new LeadingConditionRule(new Conditions.NotExpert());

                notExpertRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<Content.Armor.Accesories.GamerClassAccesories.Hardmode.GamingEmblem.GamingEmblem>(), 4, 1, 1));
                npcLoot.Add(notExpertRule);

            }
            if (npc.type == NPCID.MoonLordCore)
            {
                LeadingConditionRule notExpertRule = new LeadingConditionRule(new Conditions.NotExpert());

                notExpertRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<Content.Weapons.GamerClassWeapons.Hardmode.DirtyBrotherKiller.DirtyBrotherKiller>(), 9, 1, 1));
                notExpertRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<Content.Weapons.GamerClassWeapons.Hardmode.BarkBarkChain.BarkBarkChain>(), 9, 1, 1));
                notExpertRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<KratosHead>(), 11,1,1));
                notExpertRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<KratosBody>(), 11,1,1));
                notExpertRule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<KratosLegs>(), 11,1,1));
                npcLoot.Add(notExpertRule);

            }
            /*if (npc.type == NPCID.LunarTowerSolar)
            {
                LeadingConditionRule notExpertRule = new LeadingConditionRule(new Conditions.NotExpert());
                int itemType = ModContent.ItemType<Content.Items.FragmentOfCosmos.FragmentOfCosmos>();
                var parameters = new DropOneByOne.Parameters()
                {
                    ChanceNumerator = 1,
                    ChanceDenominator = 1,
                    MinimumStackPerChunkBase = 1,
                    MaximumStackPerChunkBase = 1,
                    MinimumItemDropsCount = 12,
                    MaximumItemDropsCount = 15,
                };

                notExpertRule.OnSuccess(new DropOneByOne(itemType, parameters));
                
                npcLoot.Add(notExpertRule);
            }
            if (npc.type == NPCID.LunarTowerNebula)
            {
                LeadingConditionRule notExpertRule = new LeadingConditionRule(new Conditions.NotExpert());
                int itemType = ModContent.ItemType<Content.Items.FragmentOfCosmos.FragmentOfCosmos>();
                var parameters = new DropOneByOne.Parameters()
                {
                    ChanceNumerator = 1,
                    ChanceDenominator = 1,
                    MinimumStackPerChunkBase = 1,
                    MaximumStackPerChunkBase = 1,
                    MinimumItemDropsCount = 12,
                    MaximumItemDropsCount = 15,
                };

                notExpertRule.OnSuccess(new DropOneByOne(itemType, parameters));

                npcLoot.Add(notExpertRule);
            }
            if (npc.type == NPCID.LunarTowerStardust)
            {
                LeadingConditionRule notExpertRule = new LeadingConditionRule(new Conditions.NotExpert());
                int itemType = ModContent.ItemType<Content.Items.FragmentOfCosmos.FragmentOfCosmos>();
                var parameters = new DropOneByOne.Parameters()
                {
                    ChanceNumerator = 1,
                    ChanceDenominator = 1,
                    MinimumStackPerChunkBase = 1,
                    MaximumStackPerChunkBase = 1,
                    MinimumItemDropsCount = 12,
                    MaximumItemDropsCount = 15,
                };

                notExpertRule.OnSuccess(new DropOneByOne(itemType, parameters));

                npcLoot.Add(notExpertRule);
            }
            if (npc.type == NPCID.LunarTowerVortex)
            {
                LeadingConditionRule notExpertRule = new LeadingConditionRule(new Conditions.NotExpert());
                int itemType = ModContent.ItemType<Content.Items.FragmentOfCosmos.FragmentOfCosmos>();
                var parameters = new DropOneByOne.Parameters()
                {
                    ChanceNumerator = 1,
                    ChanceDenominator = 1,
                    MinimumStackPerChunkBase = 1,
                    MaximumStackPerChunkBase = 1,
                    MinimumItemDropsCount = 12,
                    MaximumItemDropsCount = 15,
                };

                notExpertRule.OnSuccess(new DropOneByOne(itemType, parameters));

                npcLoot.Add(notExpertRule);
            }*/
        }
    }
}
