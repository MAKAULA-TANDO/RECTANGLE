using System;

namespace RECTANGLE
{
    public class Rectangle
    {

        public Double Length;
        public Double Width;

        public Rectangle()
        {
            Length = 0.0;
            Width = 0.0;
        }
        public Rectangle(Double Len, Double Wid)
        {
            Length = Len;
            Width = Wid;
        }

        public void input_Attributes()
        {
            Console.WriteLine("Enter the length :");
            Length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the width :");
            Width = Convert.ToDouble(Console.ReadLine());

        }
        public Double calculate_Perimeter(Double len, Double wid)
        {
            return 2 * (len + wid);  
        }
        public Double calculate_Area(Double len, Double wid)
        {
            return len* wid;
        }


        public void output_results()
        {
            Console.WriteLine("The area of a rectangle :" + calculate_Area(Length, Width));
            Console.WriteLine("The perimeter of a rectangle :" + calculate_Perimeter(Length, Width));
            Console.ReadKey();
        }


        class Program 
        {
            static void Main(string[] args)
            {
                Rectangle Obj = new Rectangle();
                Obj.input_Attributes();
                Obj.output_results();
            }
        }
    }
}
