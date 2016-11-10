namespace Hubble
{
    partial class SettingsForm
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
            this.apientry_tb = new System.Windows.Forms.TextBox();
            this.deviceid_tb = new System.Windows.Forms.TextBox();
            this.label_api = new System.Windows.Forms.Label();
            this.label_deviceid = new System.Windows.Forms.Label();
            this.securemode_cb = new System.Windows.Forms.CheckBox();
            this.verbose_cb = new System.Windows.Forms.CheckBox();
            this.refreshtime_num = new System.Windows.Forms.NumericUpDown();
            this.label_refreshtime = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.refreshtime_num)).BeginInit();
            this.SuspendLayout();
            // 
            // apientry_tb
            // 
            this.apientry_tb.Location = new System.Drawing.Point(202, 12);
            this.apientry_tb.Name = "apientry_tb";
            this.apientry_tb.Size = new System.Drawing.Size(280, 22);
            this.apientry_tb.TabIndex = 0;
            // 
            // deviceid_tb
            // 
            this.deviceid_tb.Location = new System.Drawing.Point(202, 52);
            this.deviceid_tb.Name = "deviceid_tb";
            this.deviceid_tb.Size = new System.Drawing.Size(280, 22);
            this.deviceid_tb.TabIndex = 1;
            // 
            // label_api
            // 
            this.label_api.AutoSize = true;
            this.label_api.Location = new System.Drawing.Point(15, 12);
            this.label_api.Name = "label_api";
            this.label_api.Size = new System.Drawing.Size(110, 17);
            this.label_api.TabIndex = 2;
            this.label_api.Text = "API Entry Point :";
            // 
            // label_deviceid
            // 
            this.label_deviceid.AutoSize = true;
            this.label_deviceid.Location = new System.Drawing.Point(15, 52);
            this.label_deviceid.Name = "label_deviceid";
            this.label_deviceid.Size = new System.Drawing.Size(76, 17);
            this.label_deviceid.TabIndex = 3;
            this.label_deviceid.Text = "Device ID :";
            // 
            // securemode_cb
            // 
            this.securemode_cb.AutoSize = true;
            this.securemode_cb.Location = new System.Drawing.Point(18, 140);
            this.securemode_cb.Name = "securemode_cb";
            this.securemode_cb.Size = new System.Drawing.Size(114, 21);
            this.securemode_cb.TabIndex = 4;
            this.securemode_cb.Text = "Secure mode";
            this.securemode_cb.UseVisualStyleBackColor = true;
            // 
            // verbose_cb
            // 
            this.verbose_cb.AutoSize = true;
            this.verbose_cb.Location = new System.Drawing.Point(153, 140);
            this.verbose_cb.Name = "verbose_cb";
            this.verbose_cb.Size = new System.Drawing.Size(83, 21);
            this.verbose_cb.TabIndex = 5;
            this.verbose_cb.Text = "Verbose";
            this.verbose_cb.UseVisualStyleBackColor = true;
            // 
            // refreshtime_num
            // 
            this.refreshtime_num.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.refreshtime_num.Location = new System.Drawing.Point(202, 93);
            this.refreshtime_num.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.refreshtime_num.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.refreshtime_num.Name = "refreshtime_num";
            this.refreshtime_num.Size = new System.Drawing.Size(107, 22);
            this.refreshtime_num.TabIndex = 6;
            this.refreshtime_num.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label_refreshtime
            // 
            this.label_refreshtime.AutoSize = true;
            this.label_refreshtime.Location = new System.Drawing.Point(15, 93);
            this.label_refreshtime.Name = "label_refreshtime";
            this.label_refreshtime.Size = new System.Drawing.Size(128, 17);
            this.label_refreshtime.TabIndex = 7;
            this.label_refreshtime.Text = "Refresh time (ms) :";
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(12, 215);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(465, 47);
            this.save_btn.TabIndex = 8;
            this.save_btn.Text = "Save and quit";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 274);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.label_refreshtime);
            this.Controls.Add(this.refreshtime_num);
            this.Controls.Add(this.verbose_cb);
            this.Controls.Add(this.securemode_cb);
            this.Controls.Add(this.label_deviceid);
            this.Controls.Add(this.label_api);
            this.Controls.Add(this.deviceid_tb);
            this.Controls.Add(this.apientry_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingsForm";
            this.Text = "Hubble Settings";
            ((System.ComponentModel.ISupportInitialize)(this.refreshtime_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox apientry_tb;
        private System.Windows.Forms.TextBox deviceid_tb;
        private System.Windows.Forms.Label label_api;
        private System.Windows.Forms.Label label_deviceid;
        private System.Windows.Forms.CheckBox securemode_cb;
        private System.Windows.Forms.CheckBox verbose_cb;
        private System.Windows.Forms.NumericUpDown refreshtime_num;
        private System.Windows.Forms.Label label_refreshtime;
        private System.Windows.Forms.Button save_btn;
    }
}