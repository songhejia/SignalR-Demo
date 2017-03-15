using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalR.SignalR.WX
{

    public class User
    {
        public string userId { get; set; }
        public string connectionId { get; set; }
        public List<Device> devices { get; set; }
    }

    public class Device
    {
        public string imei { get; set; }
        public string wxid { get; set; }
    }
}