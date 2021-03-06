using System;

class Methods
{
    void PrintInfo()
    {
        Console.WriteLine("Printing Something.....");
        Multiply( 23.5f, 2234.567f);

        Sum(2, 3, 45.1);
        Sum(5, 10, 20, 30.15);

        Greet("Bishnu", "Mr.");
        Greet("Sarita");

        byte[] numbers = {2, 4, 6, 7, 234, 56, 78};
        (byte, byte) result = FindMinMax(numbers);

        //named argument
        PrintCustomerDetails(age: 23, name: "Bishnu", address: "Lalitpur");
        
    }

    void PrintSomething(string message)
    {
        Console.WriteLine(message);
    }

    float Multiply(float firstNum, float secondNum)
    {
        float product = firstNum * secondNum;
        return product;
    }

    float Multiply(float firstNum, float secondNum, float thirdNum)
    {
        float product = firstNum * secondNum * thirdNum;
        return product;
    }

    //Variable numbers of arguments
    double Sum(params double[] numbers)
    {
        foreach (double num in numbers)
        {
            sum = sum + num;
        }
        return sum;
    }

    // Optional Arguments
    string Greet(string name, string prefix = "Miss.")
    {
        string fullName = $"{prefix}, {name}"; // string interpolation
        return fullName;

    }

    //Returning multiple values
    (byte, byte) FindMinMax (byte[] numbers)
    {
        byte max = numbers.Max();
        byte min = numbers.Min();

        return (min, max);
    }

    void PrintCustomerDetails(string name. string address, byte age, bool isMale)
    {
        Console.WriteLine($"{name}[{age}], {address}");
    }

    //Expression bodied method syntax
    float Subtract(float firstNum, float secondNum) => firstNum - secondNum;
    
}