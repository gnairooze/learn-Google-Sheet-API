using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace learn_api_www
{
    public class SettingsHelper
    {
        private const string CLIENT_SECRET_SETTINGS_FILE = "bin\\client_secret.config";
        public string GetValue(string rootPath, string key)
        {
            //rootPath = Request.PhysicalApplicationPath
            string configfile = rootPath + CLIENT_SECRET_SETTINGS_FILE;
            ExeConfigurationFileMap configMap = new ExeConfigurationFileMap() { ExeConfigFilename = configfile };
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None);

            string strKeyValue = config.AppSettings.Settings[key].Value;

            return strKeyValue;
        }
    }
}