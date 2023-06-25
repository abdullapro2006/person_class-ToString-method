// See https://aka.ms/new-console-template for more information

namespace programing
{

    public class Person
    {
        public string Name { get; private set; }
        public string SurName { get; private set; }
        public int Age { get; private set; }
        public string Weight { get;  private set; }
        public string Height { get;  private set; }

        public override string ToString()
        {
            return "Name:" + Name + " " + " Surname:"  + SurName + " " + "Age:" + Age + " " + " Weight:" + Weight + " " + " Height:" + Height;
        }

        public Person(string name, string surname,int age,string weight,string height)
        {
            Name = name;
            SurName = surname;
            Age = age;
            Weight = weight;
            Height = height;
        }

    }

         public class Program
    {
           public static void Main(string[] args)
        {
            Person person = new Person("Abdullah","Manafli",16,"63 kq","1.72 sm");
            Console.WriteLine(person);
        }
    }

}

   
    




