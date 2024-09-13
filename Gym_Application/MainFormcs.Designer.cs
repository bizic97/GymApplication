namespace Gym_Application
{
    partial class MainFormcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormcs));
            this.addMemberbButton = new System.Windows.Forms.Button();
            this.updateMainFormButton = new System.Windows.Forms.Button();
            this.paymentButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.viewMemberButton = new System.Windows.Forms.Button();
            this.backToLoginButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addMemberbButton
            // 
            this.addMemberbButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addMemberbButton.Location = new System.Drawing.Point(177, 198);
            this.addMemberbButton.Name = "addMemberbButton";
            this.addMemberbButton.Size = new System.Drawing.Size(160, 69);
            this.addMemberbButton.TabIndex = 7;
            this.addMemberbButton.Text = "Add Member";
            this.addMemberbButton.UseMnemonic = false;
            this.addMemberbButton.UseVisualStyleBackColor = false;
            this.addMemberbButton.Click += new System.EventHandler(this.addMemberbButton_Click);
            // 
            // updateMainFormButton
            // 
            this.updateMainFormButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateMainFormButton.Location = new System.Drawing.Point(177, 57);
            this.updateMainFormButton.Name = "updateMainFormButton";
            this.updateMainFormButton.Size = new System.Drawing.Size(160, 69);
            this.updateMainFormButton.TabIndex = 8;
            this.updateMainFormButton.Text = "Update/Delete";
            this.updateMainFormButton.UseMnemonic = false;
            this.updateMainFormButton.UseVisualStyleBackColor = false;
            this.updateMainFormButton.Click += new System.EventHandler(this.updateMainFormButton_Click);
            // 
            // paymentButton
            // 
            this.paymentButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.paymentButton.Location = new System.Drawing.Point(881, 57);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new System.Drawing.Size(160, 69);
            this.paymentButton.TabIndex = 9;
            this.paymentButton.Text = "Payment";
            this.paymentButton.UseMnemonic = false;
            this.paymentButton.UseVisualStyleBackColor = false;
            this.paymentButton.Click += new System.EventHandler(this.paymentButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(802, 633);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(262, 22);
            this.label9.TabIndex = 32;
            this.label9.Text = "Developed by Aleksandar Bizic\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(1117, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 54);
            this.label5.TabIndex = 48;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // viewMemberButton
            // 
            this.viewMemberButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewMemberButton.Location = new System.Drawing.Point(881, 198);
            this.viewMemberButton.Name = "viewMemberButton";
            this.viewMemberButton.Size = new System.Drawing.Size(160, 69);
            this.viewMemberButton.TabIndex = 49;
            this.viewMemberButton.Text = "View Member";
            this.viewMemberButton.UseMnemonic = false;
            this.viewMemberButton.UseVisualStyleBackColor = false;
            this.viewMemberButton.Click += new System.EventHandler(this.viewMemberButton_Click);
            // 
            // backToLoginButton
            // 
            this.backToLoginButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backToLoginButton.Location = new System.Drawing.Point(527, 555);
            this.backToLoginButton.Name = "backToLoginButton";
            this.backToLoginButton.Size = new System.Drawing.Size(160, 69);
            this.backToLoginButton.TabIndex = 50;
            this.backToLoginButton.Text = "Back";
            this.backToLoginButton.UseMnemonic = false;
            this.backToLoginButton.UseVisualStyleBackColor = false;
            this.backToLoginButton.Click += new System.EventHandler(this.backToLoginButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1164, 687);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // MainFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 687);
            this.Controls.Add(this.backToLoginButton);
            this.Controls.Add(this.viewMemberButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.paymentButton);
            this.Controls.Add(this.updateMainFormButton);
            this.Controls.Add(this.addMemberbButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainFormcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFormcs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addMemberbButton;
        private System.Windows.Forms.Button updateMainFormButton;
        private System.Windows.Forms.Button paymentButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button viewMemberButton;
        private System.Windows.Forms.Button backToLoginButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}