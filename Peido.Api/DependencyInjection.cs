using Microsoft.Extensions.DependencyInjection;
using Pedido.Interface.Repositories;
using Pedido.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pedido.Api
{
    public class DependencyInjection
    {
        public static void Register(IServiceCollection serviceProvider)
        {
            RepositoryDependence(serviceProvider);
        }

        private static void RepositoryDependence(IServiceCollection serviceProvider)
        {
            serviceProvider.AddScoped<IProdutoRepository, ProdutoRepository>();
        }
    }
}
