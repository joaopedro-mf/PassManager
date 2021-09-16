using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.Hosting;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace PassManager
{
    [Command( Description = "Pass Manager Application")]
    [HelpOption]
    [Subcommand(typeof(StartCommand)) ]
    class Program
    {
        private static async Task Main(string[] args)
        {
            await CreateHostBuilder().
                RunCommandLineApplicationAsync<Program>(args) ;
        }
         

        public static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder();
        }


        private void OnExecute(CommandLineApplication app, IConsole console)
        {
            var assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version;

            Console.WriteLine($" ########## Pass Manager v{assemblyVersion} ##########");
            Console.WriteLine($" *  To execute application, use in prompt  ./PassManager.exe start ");
        }
    }


    
}
