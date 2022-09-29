using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _Net_Core__ASP.Net_.Business;
using _Net_Core__ASP.Net_.Repository;

namespace _Net_Core__ASP.Net_
{
    class Program
    {
        static void Main(string[] args)
        {
            var _repo = new LivroRepositorioCSV();

            IWebHost host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();
            host.Run();
        }

        static void ImprimeLista(ListaDeLeitura lista)
        {
            Console.WriteLine(lista);
        }
    }
}