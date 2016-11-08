using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hubble
{
    public class Config
    {

        public void writeCfg(String key, String val)
        {


            Configuration cfmgr = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            KeyValueConfigurationCollection cc = cfmgr.AppSettings.Settings;
            cc[key].Value = val;
            cfmgr.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
        public string getCfg(String key)
        {
            String value = ConfigurationManager.AppSettings.Get(key);;
            return value+"";
        }
    }

    
}
