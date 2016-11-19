using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hubble
{
    public partial class SettingsForm : Form
    {
        private Config conf;
        private MainForm mainForm;

        public SettingsForm(MainForm mainForm, Config conf)
        {
            this.conf = conf;
            this.mainForm = mainForm;
            InitializeComponent();
            apientry_tb.Text = conf.getCfg("apiEntry");
            deviceid_tb.Text = conf.getCfg("device_id");
            devicekey_tb.Text = conf.getCfg("device_key");
            verbose_cb.Checked = conf.getCfg("verbose").Equals("yes");
            refreshtime_num.Value = int.Parse(conf.getCfg("refreshTime"));
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            conf.writeCfg("apiEntry",apientry_tb.Text);
            int refresh = (int) Math.Round(refreshtime_num.Value);
            conf.writeCfg("refreshTime", refresh.ToString());

            if(verbose_cb.Checked)
            {
                conf.writeCfg("verbose", "yes");
            } else
            {
                conf.writeCfg("verbose", "no");
            }

            conf.writeCfg("device_id", deviceid_tb.Text);
            conf.writeCfg("device_key", devicekey_tb.Text);
            this.Close();
            mainForm.checkSettings();
        }
    }
}
