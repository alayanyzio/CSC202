namespace Catapult2
{
    partial class frmCatapult
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
            lblTitle = new Label();
            lblInstructions = new Label();
            lblInput = new Label();
            txtInput = new TextBox();
            lblResults = new Label();
            btnTest = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Garamond", 20F);
            lblTitle.Location = new Point(273, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(206, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Catapult Launcher";
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Font = new Font("Segoe UI", 10F);
            lblInstructions.Location = new Point(66, 72);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(630, 19);
            lblInstructions.TabIndex = 1;
            lblInstructions.Text = "Instructions: Enter a number 1-10 below to launch the catapult. After entering, click the \"Test\" button.";
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Font = new Font("Garamond", 12F);
            lblInput.Location = new Point(273, 133);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(64, 18);
            lblInput.TabIndex = 2;
            lblInput.Text = "Number:";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(343, 128);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 23);
            txtInput.TabIndex = 3;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Garamond", 12F);
            lblResults.Location = new Point(23, 259);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(62, 18);
            lblResults.TabIndex = 4;
            lblResults.Text = "Results: ";
            // 
            // btnTest
            // 
            btnTest.BackColor = Color.DarkSeaGreen;
            btnTest.FlatStyle = FlatStyle.Flat;
            btnTest.Font = new Font("Garamond", 12F);
            btnTest.Location = new Point(310, 173);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(103, 30);
            btnTest.TabIndex = 5;
            btnTest.Text = "Test";
            btnTest.UseVisualStyleBackColor = false;
            btnTest.Click += btnTest_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.DarkSeaGreen;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Garamond", 12F);
            btnReset.Location = new Point(310, 392);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(118, 30);
            btnReset.TabIndex = 6;
            btnReset.Text = "Try Again?";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click_1;
            // 
            // frmCatapult
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(btnTest);
            Controls.Add(lblResults);
            Controls.Add(txtInput);
            Controls.Add(lblInput);
            Controls.Add(lblInstructions);
            Controls.Add(lblTitle);
            Name = "frmCatapult";
            Text = "Catapult Launch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblInstructions;
        private Label lblInput;
        private TextBox txtInput;
        private Label lblResults;
        private Button btnTest;
        private Button btnReset;
    }
}
