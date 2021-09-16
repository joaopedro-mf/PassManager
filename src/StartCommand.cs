using McMaster.Extensions.CommandLineUtils;
using System.Threading.Tasks;

namespace PassManager
{
    [Command(Name = "start", Description = "Start Application")]
    class StartCommand
    {
        private async Task OnExecute(IConsole console)
        {
            await Task.CompletedTask;
            console.WriteLine($"Current Time");
        }
    }
}
