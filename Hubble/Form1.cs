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
    public partial class Form1 : Form
    {
        Config c;
        Thread publishingThread;
        public Form1()
        {
            InitializeComponent();
            c = new Hubble.Config();
            this.checkSettings();

        }
        public void checkSettings()
        {
            if (c.getCfg("device_id") == "" || c.getCfg("apiEntry") == "")
            {
                connect_btn.Enabled = false;
                status_label.Text = "Error : Hubble not setup";
            } else
            {
                connect_btn.Enabled = true;
                status_label.Text = "Ready to connect to " + c.getCfg("apiEntry");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 settings_window = new Form2(this,c);
            settings_window.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void connect()
        {
            InfoRunner ir = new InfoRunner(c);
            ir.run();
        }
    }
}
