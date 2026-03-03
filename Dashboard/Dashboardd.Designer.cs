namespace Dashboard
{
    partial class Dashboardd
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
            btnBone = new Button();
            btnBtwo = new Button();
            SuspendLayout();
            // 
            // btnBone
            // 
            btnBone.BackColor = SystemColors.ActiveBorder;
            btnBone.Location = new Point(169, 150);
            btnBone.Name = "btnBone";
            btnBone.Size = new Size(187, 93);
            btnBone.TabIndex = 0;
            btnBone.Text = "REGISTER  STUDENT";
            btnBone.UseVisualStyleBackColor = false;
            // 
            // btnBtwo
            // 
            btnBtwo.BackColor = SystemColors.ActiveBorder;
            btnBtwo.Location = new Point(444, 150);
            btnBtwo.Name = "btnBtwo";
            btnBtwo.Size = new Size(187, 93);
            btnBtwo.TabIndex = 1;
            btnBtwo.Text = "STUDENT LIST";
            btnBtwo.UseVisualStyleBackColor = false;
            // 
            // Dashboardd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 369);
            Controls.Add(btnBtwo);
            Controls.Add(btnBone);
            Name = "Dashboardd";
            Text = "Dashboardd";
            Load += Dashboardd_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnBone;
        private Button btnBtwo;
    }
}