namespace Countdown
{
    partial class Settings
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTaskNumber = new System.Windows.Forms.Label();
            this.btnTaskDecrement = new System.Windows.Forms.Button();
            this.btnTaskIncrement = new System.Windows.Forms.Button();
            this.btnBreakIncrement = new System.Windows.Forms.Button();
            this.btnBreakDecrement = new System.Windows.Forms.Button();
            this.lblBreakTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(79, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "TASK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(58, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "time settings";
            // 
            // lblTaskNumber
            // 
            this.lblTaskNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblTaskNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTaskNumber.Location = new System.Drawing.Point(48, 73);
            this.lblTaskNumber.Name = "lblTaskNumber";
            this.lblTaskNumber.Size = new System.Drawing.Size(130, 30);
            this.lblTaskNumber.TabIndex = 6;
            this.lblTaskNumber.Text = "25";
            this.lblTaskNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTaskDecrement
            // 
            this.btnTaskDecrement.BackColor = System.Drawing.Color.Silver;
            this.btnTaskDecrement.FlatAppearance.BorderSize = 0;
            this.btnTaskDecrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaskDecrement.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskDecrement.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTaskDecrement.Location = new System.Drawing.Point(19, 73);
            this.btnTaskDecrement.Name = "btnTaskDecrement";
            this.btnTaskDecrement.Size = new System.Drawing.Size(30, 30);
            this.btnTaskDecrement.TabIndex = 7;
            this.btnTaskDecrement.Text = "-";
            this.btnTaskDecrement.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTaskDecrement.UseVisualStyleBackColor = false;
            this.btnTaskDecrement.Click += new System.EventHandler(this.btnTaskDecrement_Click);
            // 
            // btnTaskIncrement
            // 
            this.btnTaskIncrement.BackColor = System.Drawing.Color.Silver;
            this.btnTaskIncrement.FlatAppearance.BorderSize = 0;
            this.btnTaskIncrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaskIncrement.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskIncrement.Location = new System.Drawing.Point(176, 73);
            this.btnTaskIncrement.Name = "btnTaskIncrement";
            this.btnTaskIncrement.Size = new System.Drawing.Size(30, 30);
            this.btnTaskIncrement.TabIndex = 8;
            this.btnTaskIncrement.Text = "+";
            this.btnTaskIncrement.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTaskIncrement.UseVisualStyleBackColor = false;
            this.btnTaskIncrement.Click += new System.EventHandler(this.btnTaskIncrement_Click);
            // 
            // btnBreakIncrement
            // 
            this.btnBreakIncrement.BackColor = System.Drawing.Color.Silver;
            this.btnBreakIncrement.FlatAppearance.BorderSize = 0;
            this.btnBreakIncrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBreakIncrement.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnBreakIncrement.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBreakIncrement.Location = new System.Drawing.Point(177, 145);
            this.btnBreakIncrement.Name = "btnBreakIncrement";
            this.btnBreakIncrement.Size = new System.Drawing.Size(30, 30);
            this.btnBreakIncrement.TabIndex = 11;
            this.btnBreakIncrement.Text = "+";
            this.btnBreakIncrement.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBreakIncrement.UseVisualStyleBackColor = false;
            this.btnBreakIncrement.Click += new System.EventHandler(this.btnBreakIncrement_Click);
            // 
            // btnBreakDecrement
            // 
            this.btnBreakDecrement.BackColor = System.Drawing.Color.Silver;
            this.btnBreakDecrement.FlatAppearance.BorderSize = 0;
            this.btnBreakDecrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBreakDecrement.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBreakDecrement.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBreakDecrement.Location = new System.Drawing.Point(20, 145);
            this.btnBreakDecrement.Name = "btnBreakDecrement";
            this.btnBreakDecrement.Size = new System.Drawing.Size(30, 30);
            this.btnBreakDecrement.TabIndex = 10;
            this.btnBreakDecrement.Text = "-";
            this.btnBreakDecrement.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBreakDecrement.UseVisualStyleBackColor = false;
            this.btnBreakDecrement.Click += new System.EventHandler(this.btnBreakDecrement_Click);
            // 
            // lblBreakTime
            // 
            this.lblBreakTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblBreakTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBreakTime.Location = new System.Drawing.Point(49, 145);
            this.lblBreakTime.Name = "lblBreakTime";
            this.lblBreakTime.Size = new System.Drawing.Size(130, 30);
            this.lblBreakTime.TabIndex = 9;
            this.lblBreakTime.Text = "5";
            this.lblBreakTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(68, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 33);
            this.label5.TabIndex = 12;
            this.label5.Text = "BREAK";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(74, 190);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 38);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(23)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(235, 252);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBreakIncrement);
            this.Controls.Add(this.btnBreakDecrement);
            this.Controls.Add(this.lblBreakTime);
            this.Controls.Add(this.btnTaskIncrement);
            this.Controls.Add(this.btnTaskDecrement);
            this.Controls.Add(this.lblTaskNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTaskNumber;
        private System.Windows.Forms.Button btnTaskDecrement;
        private System.Windows.Forms.Button btnTaskIncrement;
        private System.Windows.Forms.Button btnBreakIncrement;
        private System.Windows.Forms.Button btnBreakDecrement;
        private System.Windows.Forms.Label lblBreakTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
    }
}