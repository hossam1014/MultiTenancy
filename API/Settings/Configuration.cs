using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Settings
{
    public class Configuration
    {
        public string DBProvider { get; set; } = null!;
        public string ConnectionString { get; set; } = null!;
    }
}