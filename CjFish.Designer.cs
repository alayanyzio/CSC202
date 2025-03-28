namespace FinalProjFish
{
    partial class CjFish
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
            lblCjTitle = new Label();
            lblCjConvertDirect = new Label();
            btnCjConvert = new Button();
            lblCjTotal = new Label();
            lblCjSubtractDirect = new Label();
            lblNCTotalInput = new Label();
            lblCjTotalInput = new Label();
            txtNCInput = new TextBox();
            txtCjInput = new TextBox();
            lstCjEntries = new ListBox();
            lblProfitOutput = new Label();
            btnCjCalculate = new Button();
            btnBack = new Button();
            lblBack = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblCjTitle
            // 
            lblCjTitle.AutoSize = true;
            lblCjTitle.Font = new Font("Comic Sans MS", 12F);
            lblCjTitle.ForeColor = Color.MidnightBlue;
            lblCjTitle.Location = new Point(12, 9);
            lblCjTitle.Name = "lblCjTitle";
            lblCjTitle.Size = new Size(119, 23);
            lblCjTitle.TabIndex = 0;
            lblCjTitle.Text = "Cj's Calculator";
            // 
            // lblCjConvertDirect
            // 
            lblCjConvertDirect.AutoSize = true;
            lblCjConvertDirect.ForeColor = Color.MidnightBlue;
            lblCjConvertDirect.Location = new Point(12, 44);
            lblCjConvertDirect.Name = "lblCjConvertDirect";
            lblCjConvertDirect.Size = new Size(464, 15);
            lblCjConvertDirect.TabIndex = 1;
            lblCjConvertDirect.Text = "Directions: Enter your Nook's Cranny Total below, then click \"convert\" to see Cj's  total.";
            // 
            // btnCjConvert
            // 
            btnCjConvert.BackColor = Color.LightGreen;
            btnCjConvert.FlatStyle = FlatStyle.Flat;
            btnCjConvert.ForeColor = Color.MidnightBlue;
            btnCjConvert.Location = new Point(217, 82);
            btnCjConvert.Name = "btnCjConvert";
            btnCjConvert.Size = new Size(75, 23);
            btnCjConvert.TabIndex = 2;
            btnCjConvert.Text = "Convert";
            btnCjConvert.UseVisualStyleBackColor = false;
            btnCjConvert.Click += btnCjConvert_Click;
            // 
            // lblCjTotal
            // 
            lblCjTotal.AutoSize = true;
            lblCjTotal.Font = new Font("Comic Sans MS", 11F);
            lblCjTotal.ForeColor = Color.MidnightBlue;
            lblCjTotal.Location = new Point(314, 85);
            lblCjTotal.Name = "lblCjTotal";
            lblCjTotal.Size = new Size(49, 20);
            lblCjTotal.TabIndex = 3;
            lblCjTotal.Text = "Bells: ";
            // 
            // lblCjSubtractDirect
            // 
            lblCjSubtractDirect.AutoSize = true;
            lblCjSubtractDirect.ForeColor = Color.MidnightBlue;
            lblCjSubtractDirect.Location = new Point(12, 146);
            lblCjSubtractDirect.Name = "lblCjSubtractDirect";
            lblCjSubtractDirect.Size = new Size(423, 15);
            lblCjSubtractDirect.TabIndex = 4;
            lblCjSubtractDirect.Text = "Directions: To see the profit difference, enter your Cj Total and click \"calculate\".";
            // 
            // lblNCTotalInput
            // 
            lblNCTotalInput.AutoSize = true;
            lblNCTotalInput.ForeColor = Color.MidnightBlue;
            lblNCTotalInput.Location = new Point(12, 85);
            lblNCTotalInput.Name = "lblNCTotalInput";
            lblNCTotalInput.Size = new Size(88, 15);
            lblNCTotalInput.TabIndex = 6;
            lblNCTotalInput.Text = "Nook's Cranny:";
            // 
            // lblCjTotalInput
            // 
            lblCjTotalInput.AutoSize = true;
            lblCjTotalInput.ForeColor = Color.MidnightBlue;
            lblCjTotalInput.Location = new Point(24, 185);
            lblCjTotalInput.Name = "lblCjTotalInput";
            lblCjTotalInput.Size = new Size(21, 15);
            lblCjTotalInput.TabIndex = 7;
            lblCjTotalInput.Text = "Cj:";
            // 
            // txtNCInput
            // 
            txtNCInput.Location = new Point(106, 82);
            txtNCInput.Name = "txtNCInput";
            txtNCInput.Size = new Size(100, 23);
            txtNCInput.TabIndex = 8;
            // 
            // txtCjInput
            // 
            txtCjInput.Location = new Point(51, 185);
            txtCjInput.Name = "txtCjInput";
            txtCjInput.Size = new Size(100, 23);
            txtCjInput.TabIndex = 9;
            // 
            // lstCjEntries
            // 
            lstCjEntries.BackColor = Color.LemonChiffon;
            lstCjEntries.ForeColor = Color.MidnightBlue;
            lstCjEntries.FormattingEnabled = true;
            lstCjEntries.ItemHeight = 15;
            lstCjEntries.Location = new Point(484, 8);
            lstCjEntries.Name = "lstCjEntries";
            lstCjEntries.Size = new Size(300, 379);
            lstCjEntries.TabIndex = 10;
            // 
            // lblProfitOutput
            // 
            lblProfitOutput.AutoSize = true;
            lblProfitOutput.Font = new Font("Comic Sans MS", 11F);
            lblProfitOutput.ForeColor = Color.MidnightBlue;
            lblProfitOutput.Location = new Point(115, 246);
            lblProfitOutput.Name = "lblProfitOutput";
            lblProfitOutput.Size = new Size(91, 20);
            lblProfitOutput.TabIndex = 11;
            lblProfitOutput.Text = "Difference:";
            // 
            // btnCjCalculate
            // 
            btnCjCalculate.BackColor = Color.LightGreen;
            btnCjCalculate.FlatStyle = FlatStyle.Flat;
            btnCjCalculate.ForeColor = Color.MidnightBlue;
            btnCjCalculate.Location = new Point(25, 243);
            btnCjCalculate.Name = "btnCjCalculate";
            btnCjCalculate.Size = new Size(75, 23);
            btnCjCalculate.TabIndex = 12;
            btnCjCalculate.Text = "Calculate";
            btnCjCalculate.UseVisualStyleBackColor = false;
            btnCjCalculate.Click += btnCjCalculate_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LightGreen;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.MidnightBlue;
            btnBack.Location = new Point(686, 404);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(99, 34);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.ForeColor = Color.MidnightBlue;
            lblBack.Location = new Point(375, 414);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(305, 15);
            lblBack.TabIndex = 14;
            lblBack.Text = "Click \"back\" to go back to the Nook's Cranny Calculator.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.C_J__NH;
            pictureBox1.Location = new Point(12, 272);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // CjFish
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(lblBack);
            Controls.Add(btnBack);
            Controls.Add(btnCjCalculate);
            Controls.Add(lblProfitOutput);
            Controls.Add(lstCjEntries);
            Controls.Add(txtCjInput);
            Controls.Add(txtNCInput);
            Controls.Add(lblCjTotalInput);
            Controls.Add(lblNCTotalInput);
            Controls.Add(lblCjSubtractDirect);
            Controls.Add(lblCjTotal);
            Controls.Add(btnCjConvert);
            Controls.Add(lblCjConvertDirect);
            Controls.Add(lblCjTitle);
            Name = "CjFish";
            Text = "CJ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCjTitle;
        private Label lblCjConvertDirect;
        private Button btnCjConvert;
        private Label lblCjTotal;
        private Label lblCjSubtractDirect;
        private Label lblNCTotalInput;
        private Label lblCjTotalInput;
        private TextBox txtNCInput;
        private TextBox txtCjInput;
        private ListBox lstCjEntries;
        private Label lblProfitOutput;
        private Button btnCjCalculate;
        private Button btnBack;
        private Label lblBack;
        private PictureBox pictureBox1;
    }
}