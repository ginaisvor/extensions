using System;
using System.Collections.Generic;
using System.Linq;
namespace Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "My owesome students.";
            int wordNo= Extensions.WordCount(myString);
            int wordNoFromExt = myString.WordCountExtension();
            Console.WriteLine(wordNoFromExt);
            var now = DateTime.Now;
            Extensions.RoundToHalfHour(now);
            Console.WriteLine(now.RoundToHalfHour());
            List<Person> persons = new List<Person>();
            persons.Add(new Person()
            {
                City = "Botosani",
                Country = "Romania",
                FirstName = "Gigi",
                LastName = "Muschi"
            });

            persons.Add(new Person()
            {
                City = "Iasi",
                Country = "Romania",
                FirstName = "George",
                LastName = "Popa"
            });

            persons.Add(new Person()
            {
                City = "Vaslui",
                Country = "Italy",
                FirstName = "Gina",
                LastName = "Ionescu"
            });
            //anonymus type
            var students = new
            {
                Name = "Student1",
                Course = ".NET"
            };
            Console.WriteLine(students.Name + students.Course);

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int oddNumbers = numbers.Count(n => n % 2 == 1);
            // varianta cu LINQ
            var personInCity = persons.Where(person => person.City == "Iasi")
                .OrderBy(x => x.FirstName)
                .OrderByDescending(x => x.Country.WordCountExtension()).ToList();
            //varianta clasica
            foreach (var person in persons)
            {
                if (person.City == "Iasi")
                {
                    personInCity.Add(person);
                }
            }
            foreach (var person in personInCity)
            {
                Console.WriteLine(person);
            }
        }
    }
}
