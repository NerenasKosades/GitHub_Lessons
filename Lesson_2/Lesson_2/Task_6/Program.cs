using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int officeOneMask = 0b1111100;
            int officeTwoMask = 0b0111110;
            int officeThreeMask = 0b0011111;
            int officeFourMask = 0b1001111;
            int officeFiveMask = 0b1100111;

            int officeMain = 0b1001111;

            Console.WriteLine(officeMain == officeOneMask);
            Console.WriteLine(officeMain == officeTwoMask);
            Console.WriteLine(officeMain == officeThreeMask);
            Console.WriteLine(officeMain == officeFourMask);
            Console.WriteLine(officeMain == officeFiveMask);
        }
    }
}
