namespace assignment9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtStaticSport = new Label();
            rbtnFootball = new RadioButton();
            rbtnHandball = new RadioButton();
            txtStaticAge = new Label();
            txtbxAge = new TextBox();
            txtStaticMembership = new Label();
            txtbxMembership = new TextBox();
            btnCalculateFee = new Button();
            txtStaticFee = new Label();
            txtFee = new Label();
            SuspendLayout();
            // 
            // txtStaticSport
            // 
            txtStaticSport.AutoSize = true;
            txtStaticSport.Location = new Point(33, 62);
            txtStaticSport.Name = "txtStaticSport";
            txtStaticSport.Size = new Size(45, 20);
            txtStaticSport.TabIndex = 0;
            txtStaticSport.Text = "Sport";
            // 
            // rbtnFootball
            // 
            rbtnFootball.AutoSize = true;
            rbtnFootball.Location = new Point(281, 58);
            rbtnFootball.Name = "rbtnFootball";
            rbtnFootball.Size = new Size(85, 24);
            rbtnFootball.TabIndex = 1;
            rbtnFootball.TabStop = true;
            rbtnFootball.Text = "Football";
            rbtnFootball.UseVisualStyleBackColor = true;
            // 
            // rbtnHandball
            // 
            rbtnHandball.AutoSize = true;
            rbtnHandball.Location = new Point(281, 101);
            rbtnHandball.Name = "rbtnHandball";
            rbtnHandball.Size = new Size(91, 24);
            rbtnHandball.TabIndex = 2;
            rbtnHandball.TabStop = true;
            rbtnHandball.Text = "Handball";
            rbtnHandball.UseVisualStyleBackColor = true;
            // 
            // txtStaticAge
            // 
            txtStaticAge.AutoSize = true;
            txtStaticAge.Location = new Point(33, 176);
            txtStaticAge.Name = "txtStaticAge";
            txtStaticAge.Size = new Size(36, 20);
            txtStaticAge.TabIndex = 3;
            txtStaticAge.Text = "Age";
            // 
            // txtbxAge
            // 
            txtbxAge.Location = new Point(273, 173);
            txtbxAge.Name = "txtbxAge";
            txtbxAge.Size = new Size(125, 27);
            txtbxAge.TabIndex = 4;
            // 
            // txtStaticMembership
            // 
            txtStaticMembership.AutoSize = true;
            txtStaticMembership.Location = new Point(33, 218);
            txtStaticMembership.Name = "txtStaticMembership";
            txtStaticMembership.Size = new Size(152, 20);
            txtStaticMembership.TabIndex = 5;
            txtStaticMembership.Text = "Membership duration";
            // 
            // txtbxMembership
            // 
            txtbxMembership.Location = new Point(273, 215);
            txtbxMembership.Name = "txtbxMembership";
            txtbxMembership.Size = new Size(125, 27);
            txtbxMembership.TabIndex = 6;
            // 
            // btnCalculateFee
            // 
            btnCalculateFee.Location = new Point(33, 276);
            btnCalculateFee.Name = "btnCalculateFee";
            btnCalculateFee.Size = new Size(365, 44);
            btnCalculateFee.TabIndex = 7;
            btnCalculateFee.Text = "Calculate Fee";
            btnCalculateFee.UseVisualStyleBackColor = true;
            btnCalculateFee.Click += btnCalculateFee_Click;
            // 
            // txtStaticFee
            // 
            txtStaticFee.AutoSize = true;
            txtStaticFee.Location = new Point(33, 353);
            txtStaticFee.Name = "txtStaticFee";
            txtStaticFee.Size = new Size(105, 20);
            txtStaticFee.TabIndex = 8;
            txtStaticFee.Text = "Fee to be paid";
            // 
            // txtFee
            // 
            txtFee.AutoSize = true;
            txtFee.Location = new Point(281, 353);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(0, 20);
            txtFee.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 438);
            Controls.Add(txtFee);
            Controls.Add(txtStaticFee);
            Controls.Add(btnCalculateFee);
            Controls.Add(txtbxMembership);
            Controls.Add(txtStaticMembership);
            Controls.Add(txtbxAge);
            Controls.Add(txtStaticAge);
            Controls.Add(rbtnHandball);
            Controls.Add(rbtnFootball);
            Controls.Add(txtStaticSport);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtStaticSport;
        private RadioButton rbtnFootball;
        private RadioButton rbtnHandball;
        private Label txtStaticAge;
        private TextBox txtbxAge;
        private Label txtStaticMembership;
        private TextBox txtbxMembership;
        private Button btnCalculateFee;
        private Label txtStaticFee;
        private Label txtFee;
    }
}