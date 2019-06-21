using Smod2;
using Smod2.Attributes;
using Smod2.Config;

namespace SCPSL_SCP049_2_Patch {
    
    [PluginDetails(
        version = "1.0.0",
        author = "SaigyoujiYuyuko",
        configPrefix = "SCP49_2_patch",
        description = "a damage patch for SCP-049-2",
        id = "org.shitsurakugensou.scp.patch_scp_2",
        name = "SCP-049-2 Patch",
        SmodMajor = 3,
        SmodMinor = 1,
        SmodRevision = 20
    )]
    
    public class ScpslScp4902Patch : Plugin{
        
        public override void OnEnable() {
            this.Info("SCP-049-2 damage patch loaded!");
        }

        public override void OnDisable() {
            this.Info("SCP-049-2 damage patch unload!");
        }

        public override void Register() {
            
            // 配置
            this.AddConfig(new ConfigSetting("SCP049_2_patch_enable", true, true, "Enable/Disable SCP049-2 damage patch"));
            this.AddConfig(new ConfigSetting("SCP049_2_damage", 30, true, "The damage value of SCP049-2"));
            
            // 监听器
            
            
        }
        
    }
    
}