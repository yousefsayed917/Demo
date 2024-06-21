namespace Demo
{
    //Class -- Struct -- Enum -- Interface
    internal class Program
    {
        //void test()
        //{

        //}
        static void Main(string[] args)//start point of the project
        {
            #region Session 02
            #region 1
            //Console.WriteLine("hello Joo ");
            //Console.ReadLine();
            //   single line comment 
            /*           
                multi 
            line 
            comment      
            */
            #endregion
            #region Namming Convention
            // camel case ===> yousefSayed
            // pascal Case ===> YousefSayed
            // Kebab case ===> Yousef_sayed
            #endregion
            #region value type
            //int x; // Allocate unintialized 4 byte in stack
            //x = 7;
            //Int32 y = 17;
            //y = x;
            //x++;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            #endregion
            #region Reference type
            //Point p1; 
            //// Allocate 4 byte in stack
            //// Zero byte in heap
            //p1 = new Point(); 
            //// Allocate required byte for object of point at heap
            //// intialized allocated bytes of object
            //// call user defind constructor if exist
            //// Assigned reference (p1) to the allocated opject
            //Point p2 = new Point();
            //p2 = p1;
            //p1.x = 7;
            //Console.WriteLine(p2.x);
            #endregion
            #region object
            // Point p1 = new Point();
            //Point p2 = new Point();
            // Console.WriteLine(p1.ToString());
            // Console.WriteLine(p1.GetHashCode());
            //Console.WriteLine(p2.Equals(p1));
            // Console.WriteLine(p1.GetType());
            //p1 = p2;
            //Console.WriteLine(p2.Equals(p1));

            //object x;
            //x = new string("Ahmed");
            //x = "Ahmed";             // syntax sugar
            //x = 'A';
            //x = 3;
            //x = 3.7;
            //x = new DateTime();
            //x = new DateOnly();
            //x = new TimeOnly();

            //object x1 = new Object();
            //object x2 = new Object();

            //Console.WriteLine(x1.GetHashCode());
            //Console.WriteLine(x2.GetHashCode());

            //x1 = x2;
            //Console.WriteLine("\nAfter Equal\n");

            //Console.WriteLine(x1.GetHashCode());
            //Console.WriteLine(x2.GetHashCode());
            #endregion
            #region casting
            // Parse Method
            //Console.WriteLine("Enter your name\n");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Hi, {name}!\n");
            //Console.WriteLine("Enter your age\n");
            //int age = int.Parse(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine("Your name: " + name +"\n");
            //Console.WriteLine("Your age: " + age + "\n");

            // Convert class

            //Console.WriteLine("Enter your name\n");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Hi, {name}!\n");
            //Console.WriteLine("Enter your age\n");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine("Your name: " + name + "\n");
            //Console.WriteLine("Your age: " + age + "\n");

            // Convert disadvatdes

            //string x = "Nourhan";
            //bool flag = Convert.ToBoolean(x);
            //Console.WriteLine(flag);    // Exception

            #endregion
            #endregion
        }
    }
}