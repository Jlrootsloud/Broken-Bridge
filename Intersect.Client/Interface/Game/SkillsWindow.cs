using System;

using Intersect.Client.Core;
using Intersect.Client.Framework.Gwen.Control;
using Intersect.Client.Localization;
using Intersect.Client.Framework.File_Management;
using Intersect.Client.General;
using Intersect.Enums;
using Intersect.Client.Entities;

namespace Intersect.Client.Interface.Game
{

    public class SkillsWindow
    {

       

     

        //Controls
        private WindowControl mSkillsWindow;
        public float CurExpWidth;

        public float CurHpWidth;

        public float CurMpWidth;
        public ImagePanel EntityInfoPanel;
        private Framework.Gwen.Control.Label mSkillsName;
        Framework.Gwen.Control.Label mMiningLabel;
        Framework.Gwen.Control.Label mFarmingLabel;

        Framework.Gwen.Control.Label mFishingLabel;
        Framework.Gwen.Control.Label mWoodcutterLabel;
        Framework.Gwen.Control.Label mHunterLabel;

        Framework.Gwen.Control.Label mSmithingLabel;
        Framework.Gwen.Control.Label mCookingLabel;
        Framework.Gwen.Control.Label mAlquemyLabel;
        Framework.Gwen.Control.Label mTailorLabel;
        Framework.Gwen.Control.Label mJewerlyLabel;
        Framework.Gwen.Control.Label mCobblerLabel;
        Framework.Gwen.Control.Label mPointsLabel;
        //buttoms
        private long mLastUpdateTime;
        Button mMiningBtn;
        Button mFarmingBtn;

        Button mFishingBtn;
        Button mWoodcutterBtn;
        Button mHunterBtn;

        Button mSmithingBtn;
        Button mCookingBtn;
        Button mAlquemyBtn;
        Button mTailorBtn;
        Button mJewerlyBtn;
        Button mCobblerBtn;
        Button mRecoSkillsBtn;
        Button mCraftSkillsBtn;
        public Entity MyEntity;
        public int X;

        public int Y;
        public ImagePanel ExpBackground;

        public ImagePanel SkillIcon;
        public ImagePanel ExpBar;

        public Framework.Gwen.Control.Label ExpLbl;

        public Framework.Gwen.Control.Label ExpTitle;
        //Init
        public SkillsWindow(Canvas gameCanvas, Entity myEntity)
        {
            MyEntity = myEntity;
          

            mSkillsWindow = new WindowControl(gameCanvas, Strings.Skills.skill, false, "SkillsWindow");
            mSkillsWindow.DisableResizing();

            mSkillsName = new Framework.Gwen.Control.Label(mSkillsWindow, "SkillsNameLabel");
            mSkillsName.SetTextColor(Color.White,  Framework.Gwen.Control.Label.ControlState.Normal);

            var RecoskillLabel =  new Framework.Gwen.Control.Label(mSkillsWindow, "RecolectionSkillsLabel");
            RecoskillLabel.SetText(Strings.Skills.recoskill);
            //recolection

            mFarmingLabel = new  Framework.Gwen.Control.Label(mSkillsWindow, "mFarmingLabel");
            /*mFarmingBtn = new Button(mSkillsWindow, "IncreaseFarmingtButton");
            mFarmingBtn.Clicked += _addFarmingBtn_Clicked;*/

            mMiningLabel = new Framework.Gwen.Control.Label(mSkillsWindow, "mMiningLabel");
            /*mMiningBtn = new Button(mSkillsWindow, "IncreaseMiningtButton");
            mMiningBtn.Clicked += _addMiningBtn_Clicked;*/

            mFishingLabel = new Framework.Gwen.Control.Label(mSkillsWindow, "mFishingLabel");
           /* mFishingBtn = new Button(mSkillsWindow, "IncreaseFishintButton");
            mFishingBtn.Clicked += _addFishingBtn_Clicked;*/

            mWoodcutterLabel = new Framework.Gwen.Control.Label(mSkillsWindow, "mWoodcutterLabel");
            /*mWoodcutterBtn = new Button(mSkillsWindow, "IncreaseWoodcuttertButton");
            mWoodcutterBtn.Clicked += _addWoodcutterBtn_Clicked;*/

            mPointsLabel = new Framework.Gwen.Control.Label(mSkillsWindow, "PointsLabel");

            var CraftskillLabel = new Framework.Gwen.Control.Label(mSkillsWindow, "CrafttingSkillsLabel");
            CraftskillLabel.SetText(Strings.Skills.recoskill);
            
            ExpBackground = new ImagePanel(mSkillsWindow, "EXPBackground");
            ExpBar = new ImagePanel(mSkillsWindow, "EXPBar");
            SkillIcon = new ImagePanel(mSkillsWindow,"SkillIcon");
            ExpTitle = new Framework.Gwen.Control.Label(mSkillsWindow, "EXPTitle");
            ExpTitle.SetText(Strings.EntityBox.exp);
            ExpLbl = new Framework.Gwen.Control.Label(mSkillsWindow, "EXPLabel");

            mSkillsWindow.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());

            
        }
        public void Update()
        {
            //Time since this window was last updated (for bar animations)
            var elapsedTime = (Globals.System.GetTimeMs() - mLastUpdateTime) / 1000.0f;
            mFarmingLabel.SetText(
               Strings.Skills.skill0.ToString(Strings.Job.skill0, Globals.Me.FarmingLevel)
           );
            mMiningLabel.SetText(
               Strings.Skills.skill1.ToString(Strings.Job.skill1, Globals.Me.Skill[(int)Skills.Mining])

           );

            mWoodcutterLabel.SetText(
              Strings.Skills.skill2.ToString(Strings.Job.skill2, Globals.Me.Skill[(int)Skills.Woodcutter])
          );

            mFishingLabel.SetText(
              Strings.Skills.skill3.ToString(Strings.Job.skill3, Globals.Me.Skill[(int)Skills.Fishing])
          );

            //If player draw exp bar
            if (MyEntity == Globals.Me)
            {
                UpdateXpBar(elapsedTime);
            }

        }
        private void UpdateXpBar(float elapsedTime)
        {
            float targetExpWidth = 1;
            if (((Player)MyEntity).GetNextFarmingLevelExperience() > 0)
            {
                targetExpWidth = (float)((Player)MyEntity).FarmingExperience /
                                 (float)((Player)MyEntity).GetNextFarmingLevelExperience();

                ExpLbl.Text = Strings.EntityBox.expval.ToString(
                    ((Player)MyEntity)?.FarmingExperience, ((Player)MyEntity)?.GetNextFarmingLevelExperience()
                );
            }
            else
            {
                targetExpWidth = 1f;
                ExpLbl.Text = Strings.EntityBox.maxlevel;
            }

            targetExpWidth *= ExpBackground.Width;
            if (Math.Abs((int)targetExpWidth - CurExpWidth) < 0.01)
            {
                return;
            }

            if ((int)targetExpWidth > CurExpWidth)
            {
                CurExpWidth += 100f * elapsedTime;
                if (CurExpWidth > (int)targetExpWidth)
                {
                    CurExpWidth = targetExpWidth;
                }
            }
            else
            {
                CurExpWidth -= 100f * elapsedTime;
                if (CurExpWidth < targetExpWidth)
                {
                    CurExpWidth = targetExpWidth;
                }
            }

            if (CurExpWidth == 0)
            {
                ExpBar.IsHidden = true;
            }
            else
            {
                ExpBar.Width = (int)CurExpWidth;
                ExpBar.SetTextureRect(0, 0, (int)CurExpWidth, ExpBar.Height);
                ExpBar.IsHidden = false;
            }
        }
    
    /* void _addFarmingBtn_Clicked(Base sender, ClickedEventArgs arguments)
     {
         PacketSender.SendUpgradeSkill((int)Skills.Farming);
     }
     void _addWoodcutterBtn_Clicked(Base sender, ClickedEventArgs arguments)
     {
         PacketSender.SendUpgradeSkill((int)Skills.Woodcutter);
     }
     void _addMiningBtn_Clicked(Base sender, ClickedEventArgs arguments)
     {
         PacketSender.SendUpgradeSkill((int)Skills.Mining);
     }
     void _addFishingBtn_Clicked(Base sender, ClickedEventArgs arguments)
     {
         PacketSender.SendUpgradeSkill((int)Skills.Fishing);
     }*/
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








