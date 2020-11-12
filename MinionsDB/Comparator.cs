using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyNodeListMinions
{
    class Minion : IComparable<Minion>
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Town { get; set; }

        public Minion(int id, string name, int age, string town)
        {
            Id = id;
            Name = name;
            Age = age;
            Town = town;
        }

        public int CompareTo(Minion third)
        {
            var result = this.Age.CompareTo(third.Age);
            if (result == 0)
                result = third.Town.CompareTo(this.Town);
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Minion first = new Minion(1, "George", 7, "Vashington");
            Minion second = new Minion(2, "Franklin", 17, "Berlin");
            Minion third = new Minion(3, "Roosevelt", 7, "Tokyo");
            Minion fourth = new Minion(4, "Donald", 27, "Moscow");

            Console.WriteLine($"{first.Id} {first.Name} {first.Age} {first.Town} vs {third.Id} {third.Name} {third.Age} {third.Town}: ");
            Console.WriteLine(first.CompareTo(third));

            Console.WriteLine($"{second.Id} {second.Name} {second.Age} {second.Town} vs {fourth.Id} {fourth.Name} {fourth.Age} {fourth.Town}: ");
            Console.WriteLine(second.CompareTo(fourth));
        }
    }
}
