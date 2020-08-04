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
        Label mMiningLabel;
        Label mFarmingLabel;

        Label mFishingLabel;
        Label mWoodcutterLabel;
        Label mHunterLabel;

        Label mSmithingLabel;
        Label mCookingLabel;
        Label mAlquemyLabel;
        Label mTailorLabel;
        Label mJewerlyLabel;
        Label mCobblerLabel;
        Label mPointsLabel;
        //buttoms

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

        public int X;

        public int Y;
        //Init
        public SkillsWindow(Canvas gameCanvas)
        {

            mSkillsWindow = new WindowControl(gameCanvas, Strings.Skills.skill, false, "SkillsWindow");
            mSkillsWindow.DisableResizing();

            mSkillsName = new Label(mSkillsWindow, "SkillsNameLabel");
            mSkillsName.SetTextColor(Color.White, Label.ControlState.Normal);

            var RecoskillLabel = new Label(mSkillsWindow, "RecolectionSkillsLabel");
            RecoskillLabel.SetText(Strings.Skills.recoskill);
            //recolection

            mFarmingLabel = new Label(mSkillsWindow, "mFarmingLabel");
            /*mFarmingBtn = new Button(mSkillsWindow, "IncreaseFarmingtButton");
            mFarmingBtn.Clicked += _addFarmingBtn_Clicked;*/

            mMiningLabel = new Label(mSkillsWindow, "mMiningLabel");
            /*mMiningBtn = new Button(mSkillsWindow, "IncreaseMiningtButton");
            mMiningBtn.Clicked += _addMiningBtn_Clicked;*/

            mFishingLabel = new Label(mSkillsWindow, "mFishingLabel");
           /* mFishingBtn = new Button(mSkillsWindow, "IncreaseFishintButton");
            mFishingBtn.Clicked += _addFishingBtn_Clicked;*/

            mWoodcutterLabel = new Label(mSkillsWindow, "mWoodcutterLabel");
            /*mWoodcutterBtn = new Button(mSkillsWindow, "IncreaseWoodcuttertButton");
            mWoodcutterBtn.Clicked += _addWoodcutterBtn_Clicked;*/

            mPointsLabel = new Label(mSkillsWindow, "PointsLabel");

            var CraftskillLabel = new Label(mSkillsWindow, "CrafttingSkillsLabel");
            CraftskillLabel.SetText(Strings.Skills.recoskill);

            mSkillsWindow.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());
        }
        public void Update()
        {
            mFarmingLabel.SetText(
               Strings.Skills.skill0.ToString(Strings.Job.skill0, Globals.Me.Skill[(int)Skills.Farming])
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








