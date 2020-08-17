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

        Framework.Gwen.Control.Label mFarmingLvLabel;
        Framework.Gwen.Control.Label mMiningLvLabel;
        Framework.Gwen.Control.Label mFishingLvLabel;
        Framework.Gwen.Control.Label mWoodLvLabel;
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
        public ImagePanel ExpFarmingBackground;
        public ImagePanel FarmingIcon;
        public ImagePanel ExpFarmingBar;
        public Framework.Gwen.Control.Label ExpFarmingLbl;
        public Framework.Gwen.Control.Label ExpFarmingTitle;

        public ImagePanel ExpMiningBackground;
        public ImagePanel MiningIcon;
        public ImagePanel ExpMiningBar;
        public Framework.Gwen.Control.Label ExpMiningLbl;
        public Framework.Gwen.Control.Label ExpMiningTitle;

        public ImagePanel ExpFishingBackground;
        public ImagePanel FishingIcon;
        public ImagePanel ExpFishingBar;
        public Framework.Gwen.Control.Label ExpFishingLbl;
        public Framework.Gwen.Control.Label ExpFishingTitle;

        public ImagePanel ExpWoodBackground;
        public ImagePanel WoodIcon;
        public ImagePanel ExpWoodBar;
        public Framework.Gwen.Control.Label ExpWoodLbl;
        public Framework.Gwen.Control.Label ExpWoodTitle;
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
            mFarmingLvLabel = new Framework.Gwen.Control.Label(mSkillsWindow, "mFarmingLevelLabel");
            /*mFarmingBtn = new Button(mSkillsWindow, "IncreaseFarmingtButton");
            mFarmingBtn.Clicked += _addFarmingBtn_Clicked;*/

            mMiningLabel = new Framework.Gwen.Control.Label(mSkillsWindow, "mMiningLabel");
            mMiningLvLabel = new Framework.Gwen.Control.Label(mSkillsWindow, "mMiningLevelLabel");
            /*mMiningBtn = new Button(mSkillsWindow, "IncreaseMiningtButton");
            mMiningBtn.Clicked += _addMiningBtn_Clicked;*/

            mFishingLabel = new Framework.Gwen.Control.Label(mSkillsWindow, "mFishingLabel");
            mFishingLvLabel = new Framework.Gwen.Control.Label(mSkillsWindow, "mFishingLevelLabel");
            /* mFishingBtn = new Button(mSkillsWindow, "IncreaseFishintButton");
             mFishingBtn.Clicked += _addFishingBtn_Clicked;*/

            mWoodcutterLabel = new Framework.Gwen.Control.Label(mSkillsWindow, "mWoodcutterLabel");
            mWoodLvLabel = new Framework.Gwen.Control.Label(mSkillsWindow, "mWoodLevelLabel");
            /*mWoodcutterBtn = new Button(mSkillsWindow, "IncreaseWoodcuttertButton");
            mWoodcutterBtn.Clicked += _addWoodcutterBtn_Clicked;*/


            /* var CraftskillLabel = new Framework.Gwen.Control.Label(mSkillsWindow, "CrafttingSkillsLabel");
             CraftskillLabel.SetText(Strings.Skills.recoskill);*/

            ExpFarmingBackground = new ImagePanel(mSkillsWindow, "EXPFarmingBackground");
            ExpFarmingBar = new ImagePanel(mSkillsWindow, "EXPFarmingBar");
            FarmingIcon = new ImagePanel(mSkillsWindow, "FarmingIcon");
            ExpFarmingTitle = new Framework.Gwen.Control.Label(mSkillsWindow, "EXPFarmingTitle");
            ExpFarmingTitle.SetText(Strings.EntityBox.exp);
            ExpFarmingLbl = new Framework.Gwen.Control.Label(mSkillsWindow, "EXPFarmingLabel");

            ExpMiningBackground = new ImagePanel(mSkillsWindow, "EXPMiningBackground");
            ExpMiningBar = new ImagePanel(mSkillsWindow, "EXPMiningBar");
            MiningIcon = new ImagePanel(mSkillsWindow, "MiningIcon");
            ExpMiningTitle = new Framework.Gwen.Control.Label(mSkillsWindow, "EXPMiningTitle");
            ExpMiningTitle.SetText(Strings.EntityBox.exp);
            ExpMiningLbl = new Framework.Gwen.Control.Label(mSkillsWindow, "EXPMiningLabel");

            ExpFishingBackground = new ImagePanel(mSkillsWindow, "EXPFishingBackground");
            ExpFishingBar = new ImagePanel(mSkillsWindow, "EXPFishingBar");
            FishingIcon = new ImagePanel(mSkillsWindow, "FishingIcon");
            ExpFishingTitle = new Framework.Gwen.Control.Label(mSkillsWindow, "EXPFishingTitle");
            ExpFishingTitle.SetText(Strings.EntityBox.exp);
            ExpFishingLbl = new Framework.Gwen.Control.Label(mSkillsWindow, "EXPFishingLabel");

            ExpWoodBackground = new ImagePanel(mSkillsWindow, "EXPWoodBackground");
            ExpWoodBar = new ImagePanel(mSkillsWindow, "EXPWoodBar");
            WoodIcon = new ImagePanel(mSkillsWindow, "WoodIcon");
            ExpWoodTitle = new Framework.Gwen.Control.Label(mSkillsWindow, "EXPWoodTitle");
            ExpWoodTitle.SetText(Strings.EntityBox.exp);
            ExpWoodLbl = new Framework.Gwen.Control.Label(mSkillsWindow, "EXPWoodLabel");
            mSkillsWindow.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());

            
        }
        public void Update()
        {
            //Time since this window was last updated (for bar animations)
            var elapsedTime = (Globals.System.GetTimeMs() - mLastUpdateTime) / 1000.0f;
            mFarmingLabel.SetText(
               Strings.Skills.skill0.ToString(Strings.Job.skill0)
           );
            mFarmingLvLabel.SetText(
               Strings.Skills.SkillLv.ToString(Globals.Me.FarmingLevel));

            mMiningLabel.SetText(
               Strings.Skills.skill1.ToString(Strings.Job.skill1, Globals.Me.FarmingLevel)
                          );
             mMiningLvLabel.SetText(
              Strings.Skills.SkillLv.ToString(Globals.Me.MiningLevel));

            mFishingLabel.SetText(
          Strings.Skills.skill2.ToString(Strings.Job.skill2, Globals.Me.FishingLevel)
      );
            mFishingLvLabel.SetText(
              Strings.Skills.SkillLv.ToString(Globals.Me.FishingLevel));

            mWoodcutterLabel.SetText(
              Strings.Skills.skill3.ToString(Strings.Job.skill3, Globals.Me.WoodLevel)
          );
            mWoodLvLabel.SetText(
              Strings.Skills.SkillLv.ToString(Globals.Me.WoodLevel));


            //If player draw exp bar
            if (MyEntity == Globals.Me)
            {
                UpdateFarmingXpBar(elapsedTime);
          
            }

            if (MyEntity == Globals.Me)
            {
               
                UpdateMiningXpBar(elapsedTime);

            }
            if (MyEntity == Globals.Me)
            {
                
                UpdateFishingXpBar(elapsedTime);

            }
            if (MyEntity == Globals.Me)
            {
               
                UpdateWoodXpBar(elapsedTime);
            }

        }
        private void UpdateFarmingXpBar(float elapsedTime)
        {
            float targetExpWidth = 1;
            if (((Player)MyEntity).GetNextFarmingLevelExperience() > 0)
            {
                targetExpWidth = (float)((Player)MyEntity).FarmingExperience /
                                 (float)((Player)MyEntity).GetNextFarmingLevelExperience();

                ExpFarmingLbl.Text = Strings.EntityBox.expval.ToString(
                    ((Player)MyEntity)?.FarmingExperience, ((Player)MyEntity)?.GetNextFarmingLevelExperience()
                );
            }
            else
            {
                targetExpWidth = 1f;
                ExpFarmingLbl.Text = Strings.EntityBox.maxlevel;
            }

            targetExpWidth *= ExpFarmingBackground.Width;
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
                ExpFarmingBar.IsHidden = true;
            }
            else
            {
                ExpFarmingBar.Width = (int)CurExpWidth;
                ExpFarmingBar.SetTextureRect(0, 0, (int)CurExpWidth, ExpFarmingBar.Height);
                ExpFarmingBar.IsHidden = false;
            }
        }

        private void UpdateMiningXpBar(float elapsedTime)
        {
            float targetExpWidth = 1;
            if (((Player)MyEntity).GetNextMiningLevelExperience() > 0)
            {
                targetExpWidth = (float)((Player)MyEntity).MiningExperience /
                                 (float)((Player)MyEntity).GetNextMiningLevelExperience();

                ExpMiningLbl.Text = Strings.EntityBox.expval.ToString(
                    ((Player)MyEntity)?.MiningExperience, ((Player)MyEntity)?.GetNextMiningLevelExperience()
                );
            }
            else
            {
                targetExpWidth = 1f;
                ExpMiningLbl.Text = Strings.EntityBox.maxlevel;
            }

            targetExpWidth *= ExpMiningBackground.Width;
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
                ExpMiningBar.IsHidden = true;
            }
            else
            {
                ExpMiningBar.Width = (int)CurExpWidth;
                ExpMiningBar.SetTextureRect(0, 0, (int)CurExpWidth, ExpMiningBar.Height);
                ExpMiningBar.IsHidden = false;
            }
        }

        private void UpdateFishingXpBar(float elapsedTime)
        {
            float targetExpWidth = 1;
            if (((Player)MyEntity).GetNextFishingLevelExperience() > 0)
            {
                targetExpWidth = (float)((Player)MyEntity).FishingExperience /
                                 (float)((Player)MyEntity).GetNextFishingLevelExperience();

                ExpFishingLbl.Text = Strings.EntityBox.expval.ToString(
                    ((Player)MyEntity)?.FishingExperience, ((Player)MyEntity)?.GetNextFishingLevelExperience()
                );
            }
            else
            {
                targetExpWidth = 1f;
                ExpFishingLbl.Text = Strings.EntityBox.maxlevel;
            }

            targetExpWidth *= ExpFishingBackground.Width;
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
                ExpFishingBar.IsHidden = true;
            }
            else
            {
                ExpFishingBar.Width = (int)CurExpWidth;
                ExpFishingBar.SetTextureRect(0, 0, (int)CurExpWidth, ExpFishingBar.Height);
                ExpFishingBar.IsHidden = false;
            }
        }

        private void UpdateWoodXpBar(float elapsedTime)
        {
            float targetExpWidth = 1;
            if (((Player)MyEntity).GetNextWoodLevelExperience() > 0)
            {
                targetExpWidth = (float)((Player)MyEntity).WoodExperience /
                                 (float)((Player)MyEntity).GetNextWoodLevelExperience();

                ExpWoodLbl.Text = Strings.EntityBox.expval.ToString(
                    ((Player)MyEntity)?.WoodExperience, ((Player)MyEntity)?.GetNextWoodLevelExperience()
                );
            }
            else
            {
                targetExpWidth = 1f;
                ExpWoodLbl.Text = Strings.EntityBox.maxlevel;
            }

            targetExpWidth *= ExpWoodBackground.Width;
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
                ExpWoodBar.IsHidden = true;
            }
            else
            {
                ExpWoodBar.Width = (int)CurExpWidth;
                ExpWoodBar.SetTextureRect(0, 0, (int)CurExpWidth, ExpWoodBar.Height);
                ExpWoodBar.IsHidden = false;
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








