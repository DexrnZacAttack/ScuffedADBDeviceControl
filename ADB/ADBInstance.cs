﻿using AdvancedSharpAdbClient.DeviceCommands;
using AdvancedSharpAdbClient.Models;
using AdvancedSharpAdbClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ADBScuffedMirroring.ADB
{
    public class ADBInstance
    {
        public AdbClient client;
        public DeviceClient device;
        public DeviceData deviceData;

        public ADBInstance(AdbClient client)
        {
            this.client = client;
            this.deviceData = this.client.GetDevices().FirstOrDefault();
            if (!deviceData.IsEmpty)
                this.device = DeviceConnectionHandler.Connect(client, deviceData);
            else
                MessageBox.Show("No device found!", "No device!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}