using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NSW.StarCitizen.Tools.Forms;

namespace NSW.StarCitizen.Tools
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices(s => s.AddTransient<MainForm>())
                .Build();

            Application.Run(host.Services.GetRequiredService<MainForm>());
        }
    }
}
