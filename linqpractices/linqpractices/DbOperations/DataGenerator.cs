using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqpractices.DbOperations
{
    internal class DataGenerator
    {
        public static void Initialize() 
        {
            using var context = new LinqDbContext();
            if (context.Students.Any())
            { return; }
            context.Students.AddRange(
                new Entities.Student { Name = "Furkan", Surname = "Tozluyurt", ClassId = 1 },
                new Entities.Student { Name = "Ali", Surname = "Kaya", ClassId = 1 },
                new Entities.Student { Name = "Kaplan", Surname = "Aslan", ClassId = 1 },
                new Entities.Student { Name = "Ali", Surname = "Kaptan", ClassId = 1 },
                new Entities.Student { Name = "Binnur", Surname = "Ustaoğlu", ClassId = 2 },
                new Entities.Student { Name = "Nurcan", Surname = "Çivici", ClassId = 2},
                new Entities.Student { Name = "Melisa", Surname = "Tozluyurt", ClassId = 2 },
                new Entities.Student { Name = "Memedali", Surname = "Akdoğan", ClassId = 2 },
                new Entities.Student { Name = "Attila", Surname = "İlhan", ClassId = 3},
                new Entities.Student { Name = "Mustafa", Surname = "Kemal", ClassId = 3},
                new Entities.Student { Name = "İsmet", Surname = "İnönü", ClassId = 3 },
                new Entities.Student { Name = "Kazım", Surname = "Karabekir", ClassId = 3 });
            context.SaveChanges();

        }
    }
}
