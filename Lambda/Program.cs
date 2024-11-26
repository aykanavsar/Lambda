using Lambda;
using System.Numerics;

public class Program
{

    public static void Main(string[] args)
    {
        /*
       // (a, b) => a + b;
      // Func<int,int,int> dvide = (x,y) =>
       //{
         //  if (y == 0) throw new DivideByZeroExeption("bölen sıfır olamaz");
          // return x / y;
       //}

       //Console.WriteLine(dvide(8, 0));
       //var numbers = new List<int>() { 1,2,3,4,5,6};
      // ProcessNumbers(numbers, n => n%2 == 0);
        Add add = (a,b) => a + b;
        Console.WriteLine(add(1,2));

        Func<int, int, int> multiply = (a, b) => a + b;
        Console.WriteLine(multiply(2,5));
        Console.WriteLine("----------------");
        Action<string> print=message=> Console.WriteLine(message);
        print("Merhaba Action");
    }

    public delegate int Add(int x, int y);

    static void ProcessNumbers(List<int> numbers, Func<int, bool> filter)
    {
        foreach (var number in numbers)
        {
            if (filter(number))
            {
                Console.WriteLine(number);
            }
        }
        


        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
        var evenNumbers = from number in numbers
                          where number % 2 == 0 
                          select number;

        foreach (int number in evenNumbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine("--------------");
        
        var evenNumbers2 = numbers.Where(num => num % 2 == 0);
        foreach (int number in evenNumbers)
        {
            Console.WriteLine(number);
        }
        */

        List<int> numbers = new List<int>() { 0, -2, -1, 2, 1, 5, 3, 4 };

        var positiveNumbers = numbers.Where(num => num > 0).ToList();


        foreach (var number in positiveNumbers)
        {
            Console.WriteLine(number);
        }

        var sqaredNumbers =numbers.Select(num => num * num);

        foreach (var number in sqaredNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("-------------");

        var personList = numbers.Select(num => new Person { Id = num});

        foreach (var Person in personList)
        {
            Console.WriteLine(Person.Id);
        }

        
        Console.WriteLine("********************");
        IEnumerable<int> sortedNumbers = numbers.OrderBy(num => num);
        foreach (var number in sortedNumbers)
        {
            Console.WriteLine($"{number}");
        }


        Console.WriteLine("*********--***********");
        IEnumerable<int> sortedNumbersDesc = numbers.OrderByDescending(num => num);
        foreach (var number in sortedNumbersDesc)
        {
            Console.WriteLine($"{number}");
        }

        var personalListAsc = personList.OrderBy(person => person);

        foreach (var person in personalListAsc)
        {
            Console.WriteLine(person);
        }

        List<Person> people = new List<Person>();

        people.Add(new Person { Age = 23, Name = "Ahmet" });
        people.Add(new Person { Age = 22, Name = "Mehmet" });
        people.Add(new Person { Age = 28, Name = "Zeynep" });
        people.Add(new Person { Age = 29, Name = "Ali" });

        var sortedPeople = people.OrderBy(person => person.Age).ThenBy(person => person.Name);
        foreach (var person in sortedPeople)
        {
            Console.WriteLine($"Ad: {person.Name} Yaş {person.Age}");
        }



        List<Book> books = new List<Book>()
        {
            new Book()
            {
                Title ="Kitap ", Year = 2000,
            }
            ,new Book()
            {
                Title ="Kitap 2 ", Year = 2000,
            }
            ,new Book()
            {
                Title ="Kitap 3 ", Year = 2010,
            }

            ,new Book()
            {
                Title ="Kitap 3 ", Year = 2008,
            }
        };

        var groupedByYear = books.GroupBy(book => book.Year);

        foreach (var group in groupedByYear)
        {
            Console.WriteLine($"{group.Key}");
            foreach (var book in group)
            {
                Console.WriteLine($"{book.Title}");
            }

        }
    }
}

