using CsvHelper;
using CsvHelperApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvHelperApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var filename = Directory.GetCurrentDirectory() + @"\person.csv";
            List<Person> list = new List<Person>()
            {
                new Person() {Name ="Sammari", Adress="Puteaux", Age=32, Email="Maher.Sammari@gmail.com"},
                new Person() {Name ="Seaone", Adress="Paris", Age=25, Email="alexandre@gmail.com"},
                new Person() {Name ="Moutuou", Adress="Elancourt", Age=36, Email="moutuuo@gmail.com"},
                new Person() {Name ="Annia", Adress="Levalois", Age=32, Email="annia@gmail.com"},
                new Person() {Name ="Thierry", Adress="Marseille", Age=50, Email="thierry@gmail.com"}
            };

         //   WriteCsvFile(filename, list);
            ReadCsvField(filename);
            Console.ReadLine();
        }

        static void  ReadCsvField(string filename)
        {
            TextReader textReader = File.OpenText(filename);
            var csv = new CsvReader(textReader);
            csv.Configuration.Delimiter = ";";
            var people = csv.GetRecords<Person>();
            foreach(var person in people)
            {
                Console.WriteLine($"\r Nom {person.Name} \r\n Age: {person.Age} \r\n Email: {person.Email}  \r\n Adress: {person.Adress} \r\n Telephone: {person.Telephone}");
            }
            textReader.Close();

        }

        static void WriteCsvFile(string filename, IEnumerable<Person> people)
        {
            TextWriter textWriter = File.CreateText(filename);
            var csvWriter = new CsvWriter(textWriter);
            csvWriter.Configuration.Delimiter = ";";
            csvWriter.WriteRecords(people);

            textWriter.Close();
        }
        
    }
}
