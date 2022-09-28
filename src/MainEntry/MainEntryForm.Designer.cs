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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainEntryForm));
            this.scheduleOption1Button = new System.Windows.Forms.Button();
            this.scheduleOption2Button = new System.Windows.Forms.Button();
            this.MainHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scheduleOption1Button
            // 
            this.scheduleOption1Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.scheduleOption1Button.Location = new System.Drawing.Point(64, 142);
            this.scheduleOption1Button.Name = "scheduleOption1Button";
            this.scheduleOption1Button.Size = new System.Drawing.Size(103, 58);
            this.scheduleOption1Button.TabIndex = 0;
            this.scheduleOption1Button.Text = "Pull From SharePoint";
            this.scheduleOption1Button.UseVisualStyleBackColor = true;
            this.scheduleOption1Button.Click += new System.EventHandler(this.scheduleOption1Button_Click);

            // 
            // scheduleOption2Button
            // 
            this.scheduleOption2Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.scheduleOption2Button.Location = new System.Drawing.Point(304, 142);
            this.scheduleOption2Button.Name = "scheduleOption2Button";
            this.scheduleOption2Button.Size = new System.Drawing.Size(103, 58);
            this.scheduleOption2Button.TabIndex = 1;
            this.scheduleOption2Button.Text = "Local Upload";
            this.scheduleOption2Button.UseVisualStyleBackColor = true;
            this.scheduleOption2Button.Click += new System.EventHandler(this.scheduleOption2Button_Click);
            // 
            // MainHeader
            // 
            this.MainHeader.AutoSize = true;
            this.MainHeader.BackColor = System.Drawing.Color.Transparent;
            this.MainHeader.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainHeader.ForeColor = System.Drawing.Color.Black;
            this.MainHeader.Location = new System.Drawing.Point(64, 9);
            this.MainHeader.Name = "MainHeader";
            this.MainHeader.Size = new System.Drawing.Size(365, 46);
            this.MainHeader.TabIndex = 2;
            this.MainHeader.Text = "CBA Schedule Display";
            this.MainHeader.Click += new System.EventHandler(this.MainHeader_Click);
            // 
            // MainEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(474, 262);
            this.Controls.Add(this.MainHeader);
            this.Controls.Add(this.scheduleOption2Button);
            this.Controls.Add(this.scheduleOption1Button);
            this.Name = "MainEntryForm";
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
