using System;


namespace PriceList
{
    class PriceListProject
    {
        [STAThread]
        private static void Main()
        {
            
            var GetUserInput=ShowMenu();

            switch (GetUserInput.Key)
            {
                case ConsoleKey.C:
                    MessageOutput("Waiting for Console");
                    WindowsForm.StartConsole.Main();
                    break;
                case ConsoleKey.W:
                    MessageOutput("Waiting for Windows");
                    WindowsForm.StartWindows.Main();
                    break;
                default:
                    MessageOutput("Exit");
                    break;
            }
           


        }

      

        private static void MessageOutput(string Message)
        {
            Console.Write(Message);
            System.Threading.Thread.Sleep(3000);
            
                      
        }

        private static ConsoleKeyInfo ShowMenu()
        {
            Console.SetWindowPosition(0, 0);
            Console.WriteLine("Enter Windows Mode Console (C) Windows (W)");
            var UserKeyResponse = Console.ReadKey(true);
            Console.Write("Input {0}", UserKeyResponse.Key);
            Console.Write(Environment.NewLine);
            return UserKeyResponse;
        }
    }
}
