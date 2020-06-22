using System;
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Persistance
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if(!context.Acitivities.Any())
            {
                var activities = new List<Activity>
                {
                    new Activity
                    {
                        Titulo = "Past Activity 1",
                        Data = DateTime.Now.AddMonths(-2),
                        Descricao = "Activity 2 months ago",
                        Categoria = "drinks",
                        Cidade = "London",
                        Logradouro = "Pub",
                    },
                    new Activity
                    {
                        Titulo = "Past Activity 2",
                        Data = DateTime.Now.AddMonths(-1),
                        Descricao = "Activity 1 month ago",
                        Categoria = "culture",
                        Cidade = "Paris",
                        Logradouro = "Louvre",
                    },
                    new Activity
                    {
                        Titulo = "Future Activity 1",
                        Data = DateTime.Now.AddMonths(1),
                        Descricao = "Activity 1 month in future",
                        Categoria = "culture",
                        Cidade = "London",
                        Logradouro = "Natural History Museum",
                    },
                    new Activity
                    {
                        Titulo = "Future Activity 2",
                        Data = DateTime.Now.AddMonths(2),
                        Descricao = "Activity 2 months in future",
                        Categoria = "music",
                        Cidade = "London",
                        Logradouro = "O2 Arena",
                    },
                    new Activity
                    {
                        Titulo = "Future Activity 3",
                        Data = DateTime.Now.AddMonths(3),
                        Descricao = "Activity 3 months in future",
                        Categoria = "drinks",
                        Cidade = "London",
                        Logradouro = "Another pub",
                    },
                    new Activity
                    {
                        Titulo = "Future Activity 4",
                        Data = DateTime.Now.AddMonths(4),
                        Descricao = "Activity 4 months in future",
                        Categoria = "drinks",
                        Cidade = "London",
                        Logradouro = "Yet another pub",
                    },
                    new Activity
                    {
                        Titulo = "Future Activity 5",
                        Data = DateTime.Now.AddMonths(5),
                        Descricao = "Activity 5 months in future",
                        Categoria = "drinks",
                        Cidade = "London",
                        Logradouro = "Just another pub",
                    },
                    new Activity
                    {
                        Titulo = "Future Activity 6",
                        Data = DateTime.Now.AddMonths(6),
                        Descricao = "Activity 6 months in future",
                        Categoria = "music",
                        Cidade = "London",
                        Logradouro = "Roundhouse Camden",
                    },
                    new Activity
                    {
                        Titulo = "Future Activity 7",
                        Data = DateTime.Now.AddMonths(7),
                        Descricao = "Activity 2 months ago",
                        Categoria = "travel",
                        Cidade = "London",
                        Logradouro = "Somewhere on the Thames",
                    },
                    new Activity
                    {
                        Titulo = "Future Activity 8",
                        Data = DateTime.Now.AddMonths(8),
                        Descricao = "Activity 8 months in future",
                        Categoria = "film",
                        Cidade = "London",
                        Logradouro = "Cinema",
                    }
                };
                context.Acitivities.AddRange(activities);
                context.SaveChanges();

            }
        }
    }
}