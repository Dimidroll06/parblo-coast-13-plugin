using System.Numerics;
using OpenTabletDriver.Plugin.Tablet;

namespace OpenTabletDriver.Configurations.Parsers.Parblo
{
    public struct ParbloTablerReport : ITabletReport
    {
        public ParbloTablerReport(byte[] report)
        {
            Raw = report;

            Position = new Vector2
            {
                X = (report[2] << 8) + report[3],
                Y = (report[4] << 8) + report[5],
            };
            Pressure = report[6];

            PenButtons =
            [
                (report[1] & 0xf0) == 0xe0,
                (report[1] & 0x2) == 0x2,
            ];

        }

        public byte[] Raw { set; get; }
        public Vector2 Position { set; get; }
        public uint Pressure { set; get; }
        public bool[] PenButtons { set; get; }
    }
}
