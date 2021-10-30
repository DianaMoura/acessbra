using AcessBrasil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcessBrasil.Data
{
    public static class DbInitializer
    {
        public static void Initialize(VeiculosContext context)
        {
            context.Database.EnsureCreated();

            // Procurando por marcas
            if (context.Marcas.Any())
            {
                return;//Retornando marcas
            }

            var marcas = new Marca[]
           {

                 new Marca {Nome="BMW"},
                 new Marca {Nome="AUDI"},
                 new Marca {Nome="CHEVROLET"},
                 new Marca {Nome="CHRYSLER"}
            };
            foreach (Marca m in marcas)
            {
                context.Marcas.Add(m);
            }
            context.SaveChanges();

            var carros = new Carro[]
                {

               new Carro{ID=1050,IDMarca=1,Modelo="BMW Z4 Roadster",Ano=int.Parse("2005-09-01"),Cor="Azul" },
               new Carro{ID=1051,IDMarca=2,Modelo="A-3 Sedan",Ano=int.Parse("2020-04-01"),Cor="Branco" },
               new Carro{ID=1052,IDMarca=3,Modelo="Cruze",Ano=int.Parse("2021-02-01"),Cor="Verde" },
               new Carro{ID=1053,IDMarca=4,Modelo="Caravan",Ano=int.Parse("2009-01-01"),Cor="Vermelho" }

                };

            foreach (Carro c in carros)
            {
                context.Carros.Add(c);
            }
            context.SaveChanges();

        }


        }
    }
