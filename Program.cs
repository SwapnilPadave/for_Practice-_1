using for_Practice__1.EmployeeDAL;
using for_Practice__1.EmployeeDependency;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AccessSpecifiers
{
    //30-6-2022
    #region If-Else Statement
    //class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         Console.WriteLine("Enter a Number:");
    //         int num = Convert.ToInt32(Console.ReadLine());

    //         if(num % 2 == 0)
    //         {
    //             Console.WriteLine("Number Is Even");
    //         }
    //         else
    //         {
    //             Console.WriteLine("Number Is Odd");
    //         }
    //     }
    // }
    #endregion

    #region Else If Statement
    //class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine("Enter A Number To Check Grade:-");
    //        int n = Convert.ToInt32(Console.ReadLine());

    //        if (n < 0 || n > 100)
    //        {
    //            Console.WriteLine("Wrong Number");
    //        }
    //        else if (n > 0 && n < 35)
    //        {
    //            Console.WriteLine("Fail");
    //        }
    //        else if(n>=35 && n<50)
    //        {
    //            Console.WriteLine("D Grade");
    //        }
    //        else if (n >= 50 && n < 75)
    //        {
    //            Console.WriteLine("C Grade");
    //        }
    //        else if(n>=75 && n < 85)
    //        {
    //            Console.WriteLine("B Grade");
    //        }
    //        else if(n>=85 && n<90)
    //        {
    //            Console.WriteLine("A Grade");
    //        }
    //        else if (n >= 90)
    //        {
    //            Console.WriteLine("A+ Grade");
    //        }
    //    }
    //}
    #endregion

    #region Call By Value Function

    //class Program
    //{
    //    public void Show(int val)
    //    {
    //        val += val;
    //        Console.WriteLine("Value inside the show function " + val);
    //    }
    //    public static void Main(string[] args)
    //    {
    //        int val = 51;
    //        Program program = new Program();
    //        Console.WriteLine("Value Before Calling Function:-" + val);
    //        program.Show(val);
    //        Console.WriteLine("Value After Calling Function:-" + val);
    //    }
    //}
    #endregion

    #region Call By Refrence Function
    //class Program
    //{
    //    public void Show(ref int val)
    //    {
    //        val += val;
    //        Console.WriteLine("Value inside the show function " + val);
    //    }
    //    public static void Main(string[] args)
    //    {
    //        int val = 51;
    //        Program program = new Program();
    //        Console.WriteLine("Value Before Calling Function:-" + val);
    //        program.Show(ref val);
    //        Console.WriteLine("Value After Calling Function:-" + val);
    //    }
    //}
    #endregion

    #region Out Parameter Function
    //class Program
    //{

    //    public void Show(out int val)  
    //    {
    //        int square = 5;
    //        val = square;
    //        val *= val;   
    //    }

    //    static void Main(string[] args)
    //    {
    //        int val = 50;
    //        Program program = new Program();  
    //        Console.WriteLine("Value before passing out variable " + val);
    //        program.Show(out val);  
    //        Console.WriteLine("Value after recieving the out variable " + val);
    //    }
    //}
    #endregion

    #region MultiDimension Array
    //public class MultiArrayExample
    //{
    //    public static void Main(string[] args)
    //    {
    //        int[,] arr = new int[3, 3];//declaration of 2D array  
    //        arr[0, 1] = 10;//initialization  
    //        arr[1, 2] = 20;
    //        arr[2, 0] = 30;

    //        //traversal  
    //        for (int i = 0; i < 3; i++)
    //        {
    //            for (int j = 0; j < 3; j++)
    //            {
    //                Console.Write(arr[i, j] + " ");
    //            }
    //            Console.WriteLine();//new line at each row  
    //        }
    //    }
    //}
    #endregion

    #region Constructor

    //Default Constructor
    //class Program
    //{
    //    public Program()
    //    {
    //        Console.WriteLine("Default Constructor..");
    //    }
    //    public static void Main(string[] args)
    //    {
    //        Program p1 = new Program();
    //        Program p2 = new Program();
    //    }
    //}

    //Parametrized Constructor
    //public class Program
    //{
    //    public int id;
    //    public String name;
    //    public float salary;
    //    public Program(int i, String n, float s)
    //    {
    //        id = i;
    //        name = n;
    //        salary = s;
    //    }
    //    public void display()
    //    {
    //        Console.WriteLine(id + " " + name + " " + salary);
    //    }
    //}
    //class TestEmployee
    //{
    //    public static void Main(string[] args)
    //    {
    //        Program p1 = new Program(101, "Swapnil", 89000f);
    //        Program p2 = new Program(102, "Mahesh", 79000f);
    //        p1.display();
    //        p2.display();

    //    }
    //}
    #endregion

    #region Static Class
    //public static class Program
    //{
    //    public static float PI = 3.14f;
    //    public static int cube(int n)
    //    {
    //        return n * n * n;
    //    }
    //}
    //class TestMyMath
    //{
    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine("Value of PI is:- " + Program.PI);
    //        Console.WriteLine("Cube of 9 is:- " + Program.cube(9));
    //    }
    //}
    #endregion

    #region Struct 

    //public struct Rectangle
    //{
    //    public int width, height;

    //}
    //public class TestStructs
    //{
    //    public static void Main()
    //    {
    //        Rectangle r = new Rectangle();
    //        r.width = 4;
    //        r.height = 5;
    //        Console.WriteLine("Area of Rectangle is: " + (r.width * r.height));
    //    }
    //}
    #endregion

    #region Enum (Enumeration)
    //public class Program
    //{
    //    public enum Season
    //    {
    //        Winter, Spring, Summer, Fall
    //    };
    //    public static void Main(string[] args)
    //    {
    //        int x = (int)Season.Winter;
    //        int y = (int)Season.Fall;
    //        Console.WriteLine("Winter={0}", x);
    //        Console.WriteLine("Fall={0}", y);
    //    }
    //}
    #endregion

    #region Enum (Set Starting Index)
    //public class Program
    //{
    //    public enum Season
    //    {
    //        Winter = 99, Spring, Summer, Fall
    //    }
    //    public static void Main(string[] args)
    //    {
    //        int x = (int)Season.Winter;
    //        int y = (int)Season.Fall;
    //        Console.WriteLine("Winter= {0}", x);
    //        Console.WriteLine("Fall= {0}", y);
    //    }
    //}
    #endregion

    #region Enum ( traversing all values using getNames())
    //public class Program
    //{
    //    public enum Days { sun,mon,tue,wed,thu,fri,sat};

    //    public static void Main()
    //    {
    //        foreach(string s in Enum.GetNames(typeof(Days)))
    //        {
    //            Console.WriteLine(s);
    //        }
    //    }
    //}
    #endregion

    #region Single Level Inheritance
    //public class Animal
    //{
    //    public void Eat()
    //    {
    //        Console.WriteLine("Animal Eating...");
    //    }
    //}
    //public class Dog : Animal
    //{
    //    public void Bark()
    //    {
    //        Console.WriteLine("Dog Is Barking..");
    //    }
    //}
    //class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Dog d = new Dog();
    //        d.Eat();
    //        d.Bark();           
    //    }
    //}
    #endregion

    #region Multi level inheritance
    //public class Animal
    //{
    //    public void Eat()
    //    {
    //        Console.WriteLine("Animal Eating...");
    //    }
    //}
    //public class Dog : Animal
    //{
    //    public void Bark()
    //    {
    //        Console.WriteLine("Dog Is Barking..");
    //    }
    //}
    //public class BabyDoag : Dog
    //{
    //    public void Weep()
    //    {
    //        Console.WriteLine("Baby Dog Is Weeping...");
    //    }
    //}
    //class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        BabyDoag bd1 = new BabyDoag();
    //        bd1.Eat();
    //        bd1.Bark();
    //        bd1.Weep();
    //    }
    //}
    #endregion

    #region Method OverLoading
    //class Calc
    //{
    //    public static int Add(int a,int b)
    //    {
    //        return a + b;
    //    }
    //    public static int Add(int a,int b, int c)
    //    {
    //        return a + b + c;
    //    }
    //}
    //public class B
    //{
    //    public static void Main()
    //    {
    //        Console.WriteLine(Calc.Add(11, 10));
    //        Console.WriteLine(Calc.Add(9, 12));
    //    }
    //}

    //class program
    //{
    //    void sum(int a,int b)
    //    {
    //        Console.WriteLine(a + b);
    //    }
    //    void sum(float a,float b)
    //    {
    //        Console.WriteLine(a + b);
    //    }
    //    static void Main()
    //    {
    //        program p = new program();
    //        p.sum(11, 10);
    //        Console.WriteLine();
    //    }
    //}
    #endregion

    #region Method Overriding
    //class Animal
    //{
    //    public virtual void Eat()
    //    {
    //        Console.WriteLine("Eating..");
    //    }
    //}
    //class Dog : Animal
    //{
    //    public override void Eat()
    //    {
    //        Console.WriteLine("Eating Bread...");
    //    }
    //}
    //class Result
    //{
    //    public static void Main()
    //    {
    //        Dog d = new Dog();
    //        d.Eat();
    //    }
    //}
    #endregion

    #region Sealed Class
    //public sealed class Animal
    // {
    //     public void Eat()
    //     {
    //         Console.WriteLine("Animal Is Eating...");
    //     }
    // }
    // public class Dog : Animal
    // {
    //     public void Bark()
    //     {
    //         Console.WriteLine("Dog Is Barking..");
    //     }
    // }
    // public  class TestSealed
    // {
    //     public static void Main()
    //     {
    //         Dog d = new Dog();
    //         d.Bark();
    //         d.Eat();
    //     }
    // }
    #endregion

    #region Lambda Expression
    //lambda Expression 1
    //class Program
    //{
    //    static void Main()
    //    {
    //        List<int> numbers = new List<int>() { 36, 71, 12,
    //                         15, 29, 18, 27, 17, 9, 34};
    //        Console.Write("List Numbers:-");
    //        foreach (var values in numbers)
    //        {
    //            Console.Write("{0} ", values);
    //        }
    //        Console.WriteLine();
    //        var square = numbers.Select(x => x * x);
    //        Console.Write("Square:-");
    //        foreach(var values in square)
    //        {
    //            Console.Write("{0} ", values);
    //        }
    //        Console.WriteLine();

    //        var DivBy3 = numbers.FindAll(x => (x % 3) == 0);
    //        Console.Write("Divide By 3:-");
    //        foreach(var values in DivBy3)
    //        {
    //            Console.Write("{0} ", values);
    //        }
    //        Console.WriteLine();
    //    }
    //}

    //Lambda Expression 2
    //class Student
    //{
    //    public int RollNo { get; set; }
    //    public string Name { get; set; }
    //}
    //class CGI
    //{
    //    public static void Main()
    //    {
    //        List<Student> Details = new List<Student>()
    //        {
    //            new Student{RollNo=1,Name="Swapnil"},
    //            new Student{RollNo=2,Name="Nilesh"},
    //            new Student{RollNo=3,Name="Ajay"},
    //            new Student{RollNo=4,Name="Vijay"},
    //            new Student{RollNo=5,Name="Sanket"}
    //        };
    //        var newDetails = Details.OrderBy(x => x.Name);
    //        foreach (var values in newDetails)
    //        {
    //            Console.WriteLine(values.RollNo + " " + values.Name);
    //        }

    //    }
    //}
    #endregion

    #region Dependency Injection
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        EmployeeBL employeeBL = new EmployeeBL(new EmployeeDAL());
    //        List<Employee> ListEmployee = employeeBL.GetAllEmployees();
    //        foreach (Employee emp in ListEmployee)
    //        {
    //            Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", emp.ID, emp.Name, emp.Department);
    //        }
    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Abstract Class
    //public abstract class Shape
    // {
    //     public abstract void Draw();
    // }
    // public class Rectangle:Shape
    // {
    //     public override void Draw()
    //     {
    //         Console.WriteLine("Drawing Rectangle...");
    //     }
    // }
    // public class Circle : Shape
    // {
    //     public override void Draw()
    //     {
    //         Console.WriteLine("Drawing Circle...");
    //     }
    // }
    // public class TestAbstract
    // {
    //     public static void Main()
    //     {
    //         Shape s;
    //         s = new Rectangle();
    //         s.Draw();
    //         s = new Circle();
    //         s.Draw();
    //     }
    // }
    #endregion

    #region Interface Implementation
    //public interface Drawable  //Interface
    //{
    //    void Draw();
    //}
    //public class Rectangle : Drawable
    //{
    //    public void Draw()
    //    {
    //        Console.WriteLine("Rectangle Drawing..");
    //    }
    //}
    //public class Circle : Drawable
    //{
    //    public void Draw()
    //    {
    //        Console.WriteLine("Circle Drawing...");
    //    }
    //}
    //public class TestInterface
    //{
    //    public static void Main()
    //    {
    //        Drawable d;
    //        d = new Rectangle();
    //        d.Draw();
    //        d = new Circle();
    //        d.Draw();

    //    }
    //}
    #endregion

    #region Public Access Moodifier
    //class Program
    //{
    //    public string name = "Swapnil Padave";
    //    public void msg(string msg)
    //    {
    //        Console.WriteLine("Hello " + msg);
    //    }
    //}
    //class PublicTest
    //{
    //    static void Main()
    //    {
    //        Program p = new Program();
    //        Console.WriteLine("Hello " + p.name);
    //        p.msg("Developer Trainee..");
    //    }
    //}
    #endregion

    #region Protected Access Modifier
    //class ProtectedTest
    //{
    //    protected string name = "Swapnil Padave";
    //    protected void Msg(string msg)
    //    {
    //        Console.WriteLine("Hi " + msg);
    //    }
    //}
    //class program :ProtectedTest
    //{
    //    static void Main()
    //    {
    //        program p = new program();
    //        Console.WriteLine("Hi "+p.name);
    //        p.Msg("There..");
    //    }
    //}
    #endregion

    #region Internal Access Modifier
    //class InternalTest
    //{
    //    internal string name = "Swapnil Padave";
    //    internal void Msg(string msg)
    //    {
    //        Console.WriteLine("Hi " + msg);
    //    }
    //}
    //class program : InternalTest
    //{
    //    static void Main()
    //    {
    //        InternalTest internalTest = new InternalTest();
    //        Console.WriteLine("Hi " + internalTest.name);
    //        internalTest.Msg("There..");
    //    }
    //}
    #endregion

    #region Private Access Modifier
    //class PrivateTest
    //{
    //    private string name = "Swapnil Padave";
    //    private void Msg(string msg)
    //    {
    //        Console.WriteLine("Hi " + msg);
    //    }
    //    static void Main()
    //    {
    //        PrivateTest privateTest = new PrivateTest();
    //        Console.WriteLine("Hi " + privateTest.name);
    //        privateTest.Msg("There..");
    //    }
    //}
    #endregion

    #region Encapsulation 
    //class Student
    //{
    //    public string ID { get; set; }
    //    public string Name { get; set; }
    //    public string Email { get; set; }
    //}
    //class Program
    //{
    //    public static void Main()
    //    {
    //        Student student1 = new Student();
    //        Student student2 = new Student();
    //        student1.ID = "999";
    //        student1.Name = "Swapnil Padave";
    //        student1.Email = "spadave7@gmail.com";

    //        student2.ID = "111";
    //        student2.Name = "Nilesh Pathak";
    //        student2.Email = "NileshPathak@gmail.com";

    //        Console.WriteLine("ID=" + student1.ID);
    //        Console.WriteLine("Name=" + student1.Name);
    //        Console.WriteLine("Email=" + student1.Email);
    //        Console.WriteLine();
    //        Console.WriteLine("ID=" + student2.ID);
    //        Console.WriteLine("Name=" + student2.Name);
    //        Console.WriteLine("Email=" + student2.Email);
    //    }
    //}
    #endregion

    #region Exception Handling
    //class Example1
    // {
    //     public static void Main()
    //     {
    //         try
    //         {
    //             int a = 10;
    //             int b = 0;
    //             int result = a / b;
    //         }
    //         catch(Exception e)
    //         {
    //             Console.WriteLine(e);
    //         }
    //         Console.WriteLine("Rest Of The Code..");
    //     }
    // }

    //class Example2
    //{
    //    public static void Main()
    //    {
    //        try
    //        {
    //            int a = 10;
    //            int b = 0;
    //            int result = a / b;
    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine(e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Finally Block Executed..");
    //        }
    //        Console.WriteLine("Rest Of The Code..");
    //    }
    //}

    //Error Example..
    //class Example3
    //{
    //    public static void Main()
    //    {
    //        try
    //        {
    //            int a = 10;
    //            int b = 0;
    //            int result = a / b;
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Finally Block Executed..");
    //        }
    //        Console.WriteLine("Rest Of The Code..");
    //    }
    //}

    #endregion

    #region User Define Exception(Custom Exception)
    //Example 1
    //public class InvalidAgeException : Exception
    //{
    //    public InvalidAgeException(string message) : base(message)
    //    {

    //    }
    //}
    //public class TestUserDefinedException
    //{
    //    static void validate(int age)
    //    {
    //        if (age < 18)
    //        {
    //            throw new InvalidAgeException("Sorry, Age must be greater than 18");
    //        }
    //    }
    //    public static void Main(string[] args)
    //    {
    //        try
    //        {
    //            validate(12);
    //        }
    //        catch (InvalidAgeException e)
    //        { 
    //            Console.WriteLine(e);
    //        }
    //        Console.WriteLine("Rest of the code");
    //    }
    //}

    //Example 2
    //public class InvalidPasswordException : Exception
    //{
    //    public InvalidPasswordException(string msg) : base(msg)
    //    {

    //    }
    //}
    //public class TestUserDefineException
    //{
    //    static void validate(int password)
    //    {
    //        if (password == 1234567)
    //        {
    //            throw new InvalidPasswordException("Sorry Wrong Password..");
    //        }
    //    }
    //    public static void Main()
    //    {
    //        try
    //        {
    //            validate(890876);
    //        }
    //        catch(InvalidPasswordException p)
    //        {
    //            Console.WriteLine(p);
    //        }
    //        Console.WriteLine("Please Login Again.");
    //    }
    //}
    #endregion


}
