using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Models.TowerSets;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Unity.Display;
using MelonLoader;
using System;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;

[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace SleepingMonkey;


public class SleepingMonkey : ModTower
{
    public override TowerSet TowerSet => TowerSet.Primary;
    public override string BaseTower => TowerType.DartMonkey;
    public override int Cost => 0;
    public override int TopPathUpgrades => 0;
    public override int MiddlePathUpgrades => 0;
    public override int BottomPathUpgrades => 0;
    public override string Description => "It's just a Monkey Sleeping!";

    public override bool Use2DModel => true;
    public override string Icon => "SMIcon";

    public override string Portrait => "SMIcon";

    public override void ModifyBaseTowerModel(TowerModel towerModel)
    {
        towerModel.RemoveBehavior<AttackModel>();
    }

    public override string Get2DTexture(int[] tiers)
    {
        return "SMDisplay";
    }
}


