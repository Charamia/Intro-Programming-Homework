using System;


namespace PrintTheASCIITable
{
    class PrintTheASCIITable
    {
        static void Main()
        {
            char beginning = (char)33;
            char end = (char)126;
            for(char i = beginning; i <= end; ++i)
            {
                Console.Write(i);
            }

        }
    }
}
 