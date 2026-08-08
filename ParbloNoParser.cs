using OpenTabletDriver.Plugin.Tablet;

namespace OpenTabletDriver.Configurations.Parsers.Parblo
{
    public struct ParbloNoParser : IDeviceReport
    {
        public ParbloNoParser(byte[] report)
        {
            Raw = report;
        }

        public byte[] Raw { set; get; }
    }
}
