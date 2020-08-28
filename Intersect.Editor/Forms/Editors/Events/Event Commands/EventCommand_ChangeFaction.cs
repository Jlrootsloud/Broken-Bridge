using System;
using System.Windows.Forms;

using Intersect.Editor.Localization;
using Intersect.Enums;
using Intersect.GameObjects.Events.Commands;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{

    public partial class EventCommandChangeFaction : UserControl
    {

        private readonly FrmEvent mEventEditor;

        private ChangeFactionCommand mMyCommand;

        public EventCommandChangeFaction(ChangeFactionCommand refCommand, FrmEvent editor)
        {
            InitializeComponent();
            mMyCommand = refCommand;
            mEventEditor = editor;
            InitLocalization();
            cmbFaction.SelectedIndex = (int) mMyCommand.Faction;
        }

        private void InitLocalization()
        {
            grpChangeFaction.Text = Strings.EventChangeFaction.title;
            cmbFaction.Items.Clear();
            for (var i = 0; i < Strings.EventChangeFaction.faction.Count; i++)
            {
                cmbFaction.Items.Add(Strings.EventChangeFaction.faction[i]);
            }

            lblFaction.Text = Strings.EventChangeFaction.label;
            btnSave.Text = Strings.EventChangeFaction.okay;
            btnCancel.Text = Strings.EventChangeFaction.cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mMyCommand.Faction = (Factions) cmbFaction.SelectedIndex;
            mEventEditor.FinishCommandEdit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mEventEditor.CancelCommandEdit();
        }

    }

}
