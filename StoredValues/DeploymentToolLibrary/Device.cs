using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace DeploymentToolLibrary
{
    public class Device
    {
        public string Hardware { get; set; }
        public int Hostname { get; set; }
        public string IPAddress { get; set; }
        public string GatewayAddress { get; set; }
        public string PinPadIP { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StagingDate { get; set; }
        public Boolean Server { get; set; }
    }
}
