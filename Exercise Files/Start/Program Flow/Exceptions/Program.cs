using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            int y = 0;
            int result;

            // TODO: try-catch expressions make error checking easier
            try {
                if (x > 1000) {
                    throw new ArgumentOutOfRangeException("x", "x has to be 1000 or less");
                }

                result = x / y;
                Console.WriteLine("The result is: {0}", result);
            } catch (DivideByZeroException e) {
                Console.WriteLine("Error: {0}", e.Message);
            } catch (ArgumentOutOfRangeException x) {
                Console.WriteLine("Sorry, 1000 is the limit");
                Console.WriteLine(x.Message);
            }
            catch {
                Console.WriteLine("Something went wrong");
            } finally {
                Console.WriteLine("clean up! always runs");
            }
        }
    }
}
