using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HarmonyLib;
using TaleWorlds.MountAndBlade;
using TaleWorlds.Core;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Localization;
using TaleWorlds.SaveSystem;
using TaleWorlds.CampaignSystem.SandBox.Source.TournamentGames;
using TaleWorlds.CampaignSystem.Actions;

namespace TournamentWinnings
{
    [HarmonyPatch(typeof(TournamentGame), "GetTournamentPrize")]
    class TournamentGamePatch
    {
        public static bool Prefix(ref ItemObject __result)
        {
            __result = getObject();
            return false; //skip the original function
        }

        private static ItemObject getObject()
        {
            return Game.Current.ObjectManager.GetObject<ItemObject>(((IEnumerable<string>)new string[32]
            {
                /*
                "winds_fury_sword_t3",
                "bone_crusher_mace_t3",
                "tyrhung_sword_t3",
                "pernach_mace_t3",
                "early_retirement_2hsword_t3",
                "black_heart_2haxe_t3",
                "knights_fall_mace_t3",
                "the_scalpel_sword_t3",
                "judgement_mace_t3",
                "dawnbreaker_sword_t3",
                "ambassador_sword_t3",
                */
                "composite_bow",
                "empire_sword_6_t5",
                "empire_sword_4_t4",
                "pauldron_cape_a",
                "steppe_heavy_bow",
                "t2_aserai_horse",
                "imperial_scale_armor",
                "lamellar_plate_boots",
                "bodkin_arrows_a",
                "battania_horse_harness",
                "wide_leaf_spear_t4",
                "decorated_imperial_gauntlets",
                "empire_lord_helmet",
                "lamellar_plate_boots",
                "nordic_shortbow",
                "fortified_kite_shield",
                "flat_heater_shield",
                "piercing_arrows",
                "closed_desert_helmet_with_mail",
                "t2_aserai_horse",
                "steppe_guardian_shield",
                "crossbow_c",
                "crossbow_c",
                "sturgian_helmet_closed",
                "full_helm_over_laced_coif",
                "noble_horse_southern",
                "noble_horse_imperial",
                "noble_horse_western",
                "noble_horse_eastern",
                "noble_horse_battania",
                "noble_horse_northern",
                "special_camel"
            }).GetRandomElement<string>());
        }
    }
}
