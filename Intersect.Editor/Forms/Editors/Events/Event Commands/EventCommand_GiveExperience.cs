using System;
using System.Windows.Forms;

using Intersect.Editor.Localization;
using Intersect.GameObjects.Events.Commands;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{

    public partial class EventCommandGiveExperience : UserControl
    {

        private readonly FrmEvent mEventEditor;

        private GiveExperienceCommand mMyCommand;

        public EventCommandGiveExperience(GiveExperienceCommand refCommand, FrmEvent editor)
        {
            InitializeComponent();
            mMyCommand = refCommand;
            mEventEditor = editor;
            InitLocalization();
            nudExperience.Value = mMyCommand.Exp;
            FarmingXP.Value = mMyCommand.FarmingExp;
            MiningXP.Value = mMyCommand.MiningExp;
            FishingXP.Value = mMyCommand.FishingExp;
            WoodXP.Value = mMyCommand.WoodExp;
            FactionXP.Value = mMyCommand.FactionXP;

        }

        private void InitLocalization()
        {
            grpGiveExperience.Text = Strings.EventGiveExperience.title;
            lblExperience.Text = Strings.EventGiveExperience.label;
            btnSave.Text = Strings.EventGiveExperience.okay;
            btnCancel.Text = Strings.EventGiveExperience.cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mMyCommand.Exp = (long) nudExperience.Value;
            mMyCommand.FarmingExp = (long)FarmingXP.Value;
            mMyCommand.MiningExp = (long)MiningXP.Value;
            mMyCommand.FishingExp = (long)FishingXP.Value;
            mMyCommand.WoodExp = (long)WoodXP.Value;
            mMyCommand.FactionXP = (long)FactionXP.Value;
            mEventEditor.FinishCommandEdit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mEventEditor.CancelCommandEdit();
        }

        private void nudExperience_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FarmingXP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void WoodXP_ValueChanged(object sender, EventArgs e)
        {

        }
    }

}
