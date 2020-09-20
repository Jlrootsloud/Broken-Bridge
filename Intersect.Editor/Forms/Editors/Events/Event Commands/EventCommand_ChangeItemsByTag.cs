using System;
using System.Linq;
using System.Windows.Forms;

using Intersect.Editor.Localization;
using Intersect.GameObjects;
using Intersect.GameObjects.Events;
using Intersect.GameObjects.Events.Commands;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{

    public partial class EventCommandChangeItemsBytag : UserControl
    {

        private readonly FrmEvent mEventEditor;

        private EventPage mCurrentPage;

        private ChangeItemsByTag mMyCommand;

        public EventCommandChangeItemsBytag(ChangeItemsByTag refCommand, EventPage refPage, FrmEvent editor)
        {
            InitializeComponent();
            mMyCommand = refCommand;
            mEventEditor = editor;
            mCurrentPage = refPage;
            InitLocalization();
            cmbTags.Items.Clear();
            cmbTags.Items.AddRange(ItemBase.AllTags.OrderBy(x => x).ToArray());
            cmbTags.SelectedIndex = cmbTags.Items.IndexOf(mMyCommand.Tag ?? "");
            if (mMyCommand.Quantity < 1)
            {
                nudGiveTakeAmount.Value = 1;
            }
            else
            {
                nudGiveTakeAmount.Value = mMyCommand.Quantity;
            }


        }

        private void InitLocalization()
        {
            lblAmount.Text = Strings.EventChangeItemsByTag.amount;
            grpChangeItemsBytag.Text = Strings.EventChangeItemsByTag.title;
            lblTag.Text = Strings.EventChangeItemsByTag.tag;
            btnSave.Text = Strings.EventChangeItemsByTag.okay;
            btnCancel.Text = Strings.EventChangeItemsByTag.cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mMyCommand.Tag = cmbTags.GetItemText(cmbTags.SelectedItem);
            mMyCommand.Add = !Convert.ToBoolean(cmbAction.SelectedIndex);
            mMyCommand.Quantity = (int) nudGiveTakeAmount.Value;
            mEventEditor.FinishCommandEdit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mEventEditor.CancelCommandEdit();
        }

    }

}
