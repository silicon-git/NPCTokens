using ContentPatcher;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using StardewValley.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NPCTokens
{
    public class ModEntry
    : Mod
    {
        public override void Entry(IModHelper helper)
        {
            helper.Events.GameLoop.GameLaunched += GameLaunched;
        }

        private void GameLaunched(object sender, GameLaunchedEventArgs e)
        {
            var api = this.Helper.ModRegistry.GetApi<IContentPatcherAPI>("Pathoschild.ContentPatcher");
            if (api != null)
                api.RegisterToken(this.ModManifest, "NPC", new TokenImplement ());   
        }

    }
}
