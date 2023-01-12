using System;

namespace Defining
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create new object instances using the "new" operator
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 852);
            Book b2 = new Book("Grapes of Wrath", "John Steinbeck", 447);


            // TODO: Call a method on the object
            Console.WriteLine(b1.getDescription());
            Console.WriteLine(b2.getDescription());


            // TODO: try to set one of the properties -- 
            // this will result in an error
            b1.SetName("YOLO TOLO");
            b1.SetAuthor("TOLKEIN");
            b1.SetPageCount(406);
            Console.WriteLine(b1.getDescription());

        }
    }
}
