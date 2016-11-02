using System;


namespace ModifyBit
{
    class Stratup
    {
        static void Main()
        {
            ulong numberN = ulong.Parse(Console.ReadLine());
            byte positionP = byte.Parse(Console.ReadLine());
            ulong v = ulong.Parse(Console.ReadLine());
            
            
          
            Console.WriteLine(numberN & ~(1u << positionP) | (v << positionP));
        }
    }
}
