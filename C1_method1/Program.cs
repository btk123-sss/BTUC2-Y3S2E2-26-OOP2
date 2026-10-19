// using System;
// namespace C1_method1
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             showMessage();
//             Message1 m = new Message1();
//             m.showMessage();
//             new Message1().showMessage();
//             Message1.showMessageStatic();

//             System.Console.WriteLine("");

//             int a = 100;
//             System.Console.WriteLine($"a in Main: (before) {a}");
//             methodWithA();
//             System.Console.WriteLine($"a in Main: (after) {a}");
// //
//             CalcPay(100, 20.2);
//             Double Salary = CalcPay(50, 25.0);
//             System.Console.WriteLine($" My pay is {Salary}");


//             int[] someNum = {10, 20, 30, 40 , 50};
//             MethodGetsOneInt(someNum[0]);
//             System.Console.WriteLine(someNum[0]);

//             MethodGetsArray(someNum);

//             Console.WriteLine("At end of Main() method..........");
//             for (int x = 0; x < someNum.Length; ++x)
//                 Console.Write("{0, 6}", someNum[x]);

//             for (int x=0; x < args.Length; x++)
//             {
//                 System.Console.WriteLine($"Input {x} is {args[x]}");
//             }
//            System.Console.WriteLine("   ");
//            System.Console.WriteLine("   ");
//            System.Console.WriteLine("   ");
//         }

//         public static void showMessage()
//         {
//             Console.WriteLine("Hello world!");
//         }
//         public static void methodWithA()
//         {
//             int a = 345;
//             Console.WriteLine($"a in Method: {a}");
//         }

//         private static Double CalcPay(int hour, double rate)
//         {
//             // Double gross;
//             // gross = hour * rate;
//             // return gross;

//             return hour * rate;
//         }

//         private static void MethodGetsOneInt(int oneVal)
//         {
//             Console.Write("In MethodGetsOneInt() {0}", oneVal);
//             oneVal = 999;
//             Console.WriteLine(" After change {0}", oneVal);
//         }

//          private static void MethodGetsArray(int[] vals)
//         {
//             int x;
//             Console.Write("In MethodGetsArray() ");
//             for (x = 0; x < vals.Length; ++x)
//                 Console.Write(" {0}", vals[x]);
//             Console.WriteLine();
//             for (x = 0; x < vals.Length; ++x)
//                 vals[x] = 888;
//             Console.Write("After change");
//             for (x = 0; x < vals.Length; ++x)
//                 Console.Write(" {0}", vals[x]);
//             Console.WriteLine();
//         }

//     }

//     public class Message1
//     {
//         public void showMessage()
//         {
//             Console.WriteLine("Non static method");
//         }
//         public static void showMessageStatic()
//         {
//             Console.WriteLine("Static Method");
//         }
//     };



// }
