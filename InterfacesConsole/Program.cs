using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRun> run = new List<IRun>();
            Person person = new Person();
            Animal animal = new Animal();

            run.Add(person);
            run.Add(animal);

            foreach (IRun element in run)
            {
                //call method
                element.StartRunning();

                //use props
                person.Running = "Human run prop";
                animal.Running = "Animal run prop";
                Console.WriteLine(element.Running);
            }

            Console.ReadLine();
        }
    }
    public interface IRun
    {
        string Running { get; set; }
        void StartRunning();
    }
    public class Person : IRun
    {
        public string Running { get; set; }

        public void StartRunning()
        {
            Console.WriteLine("Human running");
        }
    }
    public class Animal : IRun
    {
        public string Running { get; set; }

        public void StartRunning()
        {
            Console.WriteLine("Animal running");
        }
    }
}
