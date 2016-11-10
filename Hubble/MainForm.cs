using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hubble
{
    public partial class MainForm : Form
    {
        Config conf;
        Thread publishingThread;
        public MainForm()
        {
            InitializeComponent();
            conf = new Hubble.Config();
            this.checkSettings();

        }
        public void checkSettings()
        {
            if (conf.getCfg("device_id") == "" || conf.getCfg("apiEntry") == "")
            {
                connect_btn.Enabled = false;
                status_label.Text = "Error : Hubble not setup";
            } else
            {
                connect_btn.Enabled = true;
                status_label.Text = "Ready to connect to " + conf.getCfg("apiEntry");
            }
        }
        private void app_settings_btn_Click(object sender, EventArgs e)
        {
            SettingsForm settings_window = new SettingsForm(this, conf);
            settings_window.Show();
        }

        private void MainForm_load(object sender, EventArgs e)
        {
            this.Text = "Hubble " + conf.getCfg("app_version");
        }
        
        private void connect_btn_Click(object sender, EventArgs e)
        {
            if (publishingThread == null)
            {
                publishingThread = new Thread(new ThreadStart(connect));
                publishingThread.Start();
                connect_btn.Text = "Connected (Click to disconnect)";
                status_label.Text = "Transmitting data..";
            } else
            {
                publishingThread.Abort();
                publishingThread = null;
                connect_btn.Text = "Connect";
                status_label.Text = "Connection stopped. Ready.";
            }
        }

        private void connect()
        {
            InfoRunner ir = new InfoRunner(conf);
            ir.run();
        }
    }
}
