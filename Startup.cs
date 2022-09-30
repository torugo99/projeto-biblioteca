using _Net_Core__ASP.Net_.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace _Net_Core__ASP.Net_
{
    public class Startup
    {
        public void configure(IApplicationBuilder app)
        {
            app.Run(Roteamento);
        }

        public Task Roteamento(HttpContext context)
        {   
            var _repo = new LivroRepositorioCSV();
            var caminhoAtendidos = new Dictionary<string, string>
            {
                { "/Livros/Paraler", _repo.ParaLer.ToString() },
                { "/Livros/Lendo", _repo.Lendo.ToString() },
                { "/Livros/Lidos", _repo.Lidos.ToString() },
            };

            if (caminhoAtendidos.ContainsKey(context.Request.Path))
            {
                return context.Response.WriteAsync(caminhoAtendidos[context.Request.Path]);
            }
            context.Response.StatusCode = 404;
            return context.Response.WriteAsync("Caminho Inexistence.");
        }

        public Task LivrosParaLer(HttpContext context)
        { 
            var _repo = new LivroRepositorioCSV();
            return context.Response.WriteAsync(_repo.ParaLer.ToString());
        }
    }
}