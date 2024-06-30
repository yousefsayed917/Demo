using System.Linq.Expressions;
using System.Text;

namespace Demo
{
    //Class -- Struct -- Enum -- Interface
    internal class Program
    {
        #region functions Session 04
        public  static void print(string pattern ="#",int count=7)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(pattern);
            }
        }
        public static void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static int SumArr(ref int[] arr)
        {
            int sum = 0;
            //arr[0] = 100;
            arr = new int[] { 4, 5, 6 };
            if (arr != null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
        #endregion
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

            //string x = "yousef";
            //bool flag = Convert.ToBoolean(x);
            //Console.WriteLine(flag);    // Exception

            #endregion
            #endregion
            #region Session 03
            #region Part 1
            #region fractions and discard
            ////defualt data type of fractions is double
            //float x = 2.4f;
            //decimal y = 2.5m;
            ////discard => for readability
            //long num = 100_000_000_000;
            //Console.WriteLine(num);
            #endregion
            #region implicit casting and explicit casting (value type)
            ////implicit casting save cating 
            //int x = 10;
            //long y = x; 
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //int z = 3;
            //double d = z;
            //Console.WriteLine(z);
            //Console.WriteLine(d);
            ////explicit casting un save casting
            //long a = 100000000;//over flow
            //checked
            //{
            //    int b = (int)a;
            //    unchecked
            //    {
            //        Console.WriteLine(y);
            //    }
            //}
            //Console.WriteLine(x);

            //double c = 3.5;
            //int e = (int)c; //loss of data 
            //Console.WriteLine(c);
            //Console.WriteLine(e);
            #endregion
            #region operators
            #region unary
            ////work on one operand
            //int x = 5;
            ////prefix (increment or decrement then print)
            //++x;
            //--x;
            ////postfix (print then increment or decrement)
            //x++;
            //x--;
            #endregion
            #region binary
            ////work on two operands
            //int Sum, Mul, Div, Sub, Mod;
            //int x = 4, y=3;
            //Sum = x + y;
            //Mul = x * y;
            //Div = x / y;
            //Sub = x - y;
            //Mod = x % y;
            //Console.WriteLine(Sum);
            //Console.WriteLine(Mul);
            //Console.WriteLine(Div); 
            //Console.WriteLine(Sub);
            //Console.WriteLine(Mod);

            #endregion
            #region assignment
            //int x = 7;
            //x += 3;//x=x+3
            //x -= 3;//x=x-3
            //x *= 3;//x=x*3
            //x /= 3;//x=x/3
            //x %= 3;//x=x%3
            #endregion
            #region relational
            //int x = 7, y = 6;
            //Console.WriteLine(x == y);
            //Console.WriteLine(x != y);
            //Console.WriteLine(x < y);
            //Console.WriteLine(x > y);
            //Console.WriteLine(x >= y);
            //Console.WriteLine(x <= y);
            #endregion
            #region logical
            //Console.WriteLine(!false);
            //Console.WriteLine(false && true);//false
            //Console.WriteLine(false || true);//true
            #endregion
            #region beetwise
            //Console.WriteLine(false & true);
            //Console.WriteLine(false | true);
            #endregion
            #region ternary
            //int x = 3, y = 6;
            //string message = (y > x) ? "y is more than x" : (x > y) ? "x is more than y" : "y and x are equal";
            #endregion
            #endregion
            #region operator priority
            //1- Unary(prefix)
            //2- ()
            //3- * / %
            //4- + -
            #endregion
            #region string formating
            //int x = 4, y = 7;
            //string message = "Equation is : " + x + "+" + y + "=" + x + y;
            //Console.WriteLine(message); // not recommended
            ////coposite formating 
            //message = string.Format("Equation is :{0}+{1}={2}", x, y, x + y);
            //// string interpolation  (the pest)
            ////using $
            //message = $"Equation is : {x}+{y}={x + y}";
            #endregion
            #region control statements{if - switch}
            #region if 
            // line by line
            //Console.WriteLine("enter a month number");
            //int MonthNumber = int.Parse(Console.ReadLine()!);
            //if (MonthNumber == 1)
            //    Console.WriteLine("January");
            //else if (MonthNumber == 2)
            //    Console.WriteLine("fabruary");
            //else if (MonthNumber == 3)
            //    Console.WriteLine("march");
            //else
            //    Console.WriteLine("not in first quarter");
            #endregion
            #region switch
            ////jump table
            //Console.WriteLine("enter a month number");
            //int MonthNumber = int.Parse(Console.ReadLine()!);
            //switch (MonthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("January");
            //        break;
            //    case 2:
            //        Console.WriteLine("fabruary");
            //        break;
            //    case 3:
            //        Console.WriteLine("march");
            //        break;
            //    default:
            //        Console.WriteLine("not in first quarter");
            //        break;
            //}
            #region features in c#7-c#8-c#9
            #region c#6
            //object input = new object();
            //input = "Rana";
            //switch (input)
            //{
            //   case int number :
            //        Console.WriteLine($"Integer Input: {number}");
            //        break;
            //    case double number:
            //        Console.WriteLine($"Double Intput: {number}");
            //        break;
            //    case string name:
            //        Console.WriteLine($"String Intput: {name}");
            //        break;

            //}
            #endregion
            #region c#7
            //object input = new object();
            //input = 6;
            //switch (input)
            //{
            //    case int number when number > 1 && number < 10:
            //        Console.WriteLine($"Integer Input: {number}");
            //        break;
            //    case double number:
            //        Console.WriteLine($"Double Intput: {number}");
            //        break;
            //    case string name:
            //        Console.WriteLine($"String Intput: {name}");
            //        break;

            //}
            #endregion
            #region c#8
            //switch Expression
            //string input = "1";
            //string message = "";
            //message = input switch
            //{
            //    "1" => "Using Input 1",
            //    "2" => "Using Input 2",
            //    "3" => "Using Input 3",
            //    _ => "No input"
            //};
            #endregion
            #region c#9
            //switch Expression
            //string input = "1";
            //string message = "";
            //message = input switch
            //{
            //    "1" or "2" => "Using Input 1",
            //    "3" => "Using Input 3",
            //    _ => "No input"
            //};
            #endregion
            #endregion
            #endregion
            #endregion
            #endregion
            #region Part 2
            #region Loops
            #region For - Foreach
            //for
            //for(int i =1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //foreach just for printing
            //int[] number  = { 1, 2, 3, 4 };
            //foreach (int  x in number)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion
            #region while - do while
            //do while

            //int number;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("Enter Even Number");
            //    flag = int.TryParse(Console.ReadLine(),out number);
            //}while(number %2==1||!flag);
            //Console.WriteLine(number);

            //while
            //int x = 4;
            //while (x % 2 == 0)
            //{
            //    Console.WriteLine("even number");
            //    Console.WriteLine("enter odd number");
            //    x = int.Parse(Console.ReadLine()!);
            //}
            //Console.WriteLine("odd number");
            #endregion
            #endregion
            #region String vs StrinBguilder
            #region String
            //string is an imutable type can't change itis value
            //string name1 = "yousef";
            //string name2 = "mohamed";
            //name2 = name1;
            //name1 = "ahmed";
            //Console.WriteLine($"name 1 ={name1}");
            //Console.WriteLine(name1.GetHashCode());
            //name1 += "sayed";// create new object with new identity 
            //Console.WriteLine($"name 1 ={name1}");
            //Console.WriteLine(name1.GetHashCode());
            #endregion
            #region StringBuilder
            //StringBuilder is a mutable type
            //String Builder is reference type
            //StringBuilder message = new StringBuilder();
            //message.Append("yousef");
            //Console.WriteLine(message.GetHashCode());
            //message.Append("sayed");
            //Console.WriteLine(message.GetHashCode());
            //Console.WriteLine(message);
            #endregion
            #endregion
            #region Array
            #region 1D array
            //int[] number = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine($"size of array is {number.Length}\n the number of dimension {number.Rank}");
            //int[] num = new int[5];
            //bool flag;
            //Console.WriteLine("enter 5 number ");
            //for (int i = 0; i < num.Length; i++)
            //{
            //    do
            //    {
            //        flag = int.TryParse(Console.ReadLine(), out num[i]);
            //    } while (!flag);
            //}
            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}
            #endregion
            #region 2D array
            //int[,] num = new int[3,5];
            //for (int i = 0; i < num.GetLength(0); i++)
            //{
            //    Console.WriteLine($"enter marks of student num{i + 1}");
            //    for (int j = 0; j < num.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"sub num{j + 1}");
            //        num[i,j]=int.Parse(Console.ReadLine()!);
            //    }
            //}
            //Console.Clear();
            //for (int i = 0; i < num.GetLength(0); i++)
            //{
            //    Console.WriteLine($"grades of student num{i + 1}");
            //    for (int j = 0; j < num.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"sub num{j + 1}={num[i,j]}");
            //    }
            //}
            #endregion
            #region judged array
            //Array of Arrays
            //int[][] num = new int[3][];
            //num[0] = new int[] { 1, 2, 3 }; 
            //num[1] = new int[] { 1, 2, 3, 4 };
            //num[2] = new int[] { 1, 2 };
            //for (int i = 0; i < num.Length; i++)
            //{
            //    for (int j = 0; j < num[i].Length; j++)
            //    {
            //        Console.WriteLine(num[i][j]);
            //    }
            //}
            #endregion
            #endregion
            #endregion
            #endregion
            #region Session 04
            #region function
            //components            
            //1- prototype          //2- calling            //*name
            //* return type         //* name
            //* body                //*arguments
            //* parameters
            //print("*",5);//passing by order
            //Program.print(/* # , 7 */);//default value
            //print(count: 8, pattern: "@");//passing by name

            #endregion
            #region Nullable Value Type
            //Nullable<int> x;//allow null for in (int value + null)
            //int? age; //syntax suger 
            //age = null; 

            #endregion
            #region How To Work With Nullbale ValueType
            //int a = 5;//only value
            //int? b;//value + null
            //b = a; //implicit casting
            //int? k = null; //value + null
            //int l = 20;//value
            //l = (int)k;//explicit casting
            ////----------------------
            //if (k!=null)
            //    l = (int)k;
            //else
            //    l = 0;
            ////------------
            //l = k.HasValue ? k.Value : l; // ternary
            ////------------
            //l = k ?? 0;//coleasing operator // syntax suger
            #endregion
            #region Null Propagation Operator
            //double x = default;
            //int[]? Numbers = default;
            //for (int i = 0;(Numbers!=null)&& (i <Numbers.Length); i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}
            ////---------------
            //if (Numbers != null)
            //{
            //    for (int i = 0;i < Numbers?.Length; i++)
            //    {
            //        Console.WriteLine(Numbers[i]);
            //    }
            //}
            ////----------------
            //int length = Numbers?.Length ?? 0;//Coleasing Operator


            #endregion
            #region Passing By Value
            //int a = 3, b = 5;
            //Console.WriteLine("before swaping");
            //Console.WriteLine(a);//3
            //Console.WriteLine(b);//5
            //swap(a, b);//doesn't work should pass by reference
            //swap(ref a, ref b);//passing by reference
            //Console.WriteLine("after swaping");
            //Console.WriteLine(a);//3
            //Console.WriteLine(b);//5
            #endregion
            #region Passing By Reference
            //int[] Numbers = { 1, 2, 3 };
            //int result = SumArr(Numbers);
            //passing numbers with out (ref)and the change of 
            //element [0]will execute because array is reference type
            //Console.WriteLine(result);// 105
            //int result = SumArr(ref Numbers); //change the array with aother array
            //Console.WriteLine(result);//1

            #endregion
            #endregion
        }
    }
}