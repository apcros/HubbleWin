using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Hubble
{
    public class InfoRunner
    {
        Config conf;
        public InfoRunner(Config conf)
        {
            this.conf = conf;

        }

        public void run()
        {
            ApiEngine ae = new ApiEngine(conf);
            Boolean verbose = conf.getCfg("verbose").Equals("yes");
            while (true)
            {
                Console.Clear();
                string json_to_submit = ae.getJson();
                using (var client = new System.Net.WebClient())
                {
                    try
                    {
                        client.Headers[HttpRequestHeader.ContentType] = "application/json";
                        client.Headers.Add("HUBBLE-DEVICE-KEY", conf.getCfg("device_key"));
                        client.UploadData(conf.getCfg("apiEntry") + "api/v1/devices/" + conf.getCfg("device_id") + "/latest", System.Text.Encoding.UTF8.GetBytes(json_to_submit));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.StackTrace);
                    }

                }
           
                 if (verbose)
                    {
                        Console.WriteLine("Following JSON was sent for " + conf.getCfg("device_id") + "\n");
                        Console.WriteLine(json_to_submit);
                    }

                System.Threading.Thread.Sleep(int.Parse(conf.getCfg("refreshTime")));
            }
        }
    }
}
