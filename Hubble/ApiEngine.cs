using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
namespace Hubble
{
 
  class ApiEngine
    {
        SystemInfoEngine sie;
        Config conf;
        public ApiEngine(Config conf)
        {
            sie = new SystemInfoEngine();
            this.conf = conf;
        }

        public string getJson()
        {
            
            List<Drive> drives = sie.getDrivesInfo();
            HubbleJSON data = new HubbleJSON(drives.Count);
            data.name = sie.getName();
            data.os_version = sie.getOS();
            data.ram_free = sie.getFreeRam();
            data.ram_total = sie.getTotalRam();
            data.cpu_usage = sie.getCpuUsage();
            data.client_version = conf.getCfg("app_version");
            
            int i = 0;
            foreach(Drive drive in drives)
            {
                data.drives[i] = drive;
                i++;
            }
            JavaScriptSerializer jss = new JavaScriptSerializer();
                return jss.Serialize(data);
        }
    }

    class HubbleJSON
    {
        public string name;
        public string os_version;
        public string client_version;
        public string ram_total;
        public string ram_free;
        public string cpu_usage;
        public Drive[] drives;
        public HubbleJSON (int sizeDrives) {
                drives = new Drive[sizeDrives];
            }
    }
}
