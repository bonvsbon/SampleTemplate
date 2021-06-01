using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Options;


namespace SampleTemplate.InitialAppSettings {
    public class InitialAppSettings
    {
        readonly IOptions<AppSettings> appsetting;
        public InitialAppSettings(IOptions<AppSettings> _config)
        {
            appsetting = _config;
        }
    } 
    public class AppSettings {
        public Connections ConnectionStrings { get; set; }
        
        public class Connections
        {
            public string isprod { get; set; }
            public string dev { get; set; }
            public string prod { get; set; }
        }
    }

}
