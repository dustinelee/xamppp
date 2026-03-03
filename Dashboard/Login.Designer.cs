namespace Dashboard
{
    partial class Login
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
            txtBone = new TextBox();
            txtBtwo = new TextBox();
            lblLone = new Label();
            lblLtwo = new Label();
            btnBone = new Button();
            SuspendLayout();
            // 
            // txtBone
            // 
            txtBone.Location = new Point(126, 31);
            txtBone.Name = "txtBone";
            txtBone.Size = new Size(172, 23);
            txtBone.TabIndex = 0;
            // 
            // txtBtwo
            // 
            txtBtwo.Location = new Point(126, 72);
            txtBtwo.Name = "txtBtwo";
            txtBtwo.Size = new Size(172, 23);
            txtBtwo.TabIndex = 1;
            // 
            // lblLone
            // 
            lblLone.AutoSize = true;
            lblLone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLone.Location = new Point(42, 34);
            lblLone.Name = "lblLone";
            lblLone.Size = new Size(67, 15);
            lblLone.TabIndex = 2;
            lblLone.Text = "Username:";
            // 
            // lblLtwo
            // 
            lblLtwo.AutoSize = true;
            lblLtwo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLtwo.Location = new Point(42, 72);
            lblLtwo.Name = "lblLtwo";
            lblLtwo.Size = new Size(62, 15);
            lblLtwo.TabIndex = 3;
            lblLtwo.Text = "Password:";
            // 
            // btnBone
            // 
            btnBone.BackColor = SystemColors.ActiveBorder;
            btnBone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBone.Location = new Point(144, 114);
            btnBone.Name = "btnBone";
            btnBone.Size = new Size(133, 23);
            btnBone.TabIndex = 4;
            btnBone.Text = "LOGIN";
            btnBone.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 149);
            Controls.Add(btnBone);
            Controls.Add(lblLtwo);
            Controls.Add(lblLone);
            Controls.Add(txtBtwo);
            Controls.Add(txtBone);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBone;
        private TextBox txtBtwo;
        private Label lblLone;
        private Label lblLtwo;
        private Button btnBone;
    }
}