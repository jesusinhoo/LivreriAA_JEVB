using LivreriAA_JEVB.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.Design.Serialization;
using System.Linq;

namespace LivreriAA_JEVB.Data
{
    public class AppDbInitialer
    {
        //Metodo que agrega datos a nuestra BD

        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope()) 
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (context.Books.Any())
                {
                    context.Books.AddRange(new Book{

                    }
                }
            }
        }
    }
}
