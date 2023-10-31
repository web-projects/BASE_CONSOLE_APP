using Config;

namespace DesignPatterns
{
    static class Program
    {
        static async Task Main(string[] args)
        {
            SetupEnvironment.SetEnvironment();

            // ToDo: application specific content

            // wait for ESC key to exit
            await WaitForEscapeKeyPress();

            SetupEnvironment.SaveEnvironment();
        }

        static async Task WaitForEscapeKeyPress()
        {
            Console.WriteLine("\r\n\r\nPress <ESC> key to exit...");

            while (true)
            {
                ConsoleKeyInfo keyPressed = Console.ReadKey(true);

                if (keyPressed.Key == ConsoleKey.Escape)
                {
                    break;
                }

                await Task.Delay(100);
            }

            Console.WriteLine("APPLICATION EXITING ...");
            Console.WriteLine("");
        }
    }
}
