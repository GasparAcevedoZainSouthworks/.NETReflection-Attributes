using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NETReflection_Attributes.myCustomAttributes;

namespace NETReflection_Attributes
{
    public class ReflectingCustomAtributesExample
    {
        public static void WhoWroteExample(List<Person> personas)
        {
            Type personType = typeof(Person);

            WhoWrote whoWrote = GetCustomAttribute<WhoWrote>(personType);
            if(whoWrote != null && whoWrote is WhoWrote)
            {
                Console.WriteLine(string.Format("Class Person:\n\tWritten by {0}.\n\tVersion {1}", whoWrote.usrName, whoWrote.version));
            }

            PropertyInfo[] props = personType.GetProperties();

            Console.WriteLine("Custom attributes of class Person's properties");
            foreach(PropertyInfo property in props)
            {
                whoWrote = GetCustomAttribute<WhoWrote>(property);
                
                if(whoWrote != null && whoWrote is WhoWrote)
                {
                    Console.WriteLine(string.Format("Attribute {0}:\n\tWritten by {1}.\n\tVersion {2}", property.Name, whoWrote.usrName, whoWrote.version));
                }
            }

            Console.WriteLine("The End!!!");
        }

        public static T GetCustomAttribute<T>(Type objType) where T : Attribute
        {
            Attribute attr = Attribute.GetCustomAttribute(objType, typeof(T));
            return attr == null ? default(T) : (T) attr;
        }

        public static T GetCustomAttribute<T>(PropertyInfo prop) where T : Attribute
        {
            Attribute attr = prop.GetCustomAttribute(typeof(T));
            return attr == null ? default(T) : (T) attr;
        }
    }
}