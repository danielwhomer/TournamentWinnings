using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TaleWorlds.Core;
using TaleWorlds.Localization;
using TaleWorlds.MountAndBlade;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Library;
using TaleWorlds.CampaignSystem.SandBox.Source.TournamentGames;
using HarmonyLib;


namespace TournamentWinnings
{
    internal class MySubModule : MBSubModuleBase
    {
        
        protected override void OnSubModuleLoad()
        {
            var harmony = new Harmony("mod.bannerlord.tourny");
            harmony.PatchAll();
        }
    }
}
