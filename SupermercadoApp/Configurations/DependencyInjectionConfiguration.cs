using SupermecadosApp.Domain.Interfaces.Repository;
using SupermecadosApp.Domain.Interfaces.Services;
using SupermecadosApp.Domain.Services; 
using SupermecadosApp.Infra.Data.Repositories; 

namespace SupermercadoApp.Configurations
{
    /// <summary>
    /// classe para configuração das injeções de dependencia do projeto
    /// </summary>
    public class DependencyInjectionConfiguration
    {
        public static void AddDependencyInjection(IServiceCollection services)
        {
            services.AddTransient<IProdutoService, ProdutoService>();
            services.AddTransient<IProdutosRepository, ProdutoRepository>();
            services.AddTransient<ICategoriaService, CategoriaService>();
            services.AddTransient<ICategoriaRepository, CategoriaRepository>();
        }
    }
}
