using System;


namespace PriceList
{
    class PriceListProject
    {
        private static void Main()
        {
            Console.SetWindowPosition(0, 0);
            Console.WriteLine("Enter Windows Mode Console (C) Windows (W)");
            var UserKeyResponse = Console.ReadKey(true);
            Console.Write("Input {0}", UserKeyResponse.Key);
            Console.Write(Environment.NewLine);
            switch (UserKeyResponse.Key)
            {
                case ConsoleKey.C:
                   // Console.Write("Waiting for Console");
                   // System.Threading.Thread.Sleep(3000);
                   //999Console.Console999.Main();
                break;
                case ConsoleKey.W:
                    Console.Write("Waiting for Windows");
                    System.Threading.Thread.Sleep(3000);
                    PriceWindowsForm.StartWindows.Main();
                    break;
                default:
                    Console.WriteLine("Exit");
                    System.Threading.Thread.Sleep(3000);
                    break;
            }


        }
    }
}
