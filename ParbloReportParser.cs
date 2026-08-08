using System.Diagnostics.CodeAnalysis;
using OpenTabletDriver.Plugin.Tablet;
using OpenTabletDriver.Plugin.Attributes;

namespace OpenTabletDriver.Configurations.Parsers.Parblo
{
    [PluginName("Parblo Plugin")]
    [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    public class ParbloReportParser : IReportParser<IDeviceReport>
    {
        public IDeviceReport Parse(byte[] data)
        {

            if (data[1] == 0x00)
            {
                return new ParbloAuxReport(data);
            }

            if (data[1] == 0xC2)
            {
                return new ParbloEraserReport(data);
            }

            if ((data[1] & 0x01) != 0 || (data[1] == 0x80))
            {
                return new ParbloNoParser(data);
            }

            return new ParbloTablerReport(data);
        }
    }
}

