
using System.ComponentModel;
using C1_method2;
using Microsoft.VisualBasic;


int x = 11;
System.Console.WriteLine($"X at first is      : {x}");
displayParam(x);
System.Console.WriteLine($"X after is         : {x}");

System.Console.WriteLine("");
System.Console.WriteLine("");

Number n = new Number();
n.Num = 11;
System.Console.WriteLine($"n (obj) at first is      : {n.Num}");
displayObjParam(n);
System.Console.WriteLine($"n (obj) after is         : {n.Num}");

System.Console.WriteLine("");
System.Console.WriteLine("");

x = 11;
System.Console.WriteLine($"X at first is      : {x}");
displayRefParam(ref x);
System.Console.WriteLine($"X after is         : {x}");

System.Console.WriteLine("");
System.Console.WriteLine("");

x = 11;
System.Console.WriteLine($"X at first is      : {x}");
displayOutParam(out x);
System.Console.WriteLine($"X after is         : {x}");

System.Console.WriteLine("");
System.Console.WriteLine("");

System.Console.WriteLine($"Y at first is      : not exist");
displayOutParam(out int y);
System.Console.WriteLine($"Y after is         : {y}");


string num = "100";
int result;
int.TryParse(num, out result);




// System.Console.WriteLine("");
// System.Console.WriteLine("");

// x = 11;
// System.Console.WriteLine($"X at first is      : {x}");
// displayInParam(in x);
// System.Console.WriteLine($"X after is         : {x}");

// System.Console.WriteLine("");
// System.Console.WriteLine("");




// pass by value 
static void displayParam(int x)
{
    x = 99;
    System.Console.WriteLine($"X in the method is : {x}");
}

// pass by reference 
static void displayObjParam(Number n)
{
    n.Num = 99;
    System.Console.WriteLine($"n (obj) in the method is : {n.Num}");
}

// pass by reference
static void displayRefParam(ref int x)
{
    x = 99;
    System.Console.WriteLine($"X in the method is : {x}");
}

// pass by reference
static void displayOutParam(out int x)
{
    x = 99;
    System.Console.WriteLine($"X in the method is : {x}");
}

static void displayInParam(in int x)
{
    // x is pass as read-only
    // x = 99;   
    int z = 100*x;
    //x = 33;

    System.Console.WriteLine($"X in the method is : {x}");
}


static void GetFlightInfo(int flighNumber)
{
    

}

static void GetFlightInfo(string airportName)
{
    
}

// Mandatory parameters 
static void My_Method(int Number, double Weight, string Name)
{
    
}


// call the method using positional arguments 
My_Method(5, 9.6, "Honda");

// call the method using named arguments 
My_Method(Number: 5, Weight: 9.6, Name: "Honda");
My_Method(Name: "Toyota", Weight: 9.6, Number: 4);


// Mandary parameters => Number , Name 
// Optional parameters => Weight 
static void My_Method2(int Number, string Name, double Weight = 5.0)
{
    
}

// Call My_Method2  
My_Method2(6, "Suzuki");
My_Method2(6, "Suzuki", 6.1);

My_Method2(Name: "Toyota", Weight: 9.6, Number: 4);
My_Method2(Name: "Toyota", Number: 4);


