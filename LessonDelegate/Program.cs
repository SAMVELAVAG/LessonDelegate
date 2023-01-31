// See https://aka.ms/new-console-template for more information


Calculate calculate = new Calculate();
Printer printer = new Printer();

Result resultsum = new Result(calculate.Sum, printer.Print);
resultsum.Handle(10, 15);

Result resultmultiply = new Result(calculate.Multiply, printer.Print);
resultmultiply.Handle(3, 5);

Result resultsubtract = new Result(calculate.Subtract, printer.Print);
resultsubtract.Handle(10, 4);

Result resultdivide = new Result(calculate.Divide, printer.Print);
resultdivide.Handle(15, 3);


public class Calculate
{
    public int Sum(int x, int y)
    {
        return x + y;
    }
    public int Subtract(int x, int y)
    {
        return x - y;
    }
    public int Multiply(int x, int y)
    {
        return x * y;
    }
    public int Divide(int x, int y)
    {
        return x / y;
    }
}


public class Printer
{
    public void Print(string txt)
    {
        Console.WriteLine($"Result: {txt}");
    }
}

public delegate int CalculateDelegate(int x, int y);
public delegate void PrintDelegate(string txt);

public class Result
{
    private CalculateDelegate _calculateDelegate;
    private PrintDelegate _printDelegate;

    public Result(CalculateDelegate calculateDelegate, PrintDelegate printDelegate)
    {
        _calculateDelegate = calculateDelegate;
        _printDelegate = printDelegate;
    }

    public void Handle(int x, int y)
    {
        int result = _calculateDelegate(x, y);
        _printDelegate(result.ToString());
    }
}




//Sample sample = new Sample();
//MyDel del1, del2, del3;
//del1 = sample.Method1;
//del1();
//del2 = sample.Method2;
//del2();
//del3 = sample.Method3;
//del3();

//class Sample
//{
//    public void Method1()
//    {
//        Console.WriteLine("\tMethod1 called");
//    }

//    public void Method2()
//    {
//        Console.WriteLine("\tMethod2 called");
//    }

//    public void Method3()
//    {
//        Console.WriteLine("\tMethod3 called");
//    }
//}
//delegate void MyDel();



