using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace seminar4._1
{
    internal class Devices
    {
        public List<IControllable> DevicesList { get; set; }

        public Devices()
        {
            DevicesList =
            [
                new Device(),
                new Device(),
                new Device(),
                new Device(),
                new Device(),
                new Device(),
                new Device(),
                new Device(),
            ];
        }

        public void TurnOnOff(Bits bits)
        {
            for (byte i = 0; i < 8; i++)
            {

                if (DevicesList[i].IsOn && !bits[i])
                {
                    DevicesList[i].Off();
                }
                else if (!DevicesList[i].IsOn && bits[i])
                {
                    DevicesList[i].On();
                }

            }
        }

        public override string ToString()
        {
            return string.Join(", ", DevicesList.Select(x => x.IsOn ? "1" : "0"));
        }
    }
}
