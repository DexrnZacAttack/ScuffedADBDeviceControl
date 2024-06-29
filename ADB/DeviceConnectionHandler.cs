using AdvancedSharpAdbClient.DeviceCommands;
using AdvancedSharpAdbClient.Models;
using AdvancedSharpAdbClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ADBScuffedMirroring.ADB;
    public class DeviceConnectionHandler
    {
        public static DeviceClient Connect(AdbClient client, DeviceData deviceData)
        {
            return new DeviceClient(client, deviceData);
        }
}
