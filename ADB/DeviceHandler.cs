using AdvancedSharpAdbClient.Models;
using AdvancedSharpAdbClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ADBScuffedMirroring.ADB;
public class DeviceHandler
{
    public static async Task<Image> GrabFrameBuffer(AdbClient client, DeviceData data)
    {
        // Dexrn: NOTE THIS WILL NOT CAST IF DOTNET VERSION IS 8.
        return (Image)await client.GetFrameBufferAsync(data);
    }
}
