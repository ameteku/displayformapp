namespace DisplayFormApp.src
{
    partial class AutomatePullingDataForm
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
            this.aliasInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.aliasLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.pullDataButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aliasInput
            // 
            this.aliasInput.Location = new System.Drawing.Point(435, 130);
            this.aliasInput.Name = "aliasInput";
            this.aliasInput.Size = new System.Drawing.Size(176, 23);
            this.aliasInput.TabIndex = 0;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(435, 205);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(176, 23);
            this.passwordInput.TabIndex = 1;
            this.passwordInput.UseSystemPasswordChar = true;
            // 
            // aliasLabel
            // 
            this.aliasLabel.AutoSize = true;
            this.aliasLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aliasLabel.Location = new System.Drawing.Point(257, 130);
            this.aliasLabel.Name = "aliasLabel";
            this.aliasLabel.Size = new System.Drawing.Size(137, 25);
            this.aliasLabel.TabIndex = 2;
            this.aliasLabel.Text = "Microsoft Alias";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.Location = new System.Drawing.Point(257, 200);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(91, 25);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // pullDataButton
            // 
            this.pullDataButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pullDataButton.Location = new System.Drawing.Point(308, 315);
            this.pullDataButton.Name = "pullDataButton";
            this.pullDataButton.Size = new System.Drawing.Size(176, 54);
            this.pullDataButton.TabIndex = 4;
            this.pullDataButton.Text = "Pull Data";
            this.pullDataButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(476, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "In order to pull the schedules automatically the application needs an account wit" +
    "h access";
            // 
            // AutomatePullingDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pullDataButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.aliasLabel);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.aliasInput);
            this.Name = "AutomatePullingDataForm";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.AutomatePullingDataForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox aliasInput;
        private TextBox passwordInput;
        private Label aliasLabel;
        private Label passwordLabel;
        private Button pullDataButton;
        private Label label3;
    }
}