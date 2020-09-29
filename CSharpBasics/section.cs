class SelectionStatement
{
    void LearnIfElse()
    {
        byte age = 78;
        if (age > 60)
        {
            Console.Writeline("You are eligible for pension.");
        }
        else if (age)
        {
            Console.Writeline("You are not eligible for pension.");
        }
    }
}