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
        Config c;
        public InfoRunner(Config c)
        {
            this.c = c;

        }

        public void run()
        {
            ApiEngine ae = new ApiEngine();
            Boolean verbose = c.getCfg("verbose").Equals("yes");
            while (true)
            {
                Console.Clear();
                string json_to_submit = ae.getJson();
                using (var client = new System.Net.WebClient())
                {
                    try
                    {
                        client.Headers[HttpRequestHeader.ContentType] = "application/json";
                        client.UploadData(c.getCfg("apiEntry") + "api/v1/devices/" + c.getCfg("device_id") + "/latest", System.Text.Encoding.UTF8.GetBytes(json_to_submit));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.StackTrace);
                    }

                }
           
                 if (verbose)
                    {
                        Console.WriteLine("Following JSON was sent for " + c.getCfg("device_id") + "\n");
                        Console.WriteLine(json_to_submit);
                    }

                System.Threading.Thread.Sleep(int.Parse(c.getCfg("refreshTime")));
            }
        }
    }
}
