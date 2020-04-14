using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.Core;
using TaleWorlds.Localization;
using TaleWorlds.MountAndBlade;

namespace ModuleTemplate
{
    public class SubModule : MBSubModuleBase
    {
        /// <summary>
        /// 游戏处于加载界面时最先被调用的函数，你应该在这个函数中完成初始化的主要部分
        /// </summary>
        protected override void OnSubModuleLoad()
        {
            Module.CurrentModule.AddInitialStateOption(new InitialStateOption("Message",
                new TextObject("模板消息", null), 9990,
                () => { 
                    InformationManager.DisplayMessage(new InformationMessage("Hello World!"));
                },
                false));
        }
    }
}
