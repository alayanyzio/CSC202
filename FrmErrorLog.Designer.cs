namespace ErrorLog
{
    partial class FrmErrorLog
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
            lblDirections = new Label();
            txtAge = new TextBox();
            btnSubmit = new Button();
            lstErrorLog = new ListBox();
            SuspendLayout();
            // 
            // lblDirections
            // 
            lblDirections.AutoSize = true;
            lblDirections.Font = new Font("Verdana", 10F);
            lblDirections.Location = new Point(12, 9);
            lblDirections.Name = "lblDirections";
            lblDirections.Size = new Size(574, 17);
            lblDirections.TabIndex = 0;
            lblDirections.Text = "Enter your age in the textbox below and click submit to simulate and log errors.";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(70, 43);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Verdana", 9F);
            btnSubmit.Location = new Point(176, 42);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lstErrorLog
            // 
            lstErrorLog.FormattingEnabled = true;
            lstErrorLog.ItemHeight = 15;
            lstErrorLog.Location = new Point(21, 109);
            lstErrorLog.Name = "lstErrorLog";
            lstErrorLog.Size = new Size(732, 289);
            lstErrorLog.TabIndex = 3;
            // 
            // FrmErrorLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 450);
            Controls.Add(lstErrorLog);
            Controls.Add(btnSubmit);
            Controls.Add(txtAge);
            Controls.Add(lblDirections);
            Name = "FrmErrorLog";
            Text = "Error Log";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDirections;
        private TextBox txtAge;
        private Button btnSubmit;
        private ListBox lstErrorLog;
    }
}
