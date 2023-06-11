using MelonLoader;
using BTD_Mod_Helper;
using CamsTowerPack;

[assembly: MelonInfo(typeof(CamsTowerPack.CamsTowerPack), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace CamsTowerPack;

public class CamsTowerPack : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<CamsTowerPack>("CamsTowerPack loaded! Why are you reading this?");
    }
}