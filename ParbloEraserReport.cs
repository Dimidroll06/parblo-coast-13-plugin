using OpenTabletDriver.Plugin.Tablet;

namespace OpenTabletDriver.Configurations.Parsers.Parblo
{
    public struct ParbloEraserReport : IEraserReport
    {
        public ParbloEraserReport(byte[] report)
        {
            Raw = report;

            Eraser = (report[3] & 0xf0) == 0x20;
        }

        public byte[] Raw { set; get; }
        public bool Eraser { set; get; }
    }
}
