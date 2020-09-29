using System;

class IterationStatement
{
    //Pascal case: IterationStatement
    //Camel case: iterationStatement

    static void Main()
    {
        IterationStatement iterationStatement = new IterationStatement();
        iterationStatement.LearnForLoops();
    }

    void LearnForLoops()
    {
        int i;
        for(i = 0; i < 10; i++)
        {
            Console.WroteLine("Hello World");
        }
    }
}