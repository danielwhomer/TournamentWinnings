using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HarmonyLib;
using TaleWorlds.MountAndBlade;
using TaleWorlds.Core;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.SandBox.Source.TournamentGames;
using TaleWorlds.CampaignSystem.Actions;


namespace TournamentWinnings
{
    [HarmonyPatch(typeof (TournamentManager), "OnPlayerWinMatch")]
    public class TournamentManagerPatch
    {
        public static bool Prefix(TournamentManager __instance) {
            ApplyReward(__instance);
            return true;
        }
        public static void ApplyReward(TournamentManager __instance)
        {
            Settlement giverSettlement = Settlement.CurrentSettlement;
            Hero reciepientHero = Hero.MainHero;
            int goldAmount = Settings.goldEarned * Settings.round;
            Settings.round++;
            if (Settings.round >= 5)
            {
                GiveGoldAction.ApplyForSettlementToCharacter(giverSettlement, reciepientHero, goldAmount);
                InformationManager.DisplayMessage(new InformationMessage(goldAmount.ToString() + " bonus Denars awarded by " + giverSettlement.Name.ToString() + " for winning the tournament "));
            }
            else
            {
                GiveGoldAction.ApplyForSettlementToCharacter(giverSettlement, reciepientHero, goldAmount);
                InformationManager.DisplayMessage(new InformationMessage(goldAmount.ToString() + " bonus Denars awarded by " + giverSettlement.Name.ToString() + " for proceeding to round " + Settings.round.ToString()));
            }
                
            
        }
    }
}
