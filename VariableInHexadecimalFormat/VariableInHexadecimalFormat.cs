using System;


namespace VariableInHexadecimalFormat
{
    class VariableInHexadecimalFormat
    {
        static void Main()
        {
            int digit = int.Parse("FE", System.Globalization.NumberStyles.HexNumber);
            int digit2 = 254;
            string MyHex = digit2.ToString("X");
            Console.WriteLine(digit);
            Console.WriteLine(MyHex);
        }
    }
}
