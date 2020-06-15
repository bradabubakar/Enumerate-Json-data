using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace opg_201910_interview.Models
{

    public class Appsettings
    {
        public Clientsetting[] ClientSettings { get; set; }
    }

    public class Clientsetting
    {
        public string ClientId { get; set; }
        public string FileDirectoryPath { get; set; }
        public string[] FileList { get; set; }
    }

    public class Logging
    {
        public Loglevel LogLevel { get; set; }
    }

    public class Loglevel
    {
        public string Default { get; set; }
        public string Microsoft { get; set; }
        public string MicrosoftHostingLifetime { get; set; }
    }

}
