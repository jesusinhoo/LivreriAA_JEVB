﻿using LivreriAA_JEVB.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
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
                    context.Books.AddRange(new Book()

                    {
                        Titulo = "1st Book Title",
                        Descripcion = "1st Book Descripcion",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genero = "biography",
                        Autor = "1st Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now,
                    },
                    new Book()
                    {
                        Titulo = "2nd book Title",
                        Descripcion = "2nd book Description",
                        IsRead = true,
                        Rate = 4,
                        Genero = "biography",
                        Autor = "2nd Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now,

                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
