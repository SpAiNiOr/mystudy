using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingLanguages
{
    class Program
    {
        static void Main()
        {
            List<Language> languages = File.ReadAllLines("./languages.tsv")
              .Skip(1)
              .Select(line => Language.FromTsv(line))
              .ToList();
            //print all languages
            foreach (Language lang in languages)
            {
                //Console.WriteLine(lang.Prettify());
            }
            //use query to print out all languages
            var langs = languages.Select(lang => lang.Prettify());
            foreach (var lang in langs)
            {
                //Console.WriteLine(lang);
            }

            //find out c#
            var cSharp = languages.Where(lang => lang.Name == "C#");
            foreach (var lang in cSharp)
            {
                Console.WriteLine(lang.Prettify());
            }

            //find out all Microsoft's
            var microsofts = languages.Where(lang => lang.ChiefDeveloper.Contains("Microsoft"));
            foreach (var lang in microsofts)
            {
                Console.WriteLine(lang.Prettify());
            }

            //find languages after Lisp
            var afterLisp = languages.Where(lang => lang.Predecessors.Contains("Lisp"));
            var scripts = languages.Where(lang => lang.Name.Contains("Script"));

            int numbers = languages.Count;
            Console.WriteLine($"There are {numbers} programming languages!");

            //notice, we need to use Count() method to the Linq query .
            var langsbtw = languages.Where(lang => lang.Year >= 1995 && lang.Year <= 2005).Count();
            Console.WriteLine($"There are {langsbtw} between 1995 and 2005");

            //
            var nearMillenium = from lang in languages
                                where lang.Year >= 1999 && lang.Year <= 2001
                                select $"{lang.Name} was invented in {lang.Year}!";
            foreach (var lang in nearMillenium)
            {
                Console.WriteLine(lang);
            }

            PrettyPrintAll(afterLisp);
        }

        public static void PrettyPrintAll(IEumerable<Language> langs)
        {
            foreach (Language lang in langs)
            {
                Console.WriteLine(lang.Prettify());
            }
        }
    }
}
