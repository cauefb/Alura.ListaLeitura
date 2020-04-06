using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Alura.ListaLeitura.App
{
    public  class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            //app.Run(LivrosParaLer);
            app.Run(Lidos);
        }
        public Task LivrosParaLer(HttpContext context)
        {
            
            var _repo = new LivroRepositorioCSV();
            return context.Response.WriteAsync( _repo.ParaLer.ToString());
        }

        public Task Lidos(HttpContext context)
        {
            var _repo = new LivroRepositorioCSV();

            return context.Response.WriteAsync(_repo.Lidos.ToString());
        }
    }
}