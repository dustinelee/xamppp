namespace Dashboard
{
    partial class RegisterStudent
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
            lblLone = new Label();
            lblTwo = new Label();
            lblTree = new Label();
            lblFour = new Label();
            lblFive = new Label();
            lblSix = new Label();
            txtBone = new TextBox();
            txtBtwo = new TextBox();
            txtBtree = new TextBox();
            txtBfour = new TextBox();
            txtBfive = new TextBox();
            btnBone = new Button();
            SuspendLayout();
            // 
            // lblLone
            // 
            lblLone.AutoSize = true;
            lblLone.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblLone.Location = new Point(227, 72);
            lblLone.Name = "lblLone";
            lblLone.Size = new Size(347, 28);
            lblLone.TabIndex = 0;
            lblLone.Text = "REGISTER STUDENT INFORMATION";
            // 
            // lblTwo
            // 
            lblTwo.AutoSize = true;
            lblTwo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTwo.Location = new Point(227, 141);
            lblTwo.Name = "lblTwo";
            lblTwo.Size = new Size(67, 15);
            lblTwo.TabIndex = 1;
            lblTwo.Text = "FirstName:";
            // 
            // lblTree
            // 
            lblTree.AutoSize = true;
            lblTree.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTree.Location = new Point(227, 183);
            lblTree.Name = "lblTree";
            lblTree.Size = new Size(65, 15);
            lblTree.TabIndex = 2;
            lblTree.Text = "LastName:";
            // 
            // lblFour
            // 
            lblFour.AutoSize = true;
            lblFour.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFour.Location = new Point(227, 219);
            lblFour.Name = "lblFour";
            lblFour.Size = new Size(48, 15);
            lblFour.TabIndex = 3;
            lblFour.Text = "Course:";
            // 
            // lblFive
            // 
            lblFive.AutoSize = true;
            lblFive.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFive.Location = new Point(227, 254);
            lblFive.Name = "lblFive";
            lblFive.Size = new Size(52, 15);
            lblFive.TabIndex = 4;
            lblFive.Text = "Section:";
            // 
            // lblSix
            // 
            lblSix.AutoSize = true;
            lblSix.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSix.Location = new Point(227, 290);
            lblSix.Name = "lblSix";
            lblSix.Size = new Size(32, 15);
            lblSix.TabIndex = 5;
            lblSix.Text = "Age:";
            // 
            // txtBone
            // 
            txtBone.Location = new Point(325, 141);
            txtBone.Name = "txtBone";
            txtBone.Size = new Size(184, 23);
            txtBone.TabIndex = 6;
            // 
            // txtBtwo
            // 
            txtBtwo.Location = new Point(325, 183);
            txtBtwo.Name = "txtBtwo";
            txtBtwo.Size = new Size(184, 23);
            txtBtwo.TabIndex = 7;
            // 
            // txtBtree
            // 
            txtBtree.Location = new Point(325, 219);
            txtBtree.Name = "txtBtree";
            txtBtree.Size = new Size(184, 23);
            txtBtree.TabIndex = 8;
            // 
            // txtBfour
            // 
            txtBfour.Location = new Point(325, 254);
            txtBfour.Name = "txtBfour";
            txtBfour.Size = new Size(184, 23);
            txtBfour.TabIndex = 9;
            // 
            // txtBfive
            // 
            txtBfive.Location = new Point(325, 290);
            txtBfive.Name = "txtBfive";
            txtBfive.Size = new Size(184, 23);
            txtBfive.TabIndex = 10;
            // 
            // btnBone
            // 
            btnBone.BackColor = SystemColors.ActiveBorder;
            btnBone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBone.Location = new Point(342, 335);
            btnBone.Name = "btnBone";
            btnBone.Size = new Size(148, 23);
            btnBone.TabIndex = 11;
            btnBone.Text = "SAVE RECORD";
            btnBone.UseVisualStyleBackColor = false;
            // 
            // RegisterStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBone);
            Controls.Add(txtBfive);
            Controls.Add(txtBfour);
            Controls.Add(txtBtree);
            Controls.Add(txtBtwo);
            Controls.Add(txtBone);
            Controls.Add(lblSix);
            Controls.Add(lblFive);
            Controls.Add(lblFour);
            Controls.Add(lblTree);
            Controls.Add(lblTwo);
            Controls.Add(lblLone);
            Name = "RegisterStudent";
            Text = "RegisterStudent";
            Load += RegisterStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLone;
        private Label lblTwo;
        private Label lblTree;
        private Label lblFour;
        private Label lblFive;
        private Label lblSix;
        private TextBox txtBone;
        private TextBox txtBtwo;
        private TextBox txtBtree;
        private TextBox txtBfour;
        private TextBox txtBfive;
        private Button btnBone;
    }
}