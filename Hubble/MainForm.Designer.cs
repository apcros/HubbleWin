namespace Hubble
{
    partial class MainForm
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
            this.app_settings_btn = new System.Windows.Forms.Button();
            this.status_label = new System.Windows.Forms.Label();
            this.connect_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // app_settings_btn
            // 
            this.app_settings_btn.Location = new System.Drawing.Point(326, 139);
            this.app_settings_btn.Name = "app_settings_btn";
            this.app_settings_btn.Size = new System.Drawing.Size(120, 59);
            this.app_settings_btn.TabIndex = 0;
            this.app_settings_btn.Text = "Settings";
            this.app_settings_btn.UseVisualStyleBackColor = true;
            this.app_settings_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(12, 9);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(71, 17);
            this.status_label.TabIndex = 1;
            this.status_label.Text = "Loading...";
            this.status_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(15, 139);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(305, 59);
            this.connect_btn.TabIndex = 2;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 210);
            this.Controls.Add(this.connect_btn);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.app_settings_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Hubble";
            this.Load += new System.EventHandler(this.MainForm_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button app_settings_btn;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Button connect_btn;
    }
}