using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{
    partial class EventCommandChangeItemsBytag
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventCommandChangeItemsBytag));
            this.grpChangeItemsBytag = new DarkUI.Controls.DarkGroupBox();
            this.nudGiveTakeAmount = new DarkUI.Controls.DarkNumericUpDown();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cmbTags = new DarkUI.Controls.DarkComboBox();
            this.lblTag = new System.Windows.Forms.Label();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.cmbAction = new DarkUI.Controls.DarkComboBox();
            this.lblAction = new System.Windows.Forms.Label();
            this.grpChangeItemsBytag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiveTakeAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // grpChangeItemsBytag
            // 
            this.grpChangeItemsBytag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpChangeItemsBytag.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpChangeItemsBytag.Controls.Add(this.cmbAction);
            this.grpChangeItemsBytag.Controls.Add(this.lblAction);
            this.grpChangeItemsBytag.Controls.Add(this.nudGiveTakeAmount);
            this.grpChangeItemsBytag.Controls.Add(this.lblAmount);
            this.grpChangeItemsBytag.Controls.Add(this.cmbTags);
            this.grpChangeItemsBytag.Controls.Add(this.lblTag);
            this.grpChangeItemsBytag.Controls.Add(this.btnCancel);
            this.grpChangeItemsBytag.Controls.Add(this.btnSave);
            this.grpChangeItemsBytag.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpChangeItemsBytag.Location = new System.Drawing.Point(3, 3);
            this.grpChangeItemsBytag.Name = "grpChangeItemsBytag";
            this.grpChangeItemsBytag.Size = new System.Drawing.Size(193, 133);
            this.grpChangeItemsBytag.TabIndex = 17;
            this.grpChangeItemsBytag.TabStop = false;
            this.grpChangeItemsBytag.Text = "Take Item By Tag:";
            // 
            // nudGiveTakeAmount
            // 
            this.nudGiveTakeAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudGiveTakeAmount.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudGiveTakeAmount.Location = new System.Drawing.Point(64, 73);
            this.nudGiveTakeAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudGiveTakeAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGiveTakeAmount.Name = "nudGiveTakeAmount";
            this.nudGiveTakeAmount.Size = new System.Drawing.Size(115, 20);
            this.nudGiveTakeAmount.TabIndex = 26;
            this.nudGiveTakeAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(5, 75);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(46, 13);
            this.lblAmount.TabIndex = 25;
            this.lblAmount.Text = "Amount:";
            // 
            // cmbTags
            // 
            this.cmbTags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbTags.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbTags.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbTags.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbTags.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbTags.ButtonIcon")));
            this.cmbTags.DrawDropdownHoverOutline = false;
            this.cmbTags.DrawFocusRectangle = false;
            this.cmbTags.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTags.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbTags.FormattingEnabled = true;
            this.cmbTags.Location = new System.Drawing.Point(64, 19);
            this.cmbTags.Name = "cmbTags";
            this.cmbTags.Size = new System.Drawing.Size(115, 21);
            this.cmbTags.TabIndex = 22;
            this.cmbTags.Text = null;
            this.cmbTags.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(5, 21);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(29, 13);
            this.lblTag.TabIndex = 21;
            this.lblTag.Text = "Tag:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(89, 104);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(8, 104);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Ok";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbAction
            // 
            this.cmbAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbAction.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbAction.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbAction.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbAction.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbAction.ButtonIcon")));
            this.cmbAction.DrawDropdownHoverOutline = false;
            this.cmbAction.DrawFocusRectangle = false;
            this.cmbAction.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAction.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbAction.FormattingEnabled = true;
            this.cmbAction.Items.AddRange(new object[] {
            "Give",
            "Take"});
            this.cmbAction.Location = new System.Drawing.Point(64, 46);
            this.cmbAction.Name = "cmbAction";
            this.cmbAction.Size = new System.Drawing.Size(115, 21);
            this.cmbAction.TabIndex = 28;
            this.cmbAction.Text = "Give";
            this.cmbAction.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(5, 48);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(40, 13);
            this.lblAction.TabIndex = 27;
            this.lblAction.Text = "Action:";
            // 
            // EventCommandChangeItemsBytag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.grpChangeItemsBytag);
            this.Name = "EventCommandChangeItemsBytag";
            this.Size = new System.Drawing.Size(205, 139);
            this.grpChangeItemsBytag.ResumeLayout(false);
            this.grpChangeItemsBytag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiveTakeAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkGroupBox grpChangeItemsBytag;
        private DarkButton btnCancel;
        private DarkButton btnSave;
        private DarkComboBox cmbTags;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Label lblAmount;
        private DarkNumericUpDown nudGiveTakeAmount;
        private DarkComboBox cmbAction;
        private System.Windows.Forms.Label lblAction;
    }
}
