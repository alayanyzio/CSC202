namespace FinalProjFish
{
    partial class NooksCrannyFish
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
            lblNCTitle = new Label();
            lblNCInputDirect = new Label();
            txtNCFishInput = new TextBox();
            btnNCInputSubmit = new Button();
            lstNCEntries = new ListBox();
            lblNCPriceOutput = new Label();
            lblNCTotalDirect = new Label();
            btnNCTotal = new Button();
            lblNCTotalBellsOutput = new Label();
            lblNextDirect = new Label();
            btnNext = new Button();
            picNCImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picNCImage).BeginInit();
            SuspendLayout();
            // 
            // lblNCTitle
            // 
            lblNCTitle.AutoSize = true;
            lblNCTitle.Font = new Font("Comic Sans MS", 12F);
            lblNCTitle.ForeColor = Color.MidnightBlue;
            lblNCTitle.Location = new Point(12, 9);
            lblNCTitle.Name = "lblNCTitle";
            lblNCTitle.Size = new Size(197, 23);
            lblNCTitle.TabIndex = 0;
            lblNCTitle.Text = "Nook's Cranny Calculator";
            // 
            // lblNCInputDirect
            // 
            lblNCInputDirect.AutoSize = true;
            lblNCInputDirect.ForeColor = Color.MidnightBlue;
            lblNCInputDirect.Location = new Point(12, 44);
            lblNCInputDirect.Name = "lblNCInputDirect";
            lblNCInputDirect.Size = new Size(477, 15);
            lblNCInputDirect.TabIndex = 1;
            lblNCInputDirect.Text = "Directions: Enter the name of a NEW April fish. Click \"submit\" to generate its selling price.";
            // 
            // txtNCFishInput
            // 
            txtNCFishInput.Location = new Point(23, 76);
            txtNCFishInput.Name = "txtNCFishInput";
            txtNCFishInput.Size = new Size(83, 23);
            txtNCFishInput.TabIndex = 2;
            // 
            // btnNCInputSubmit
            // 
            btnNCInputSubmit.BackColor = Color.Teal;
            btnNCInputSubmit.FlatStyle = FlatStyle.Flat;
            btnNCInputSubmit.ForeColor = Color.White;
            btnNCInputSubmit.Location = new Point(134, 76);
            btnNCInputSubmit.Name = "btnNCInputSubmit";
            btnNCInputSubmit.Size = new Size(75, 23);
            btnNCInputSubmit.TabIndex = 3;
            btnNCInputSubmit.Text = "Submit";
            btnNCInputSubmit.UseVisualStyleBackColor = false;
            btnNCInputSubmit.Click += btnNCInputSubmit_Click;
            // 
            // lstNCEntries
            // 
            lstNCEntries.BackColor = Color.LemonChiffon;
            lstNCEntries.ForeColor = Color.MidnightBlue;
            lstNCEntries.FormattingEnabled = true;
            lstNCEntries.ItemHeight = 15;
            lstNCEntries.Location = new Point(511, 7);
            lstNCEntries.Name = "lstNCEntries";
            lstNCEntries.Size = new Size(280, 394);
            lstNCEntries.TabIndex = 4;
            // 
            // lblNCPriceOutput
            // 
            lblNCPriceOutput.AutoSize = true;
            lblNCPriceOutput.Font = new Font("Comic Sans MS", 11F);
            lblNCPriceOutput.ForeColor = Color.MidnightBlue;
            lblNCPriceOutput.Location = new Point(234, 75);
            lblNCPriceOutput.Name = "lblNCPriceOutput";
            lblNCPriceOutput.Size = new Size(49, 20);
            lblNCPriceOutput.TabIndex = 5;
            lblNCPriceOutput.Text = "Bells: ";
            // 
            // lblNCTotalDirect
            // 
            lblNCTotalDirect.AutoSize = true;
            lblNCTotalDirect.ForeColor = Color.MidnightBlue;
            lblNCTotalDirect.Location = new Point(23, 126);
            lblNCTotalDirect.Name = "lblNCTotalDirect";
            lblNCTotalDirect.Size = new Size(260, 15);
            lblNCTotalDirect.TabIndex = 6;
            lblNCTotalDirect.Text = "Want to find your total? Click the \"total\" button!";
            // 
            // btnNCTotal
            // 
            btnNCTotal.BackColor = Color.Teal;
            btnNCTotal.FlatStyle = FlatStyle.Flat;
            btnNCTotal.ForeColor = Color.White;
            btnNCTotal.Location = new Point(31, 157);
            btnNCTotal.Name = "btnNCTotal";
            btnNCTotal.Size = new Size(75, 23);
            btnNCTotal.TabIndex = 7;
            btnNCTotal.Text = "Total";
            btnNCTotal.UseVisualStyleBackColor = false;
            btnNCTotal.Click += btnNCTotal_Click;
            // 
            // lblNCTotalBellsOutput
            // 
            lblNCTotalBellsOutput.AutoSize = true;
            lblNCTotalBellsOutput.Font = new Font("Comic Sans MS", 11F);
            lblNCTotalBellsOutput.ForeColor = Color.MidnightBlue;
            lblNCTotalBellsOutput.Location = new Point(134, 160);
            lblNCTotalBellsOutput.Name = "lblNCTotalBellsOutput";
            lblNCTotalBellsOutput.Size = new Size(45, 20);
            lblNCTotalBellsOutput.TabIndex = 8;
            lblNCTotalBellsOutput.Text = "Bells:";
            // 
            // lblNextDirect
            // 
            lblNextDirect.AutoSize = true;
            lblNextDirect.ForeColor = Color.MidnightBlue;
            lblNextDirect.Location = new Point(511, 416);
            lblNextDirect.Name = "lblNextDirect";
            lblNextDirect.Size = new Size(175, 15);
            lblNextDirect.TabIndex = 9;
            lblNextDirect.Text = "Click \"next\" to check Cj's prices!";
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Teal;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(692, 411);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(93, 25);
            btnNext.TabIndex = 10;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // picNCImage
            // 
            picNCImage.Image = Properties.Resources.NCpng;
            picNCImage.Location = new Point(12, 249);
            picNCImage.Name = "picNCImage";
            picNCImage.Size = new Size(341, 189);
            picNCImage.SizeMode = PictureBoxSizeMode.Zoom;
            picNCImage.TabIndex = 11;
            picNCImage.TabStop = false;
            // 
            // NooksCrannyFish
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(800, 450);
            Controls.Add(picNCImage);
            Controls.Add(btnNext);
            Controls.Add(lblNextDirect);
            Controls.Add(lblNCTotalBellsOutput);
            Controls.Add(btnNCTotal);
            Controls.Add(lblNCTotalDirect);
            Controls.Add(lblNCPriceOutput);
            Controls.Add(lstNCEntries);
            Controls.Add(btnNCInputSubmit);
            Controls.Add(txtNCFishInput);
            Controls.Add(lblNCInputDirect);
            Controls.Add(lblNCTitle);
            Name = "NooksCrannyFish";
            Text = "Nook's Cranny";
            ((System.ComponentModel.ISupportInitialize)picNCImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNCTitle;
        private Label lblNCInputDirect;
        private TextBox txtNCFishInput;
        private Button btnNCInputSubmit;
        private ListBox lstNCEntries;
        private Label lblNCPriceOutput;
        private Label lblNCTotalDirect;
        private Button btnNCTotal;
        private Label lblNCTotalBellsOutput;
        private Label lblNextDirect;
        private Button btnNext;
        private PictureBox picNCImage;
    }
}
