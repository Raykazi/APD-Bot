using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APD_Bot
{
    public class AudioDevice
    {
        public AudioDevice(string name, int deviceNumber)
        {
            DeviceName = name;
            DeviceNumber = deviceNumber;
        }
        public string DeviceName { get; set; }
        public int DeviceNumber { get; set; }

        public override string ToString()
        {
            return DeviceName;
        }
    }
}
