using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTechSession.Env
{
    public static class EnvSettings
    {
        public static Uri envUrl
        {
            get
            {
                string key = Environment.MachineName;
                var hosts = (Hashtable)ConfigurationManager.GetSection("HostSettings");
                Hashtable ports = (Hashtable)ConfigurationManager.GetSection("PortSettings");
                Hashtable protocol = (Hashtable)ConfigurationManager.GetSection("ProtocolSettings");

                int port = 0;

                if (string.IsNullOrEmpty(ports[key].ToString()))
                {
                    switch (protocol[key].ToString().ToLower())
                    {
                        case "https":
                            port = 443;
                            break;
                        default:
                            port = 80;
                            break;
                    }
                }
                else
                {
                    port = Convert.ToInt32(ports[key]);
                }

                var builder = new UriBuilder() { Host = (string)hosts[key], Port = port };
                builder.Scheme = protocol[key].ToString().ToLower();
                return builder.Uri;
            }
        }
    }
}
