using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using static Terraria.ModLoader.ModContent;
using Terraria.Audio;

namespace RuinMod.Content.Armor.Hardmode.SpectralArmor
{
    [AutoloadEquip(EquipType.Head)]
    internal class SpectralHeadgear : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spectral Headgear");
            Tooltip.SetDefault("Increases maximum mana by 120\r\n15% increased magic damage and critical strike chance");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 3;
        }

        public override void SetDefaults() //Item Stats
        {
            Item.width = 24;
            Item.height = 22;
            Item.value = Item.buyPrice(gold: 34);
            Item.rare = ItemRarityID.Pink;
            Item.defense = 10;
            Item.wornArmor = true;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<SpectralArmor>() && legs.type == ItemType<SpectralSubligar>(); //What makes armor set bonus work
        }

        public override void UpdateArmorSet(Player player) //Armor set bonuses
        {
            player.setBonus = "23% reduced mana usage";
            player.manaCost -= 0.23f;
        }

        public override void UpdateEquip(Player player) //Individual armor piece bonus
        {
            player.GetDamage(DamageClass.Magic) += 0.15f;
            player.GetCritChance(DamageClass.Magic) += 0.15f;
            player.statManaMax2 += 120;
        }
    }
}