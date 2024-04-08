using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Static__Interface_2
{
    internal class Student : ICodeacademia
    {
        static int Count = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CodeEmail { get; set; }

        public Student(string name ,string surname)
        {
            Name = name;
            Surname = surname;
            Id = Count++;
            GenerateEmail();
        }
        public static bool CheckName(string name ,string surname)
        {
            return !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(surname);

        }
        public void GenerateEmail()
        {
            CodeEmail = $"{Name.ToLower()}.{Surname.ToLower()}{Id}@code.edu.az";
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Surname: {Surname}, CodeEmail: {CodeEmail}";
        }

    }
}
