using OpenTabletDriver.Plugin.Tablet;

namespace OpenTabletDriver.Configurations.Parsers.Parblo
{
    public struct ParbloAuxReport : IAuxReport
    {
        public ParbloAuxReport(byte[] report, int auxIndex = 3)
        {
            Raw = report;

            AuxButtons =
            [
                report[auxIndex].IsBitSet(0),
                report[auxIndex].IsBitSet(1),
                report[auxIndex].IsBitSet(2),
                report[auxIndex].IsBitSet(3),
                report[auxIndex].IsBitSet(4),
                report[auxIndex].IsBitSet(5),
                report[auxIndex].IsBitSet(6),
                report[auxIndex].IsBitSet(7),
            ];

        }

        public bool[] AuxButtons { set; get; }
        public byte[] Raw { set; get; }
    }
}

