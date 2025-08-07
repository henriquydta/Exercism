public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        var result = new byte[9];
        
        switch (reading)
        {
            case >= 4_294_967_296:
                result[0] = 256 - 8;
                BuildPayload(result, BitConverter.GetBytes(reading));
                break;
            case >= 2_147_483_648:
                result[0] = 4;
                BuildPayload(result, BitConverter.GetBytes((uint)reading));
                break;
            case >= 65_536:
                result[0] = 256 - 4;
                BuildPayload(result, BitConverter.GetBytes((int)reading));
                break;
            case >= 0:
                result[0] = 2;
                BuildPayload(result, BitConverter.GetBytes((ushort)reading));
                break;
            case >= -32_768:
                result[0] = 256 - 2;
                BuildPayload(result, BitConverter.GetBytes((short)reading));
                break;
            case >= -2_147_483_648:
                result[0] = 256 - 4;
                BuildPayload(result, BitConverter.GetBytes((int)reading));
                break;
            case >= -9_223_372_036_854_775_808:
                result[0] = 256 - 8;
                BuildPayload(result, BitConverter.GetBytes(reading));
                break;
        }

        return result;
    }

    public static long FromBuffer(byte[] buffer)
    {
        var type = buffer[0];

        var number = type switch
        {
            248 => BitConverter.ToInt64(buffer, 1),
            4 => BitConverter.ToUInt32(buffer, 1),
            252 => BitConverter.ToInt32(buffer, 1),
            2 => BitConverter.ToUInt16(buffer, 1),
            254 => BitConverter.ToInt16(buffer, 1),
            _ => 0
        };

        return number;
    }

    private static void BuildPayload(byte[] result, byte[] bitArray)
    {
        for (var i = 0; i < bitArray.Length; i++)
        {
            result[i + 1] = bitArray[i];
        }
    }
}
