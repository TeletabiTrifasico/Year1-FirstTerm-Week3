namespace assignment10
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
            txtStaticAge = new Label();
            txtbxAge = new TextBox();
            txtStaticPrice = new Label();
            txtPrice = new Label();
            btnCalculatePrice = new Button();
            SuspendLayout();
            // 
            // txtStaticAge
            // 
            txtStaticAge.AutoSize = true;
            txtStaticAge.Location = new Point(32, 32);
            txtStaticAge.Name = "txtStaticAge";
            txtStaticAge.Size = new Size(36, 20);
            txtStaticAge.TabIndex = 0;
            txtStaticAge.Text = "Age";
            // 
            // txtbxAge
            // 
            txtbxAge.Location = new Point(207, 29);
            txtbxAge.Name = "txtbxAge";
            txtbxAge.Size = new Size(125, 27);
            txtbxAge.TabIndex = 1;
            // 
            // txtStaticPrice
            // 
            txtStaticPrice.AutoSize = true;
            txtStaticPrice.Location = new Point(32, 164);
            txtStaticPrice.Name = "txtStaticPrice";
            txtStaticPrice.Size = new Size(84, 20);
            txtStaticPrice.TabIndex = 3;
            txtStaticPrice.Text = "Price Ticket";
            // 
            // txtPrice
            // 
            txtPrice.AutoSize = true;
            txtPrice.Location = new Point(282, 164);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(0, 20);
            txtPrice.TabIndex = 4;
            // 
            // btnCalculatePrice
            // 
            btnCalculatePrice.Location = new Point(32, 86);
            btnCalculatePrice.Name = "btnCalculatePrice";
            btnCalculatePrice.Size = new Size(300, 51);
            btnCalculatePrice.TabIndex = 5;
            btnCalculatePrice.Text = "Calculate Price";
            btnCalculatePrice.UseVisualStyleBackColor = true;
            btnCalculatePrice.Click += btnCalculatePrice_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 217);
            Controls.Add(btnCalculatePrice);
            Controls.Add(txtPrice);
            Controls.Add(txtStaticPrice);
            Controls.Add(txtbxAge);
            Controls.Add(txtStaticAge);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtStaticAge;
        private TextBox txtbxAge;
        private Label txtStaticPrice;
        private Label txtPrice;
        private Button btnCalculatePrice;
    }
}