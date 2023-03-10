

namespace propertiesofatriangle
{
    class Program
    {
       
        static void Main(string[]args)
        {
            //inputing the three points in a triangle from the user
            Console.WriteLine(" Input the coordinates of 3 points in 2-dimensional coordinate system;");

            Console.Write("Point  A (x,y): ");
            string[] aCoords = Console.ReadLine().Split(',');
            double aX = double.Parse(aCoords[0]);
            double aY = double.Parse(aCoords[1]);

            Console.Write("Point B (x,y): ");
            string[] bCoords = Console.ReadLine().Split(',');
            double bX = double.Parse(bCoords[0]);
            double bY = double.Parse(bCoords[1]);


            Console.Write("Point C (x,y): ");
            string[] cCoords = Console.ReadLine().Split(',');
            double cX = double.Parse(cCoords[0]);

            double cY = double.Parse(cCoords[1]);

            //ength f the sides calcuation
            double AB = Math.Round(Math.Sqrt(Math.Pow(bX -  aX, 2) + Math.Pow(bY - aY, 2)), 2);
            double BC = Math.Round(Math.Sqrt(Math.Pow(cX -  bX, 2) + Math.Pow(cY - bY, 2)), 2);
            double AC = Math.Round(Math.Sqrt(Math.Pow(cX -  aX, 2) + Math.Pow(cY - aY, 2)), 2);

            // Print the lengths of the sides of the triangle
            Console.WriteLine($"AB = {AB}, BC= {BC}, AC= {AC}");

            // Determining type of the triangle
            bool isEquilateral = AB == BC && BC == AC;
            bool isIsosceles = AB == BC || BC == AC || AC == AB;
            bool isRight = Math.Pow(BC, 2) - (Math.Pow(AB, 2) + Math.Pow(AC, 2))  <=0.0001;

            if (isEquilateral)
            {
                Console.WriteLine("This is an Equilateral triangle.");
            }
            else if (isIsosceles)
            {
               Console.WriteLine("This is an Isosceles triangle.");
            }
            else
            {
                 Console.WriteLine("This is a Scalene triangle.");
            }

            if (isRight)
            {
               Console.WriteLine("This is a Right triangle.");
            }

            // Calculating perimeter of the triangle
            double perimeter = Math.Round(AB + BC + AC, 2);



            // Print perimeter of the triangle
            Console.WriteLine($"perimeter of the triangle is {perimeter}");

            // Print even numbers from 0 to the perimeter
            Console.Write($"Even numbers from 0 to the perimeter ({perimeter}) are: ");
            for (int i=0; i<= perimeter; i+=2)
           
            {

                Console.Write(i + ", ");
            }

            // Waiting to press a key before closing the program
            Console.ReadKey();
        }
    }
}

