using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
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
    [HarmonyPatch(typeof(TournamentManager), "OnPlayerJoinTournament")]
    class JoinTournamentPatch
    {
        public static bool Prefix(TournamentManager __instance)
        {
            Settings.round = 1;
            return true;
        }
    }
}
