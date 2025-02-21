namespace AdditionCalc
{
    partial class frmAddCalc
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
            lblInput1 = new Label();
            txtInput1 = new TextBox();
            lblInput2 = new Label();
            txtInput2 = new TextBox();
            bttnCalculate = new Button();
            lblOutput = new Label();
            SuspendLayout();
            // 
            // lblInput1
            // 
            lblInput1.AutoSize = true;
            lblInput1.Location = new Point(12, 42);
            lblInput1.Name = "lblInput1";
            lblInput1.Size = new Size(79, 15);
            lblInput1.TabIndex = 0;
            lblInput1.Text = "First Number:";
            // 
            // txtInput1
            // 
            txtInput1.Location = new Point(97, 39);
            txtInput1.Name = "txtInput1";
            txtInput1.Size = new Size(84, 23);
            txtInput1.TabIndex = 1;
            // 
            // lblInput2
            // 
            lblInput2.AutoSize = true;
            lblInput2.Location = new Point(12, 90);
            lblInput2.Name = "lblInput2";
            lblInput2.Size = new Size(96, 15);
            lblInput2.TabIndex = 2;
            lblInput2.Text = "Second Number:";
            // 
            // txtInput2
            // 
            txtInput2.Location = new Point(114, 82);
            txtInput2.Name = "txtInput2";
            txtInput2.Size = new Size(100, 23);
            txtInput2.TabIndex = 3;
            // 
            // bttnCalculate
            // 
            bttnCalculate.Location = new Point(68, 140);
            bttnCalculate.Name = "bttnCalculate";
            bttnCalculate.Size = new Size(75, 23);
            bttnCalculate.TabIndex = 4;
            bttnCalculate.Text = "Calculate";
            bttnCalculate.UseVisualStyleBackColor = true;
            bttnCalculate.Click += bttnCalculate_Click;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(77, 213);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(31, 15);
            lblOutput.TabIndex = 5;
            lblOutput.Text = "Sum";
            // 
            // frmAddCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblOutput);
            Controls.Add(bttnCalculate);
            Controls.Add(txtInput2);
            Controls.Add(lblInput2);
            Controls.Add(txtInput1);
            Controls.Add(lblInput1);
            Name = "frmAddCalc";
            Text = "Addition Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInput1;
        private TextBox txtInput1;
        private Label lblInput2;
        private TextBox txtInput2;
        private Button bttnCalculate;
        private Label lblOutput;
    }
}
