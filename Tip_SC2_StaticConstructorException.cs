// Tip CS2:
// Avoid static constructors to throw exceptions.

using System;

public class Config
{
    public static bool Throw = true;
}

public class A
{
    static A()
    {
        if (Config.Throw)
            throw new InvalidOperationException();
    }
}

public class Program
{
    public static void Main()
    {
        try
        {
            // Note 1:
            // Despite static constructor throws InvalidOperationException
            // the runtime will wrap it into TypeInitializationException.
            var a = new A();
        }
        catch (TypeInitializationException)
        {
            // caught
        }
		
        // Note 2:
        // The problem is even if you re-configure things so the exception
        // shouldn't be thrown again it still will since static constructors
        // are only called once. Thus the following code will produce the same
        // TypeInitializationException.
        Config.Throw = false;
        var a1 = new A();
    }
}
