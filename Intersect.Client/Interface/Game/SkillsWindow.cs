using System;

using Intersect.Client.Core;
using Intersect.Client.Framework.Gwen;
using Intersect.Client.Framework.Gwen.Control;
using Intersect.Client.Framework.Gwen.Control.EventArguments;
using Intersect.Client.Localization;
using Intersect.Client.Framework.File_Management;
using Intersect.Client.General;
using Intersect.Client.Networking;
using Intersect.Enums;
using Intersect.GameObjects;

namespace Intersect.Client.Interface.Game
{

    public class SkillsWindow
    {

        

        //Controls
        private WindowControl mSkillsWindow;

        private Label mSkillsName;


        //Init
        public SkillsWindow(Canvas gameCanvas)
        {

            mSkillsWindow = new WindowControl(gameCanvas, Strings.Skills.skill, false, "SkillsWindow");
            mSkillsWindow.DisableResizing();

            mSkillsName = new Label(mSkillsWindow, "SkillsNameLabel");
            mSkillsName.SetTextColor(Color.White, Label.ControlState.Normal);
            mSkillsWindow.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());
        } 
        public void Update()
        {

        }

        public void Show()
        {
            mSkillsWindow.IsHidden = false;
        }

        public bool IsVisible()
        {
            return !mSkillsWindow.IsHidden;
        }

        public void Hide()
        {
            mSkillsWindow.IsHidden = true;
        }

        
    }

    
}
    

       
        
    

    
    
