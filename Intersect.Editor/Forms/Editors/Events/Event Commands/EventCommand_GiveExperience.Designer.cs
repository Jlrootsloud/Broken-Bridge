using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{
    partial class EventCommandGiveExperience
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
            this.grpGiveExperience = new DarkUI.Controls.DarkGroupBox();
            this.nudExperience = new DarkUI.Controls.DarkNumericUpDown();
            this.lblExperience = new System.Windows.Forms.Label();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.FarmingXP = new DarkUI.Controls.DarkNumericUpDown();
            this.FamingLabel = new System.Windows.Forms.Label();
            this.grpGiveExperience.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExperience)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FarmingXP)).BeginInit();
            this.SuspendLayout();
            // 
            // grpGiveExperience
            // 
            this.grpGiveExperience.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpGiveExperience.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpGiveExperience.Controls.Add(this.FarmingXP);
            this.grpGiveExperience.Controls.Add(this.FamingLabel);
            this.grpGiveExperience.Controls.Add(this.nudExperience);
            this.grpGiveExperience.Controls.Add(this.lblExperience);
            this.grpGiveExperience.Controls.Add(this.btnCancel);
            this.grpGiveExperience.Controls.Add(this.btnSave);
            this.grpGiveExperience.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpGiveExperience.Location = new System.Drawing.Point(3, 3);
            this.grpGiveExperience.Name = "grpGiveExperience";
            this.grpGiveExperience.Size = new System.Drawing.Size(259, 222);
            this.grpGiveExperience.TabIndex = 17;
            this.grpGiveExperience.TabStop = false;
            this.grpGiveExperience.Text = "Give Experience:";
            // 
            // nudExperience
            // 
            this.nudExperience.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudExperience.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudExperience.Location = new System.Drawing.Point(112, 20);
            this.nudExperience.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudExperience.Name = "nudExperience";
            this.nudExperience.Size = new System.Drawing.Size(141, 20);
            this.nudExperience.TabIndex = 22;
            this.nudExperience.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudExperience.ValueChanged += new System.EventHandler(this.nudExperience_ValueChanged);
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Location = new System.Drawing.Point(4, 22);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(91, 13);
            this.lblExperience.TabIndex = 21;
            this.lblExperience.Text = "Give Experience: ";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(88, 193);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(7, 193);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Ok";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FarmingXP
            // 
            this.FarmingXP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.FarmingXP.ForeColor = System.Drawing.Color.Gainsboro;
            this.FarmingXP.Location = new System.Drawing.Point(112, 48);
            this.FarmingXP.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.FarmingXP.Name = "FarmingXP";
            this.FarmingXP.Size = new System.Drawing.Size(141, 20);
            this.FarmingXP.TabIndex = 24;
            this.FarmingXP.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // FamingLabel
            // 
            this.FamingLabel.AutoSize = true;
            this.FamingLabel.Location = new System.Drawing.Point(4, 50);
            this.FamingLabel.Name = "FamingLabel";
            this.FamingLabel.Size = new System.Drawing.Size(106, 13);
            this.FamingLabel.TabIndex = 23;
            this.FamingLabel.Text = "Farming Experience: ";
            // 
            // EventCommandGiveExperience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.grpGiveExperience);
            this.Name = "EventCommandGiveExperience";
            this.Size = new System.Drawing.Size(268, 228);
            this.grpGiveExperience.ResumeLayout(false);
            this.grpGiveExperience.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExperience)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FarmingXP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkGroupBox grpGiveExperience;
        private DarkButton btnCancel;
        private DarkButton btnSave;
        private System.Windows.Forms.Label lblExperience;
        private DarkNumericUpDown nudExperience;
        private DarkNumericUpDown FarmingXP;
        private System.Windows.Forms.Label FamingLabel;
    }
}
