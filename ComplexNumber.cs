//Parker Esmay
// 06/06/2014
//Complex Number App

using System;

public class Complex
{
    public double Imag { get; private set; }
    public double Real { get; private set; }

    public Complex()
    {
        Real = 0.0;
        Imag = 0.0;
    }

    public Complex(double real, double imag)
    {
        Real = real;
        Imag = imag;
    }


    // Overload operators (+-*/)
    public static Complex operator +(Complex a, Complex b)
    {
        return new Complex(a.Real + b.Real, a.Imag + b.Imag);
    }

    public static Complex operator -(Complex a, Complex b)
    {
        return new Complex(a.Real - b.Real, a.Imag - b.Imag);
    }

    public static Complex operator *(Complex a, Complex b)
    {
        return new Complex(a.Real * b.Real - a.Imag * b.Imag, a.Real * b.Imag + b.Real * a.Imag);
    }

    public static Complex operator /(Complex a, Complex b)
    {
        double newReal =
        (a.Real * b.Real + a.Imag * b.Imag) / (b.Real * b.Real + b.Imag * b.Imag);

        double newImag =
        (b.Real * a.Imag - a.Real * b.Imag) / (b.Real * b.Real + b.Imag * b.Imag);


        return (new Complex(newReal, newImag));
    }

    public Complex add(Complex c)
    {
        Complex added = new Complex(Real, Imag);
        added += c;
        return added;
    }

    public Complex subtract(Complex c)
    {
        Complex subtracted = new Complex(Real, Imag);
        subtracted -= c;
        return subtracted;
    }

    public Complex multiply(Complex c)
    {
        Complex multiplied = new Complex(Real, Imag);
        multiplied *= c;
        return multiplied;
    }

    public Complex divide(Complex c)
    {
        Complex divided = new Complex(Real, Imag);
        divided /= c;
        return divided;
    }

    // Override the ToString method to display an complex number in the suitable format i.e. (1 + 2i):
    public override string ToString()
    {

        if (Real != 0 && Imag != 0)
        {
            return String.Format("({0} {1} {2}i)", Real, (Imag < 0 ? "-" : "+"), Math.Abs(Imag));
        }
        else if (Real == 0)
        {
            return (String.Format("({0})", Imag));
        }
        else if (Imag == 0)
        {
            return (String.Format("({0})", Real));
        }
        return String.Format("({0} {1} {2}i)", Real, (Imag < 0 ? "-" : "+"), Math.Abs(Imag));
    }


    public static void print()
    {


        String menuChoice; // stores user command

        Console.Write("\nEnter Command: <type help for assitance>  "); // prompt the user for command
        menuChoice = Console.ReadLine(); // read & store command

        Complex a, b;

        switch (menuChoice)
        {
            case "help":
                Console.WriteLine("##----------------------------------------##");
                Console.WriteLine("Valid help commands for this program");
                Console.WriteLine("help - Prints this help");
                Console.WriteLine("add  - Adds two complex numbers");
                Console.WriteLine("sub  - Subtracts two complex numbers");
                Console.WriteLine("div  - Subtracts two complex numbers");
                Console.WriteLine("mult - Subtracts two complex numbers ");
                Console.WriteLine("quit - Exit program  ");
                Console.WriteLine("##----------------------------------------##\n");
                break;
            case "add": 
                Console.Write("Enter the real term: ");
                double realPart = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the imaginiary term: ");
                double imaginaryPart = Convert.ToDouble(Console.ReadLine());
                a = new Complex(realPart, imaginaryPart);

                Console.Write("Enter the real term: ");
                double realPart1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the imaginary term: ");
                double imaginaryPart1 = Convert.ToDouble(Console.ReadLine());
                b = new Complex(realPart1, imaginaryPart1);

                Complex answer = a.add(b);

                Console.WriteLine("\n{0} + {1} = {2}", a, b, answer);
                break;
            case "sub":
                Console.Write("Enter the real term: ");
                double realPartS = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the imaginiary term: ");
                double imaginaryPartS = Convert.ToDouble(Console.ReadLine());
                a = new Complex(realPartS, imaginaryPartS);

                Console.Write("Enter the real term: ");
                double realPartS1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the imaginary term: ");
                double imaginaryPartS1 = Convert.ToDouble(Console.ReadLine());
                b = new Complex(realPartS1, imaginaryPartS1);

                Complex answer2 = a.subtract(b);

                Console.WriteLine("\n{0} - {1} = {2}", a, b, answer2);
                break;
            case "div":
                Console.Write("Enter the real term: ");
                double realPartD = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the imaginiary term: ");
                double imaginaryPartD = Convert.ToDouble(Console.ReadLine());
                a = new Complex(realPartD, imaginaryPartD);

                Console.Write("Enter the real term: ");
                double realPartD1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the imaginary term: ");
                double imaginaryPartD1 = Convert.ToDouble(Console.ReadLine());
                b = new Complex(realPartD1, imaginaryPartD1);

                Complex answer4 = a.divide(b);

                Console.WriteLine("\n{0} - {1} = {2}", a, b, answer4);
                break;
            case "mult":
                Console.Write("Enter the real term: ");
                double realPartM = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the imaginiary term: ");
                double imaginaryPartM = Convert.ToDouble(Console.ReadLine());
                a = new Complex(realPartM, imaginaryPartM);

                Console.Write("Enter the real term: ");
                double realPartM1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the imaginary term: ");
                double imaginaryPartM1 = Convert.ToDouble(Console.ReadLine());
                b = new Complex(realPartM1, imaginaryPartM1);

                Complex answer3 = a.multiply(b);

                Console.WriteLine("\n{0} * {1} = {2}", a, b, answer3);
                break;

            case "quit":
                Console.WriteLine("\nGoodbye!");
                Environment.Exit(0); // Exit appliction
                break;

            default:
                if (menuChoice != "quit")
                {
                    Complex.print();
                }
                break;
        }
    }

    public static void Main()
    {
        Complex num1 = new Complex(1, 2); //used for Problems 1-4, first complex
        Complex num2 = new Complex(4, 5); //used for Problems 1-4, second complex


        // Print the numbers and the sum using the overridden ToString method:
        //Problem 1:
        //(1 + 2i) + ( 4 + 5i)  = (5 + 7i)  
        Complex answer1 = num1.add(num2); 
        Console.WriteLine("Problem 1: \n{0} + {1} = {2}", num1, num2, answer1);

        //Problem 2:    
        //(1 + 2i) - ( 4 + 5i)  = (-3 + -3i)  
        Complex answer2 = num1.subtract(num2);
        Console.WriteLine("Problem 2: \n{0} - {1} = {2}", num1, num2, answer2);

        //Problem 3: 
        //(1 + 2i) * (4 + 5i)  = (-6 + 13i)
        Complex answer3 = num1.multiply(num2);
        Console.WriteLine("Problem 3: \n{0} * {1} = {2}", num1, num2, answer3);

        //Problem 4:
        //(1 + 2i)  / (4 + 5i)  = (0.341463414634146 + 0.0731707317073171i)
        Complex answer4 = num1.divide(num2);
        Console.WriteLine("Problem 4: \n{0} / {1} = {2}", num1, num2, answer4);

        //Problem 5:
        //((7 + 5i) +(0 + 3i) )  * (5 + 2i) =  (19 + 54i)
        Complex problem5Num1 = new Complex(7, 5);
        Complex problem5Num2 = new Complex(0, 3);
        Complex problem5Num3 = new Complex(5, 2);
        Complex answer5 = (problem5Num1 + problem5Num2) * problem5Num3;
        Console.WriteLine("Problem 5: \n({0} + {1}) * {2} = {3}", problem5Num1, problem5Num2, problem5Num3, answer5);

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        

        while (true) // dispay print method
        {
            Complex.print();
        }


    }

}