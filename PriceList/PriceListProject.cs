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
                    SwitchVariant("Waiting for Console");
                    break;
                case ConsoleKey.W:
                    SwitchVariant("Waiting for Windows");
                    break;
                default:
                    SwitchVariant("Exit");
                    break;
            }
           


        }

      

        private static void SwitchVariant(string Message)
        {
            Console.Write(Message);
            System.Threading.Thread.Sleep(3000);
            ConsoleForm.StartConsole.Main();
        }
    }
}
