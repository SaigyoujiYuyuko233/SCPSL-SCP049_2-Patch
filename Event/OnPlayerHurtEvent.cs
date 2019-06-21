using Smod2;
using Smod2.API;
using Smod2.EventHandlers;
using Smod2.Events;

namespace SCPSL_SCP049_2_Patch.Event {
    
    public class OnPlayerHurtEvent : IEventHandlerPlayerHurt {
        
        // 插件对象
        private Plugin _plugin = null;

        public OnPlayerHurtEvent(Plugin plugin) {
            this._plugin = plugin;
        }
        
        public void OnPlayerHurt(PlayerHurtEvent ev) {
            
            // 如果插件没启用
            if (this._plugin.GetConfigBool("SCP049_2_patch_enable") == false) {
                return;
            }
            
            // 判断玩家是不是被SCP-049-2攻击的 | 不是结束事件
            if (ev.DamageType != DamageType.SCP_049_2) {
                return;
            }

            // 获取设定伤害
            ev.Damage = this._plugin.GetConfigInt("SCP049_2_patch_damage");

        }
        
    }
}