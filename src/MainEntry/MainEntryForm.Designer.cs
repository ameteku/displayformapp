namespace DisplayFormApp.MainEntry
{
    partial class MainEntryForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.scheduleOption1Button = new System.Windows.Forms.Button();
            this.scheduleOption2Button = new System.Windows.Forms.Button();
            this.MainHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.scheduleOption1Button.Location = new System.Drawing.Point(76, 220);
            this.scheduleOption1Button.Name = "button1";
            this.scheduleOption1Button.Size = new System.Drawing.Size(103, 58);
            this.scheduleOption1Button.TabIndex = 0;
            this.scheduleOption1Button.Text = "Automate";
            this.scheduleOption1Button.UseVisualStyleBackColor = true;
            this.scheduleOption1Button.Click += onAutomateButtonClick;
            // 
            // button2
            // 
            this.scheduleOption2Button.Location = new System.Drawing.Point(370, 220);
            this.scheduleOption2Button.Name = "button2";
            this.scheduleOption2Button.Size = new System.Drawing.Size(103, 58);
            this.scheduleOption2Button.TabIndex = 1;
            this.scheduleOption2Button.Text = "Upload Schedule";
            this.scheduleOption2Button.UseVisualStyleBackColor = true;
            this.scheduleOption2Button.Click += onManualButtonClick;
            // 
            // label1
            // 
            this.MainHeader.AutoSize = true;
            this.MainHeader.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainHeader.Location = new System.Drawing.Point(178, 134);
            this.MainHeader.Name = "label1";
            this.MainHeader.Size = new System.Drawing.Size(236, 31);
            this.MainHeader.TabIndex = 2;
            this.MainHeader.Text = "CBA Schedule Display";
            // 
            // MainEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainHeader);
            this.Controls.Add(this.scheduleOption2Button);
            this.Controls.Add(this.scheduleOption1Button);
            this.Name = "MainEntryForm";
            this.Size = new System.Drawing.Size(586, 340);
            this.Load += new System.EventHandler(this.MainEntryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button scheduleOption1Button;
        private Button scheduleOption2Button;
        private Label MainHeader;
    }
}
