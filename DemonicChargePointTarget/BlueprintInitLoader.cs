using HarmonyLib;
using Kingmaker.Blueprints.JsonSystem;
using Kingmaker.UnitLogic.Abilities.Blueprints;

namespace DemonicChargePointTarget
{
    internal class BlueprintInitLoader
    {
        [HarmonyPatch(typeof(BlueprintsCache), nameof(BlueprintsCache.Init))]
        static class BlueprintsCache_Init_Patch
        {
            static bool Initialized;

            static void Postfix()
            {
                if (Initialized) return;
                Initialized = true;
                var demonicCharge = Utils.GetBlueprint<BlueprintAbility>("1b677ed598d47a048a0f6b4b671b8f84");
                demonicCharge.CanTargetPoint = true;
            }
        }
    }
}
