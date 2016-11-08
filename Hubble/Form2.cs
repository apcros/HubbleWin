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
    public partial class Form2 : Form
    {
        private Config conf;
        private Form1 mainWin;

        public Form2(Form1 f, Config c)
        {
            conf = c;
            mainWin = f;
            InitializeComponent();
            apientry_tb.Text = conf.getCfg("apiEntry");
            deviceid_tb.Text = conf.getCfg("device_id");
            securemode_cb.Checked = conf.getCfg("secureMode").Equals("yes");
            verbose_cb.Checked = conf.getCfg("verbose").Equals("yes");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            conf.writeCfg("apiEntry",apientry_tb.Text);
            int refresh = (int) Math.Round(refreshtime_num.Value);
            conf.writeCfg("refreshTime", refresh.ToString());

            if(securemode_cb.Checked)
            {
                conf.writeCfg("secureMode", "yes");
            } else
            {
                conf.writeCfg("secureMode", "no");
            }

            if(verbose_cb.Checked)
            {
                conf.writeCfg("verbose", "yes");
            } else
            {
                conf.writeCfg("verbose", "no");
            }

            conf.writeCfg("device_id", deviceid_tb.Text);
            this.Close();
            mainWin.checkSettings();
        }
    }
}
