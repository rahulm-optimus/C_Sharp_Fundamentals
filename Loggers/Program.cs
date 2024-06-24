using Microsoft.Extensions.Logging;

namespace Loggers
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            //trivial way
            using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
            //ILogger logger = factory.CreateLogger("Program");
            ILogger logger = factory.CreateLogger<Program>();
            logger.LogInformation($"First call @ {DateTime.Now}.");

            Call();

            void Call()
            {
                string valueInsterted;
                Console.WriteLine("Enter string to log");

                do
                {
                    valueInsterted = Console.ReadLine();
                    logger.LogInformation($"Call @ {DateTime.Now} : {valueInsterted}");

                } while (valueInsterted != "quit");
            }

            try
            {
                int value = 1;

                Console.WriteLine(value/ 0);

            }
            catch (Exception e)
            {
                logger.LogWarning("warn",e);
                
            }

            //non-trivial way
            //using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
            //ILogger logger = factory.CreateLogger("Program");
            //LogStartupMessage(logger, "fun");
            //try { } catch(Exception e) { logger.LogWarning() }
            //logger.LogWarning("er")
        }

        //[LoggerMessage(Level = LogLevel.Information, Message = "Hello World! Logging is {Description}.")]
        //static partial void LogStartupMessage(ILogger logger, string description);
    }


}


