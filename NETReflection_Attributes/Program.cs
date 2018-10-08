using System;
using System.Collections.Generic;

namespace NETReflection_Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reflection & Custom attributes Examples!!!");
            
            var personas = LoadPersonas();
            ReflectingCustomAtributesExample.WhoWroteExample(personas);
        }

        public static List<Person> LoadPersonas()
        {
            return new List<Person>()
            {
                new Person("Gaspar", "Acevedo Zain", "Argentina", new DateTime(1993, 1, 19)),
                new Person("Persona", "Test 01", "Brasil", new DateTime(1980, 12, 19)),
                new Person("Persona", "Test 02", "Chile", new DateTime(2010, 10, 19))
            };
        }
    }
}
