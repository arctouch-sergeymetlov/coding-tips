// Tip CS1:
// Math.Round() rounds the midpont value to the nearest even by default.

using System;
					
public class Program
{
    public static void Main()
    {
        void W1(double d)
        {
            Console.WriteLine(Math.Round(d));
        }
		
        // By default, the midpoint value will be rounded to the nearest even value:
        W1(1.5); // 2
        W1(2.5); // 2
        W1(3.5); // 4
        W1(4.5); // 4
		
        // Tip 1:
        // This behavior can be overridden by specifying the second argument:
        void W2(double d)
        {
            Console.WriteLine(Math.Round(d, MidpointRounding.AwayFromZero));
        }
		
        W2(1.5); // 2
        W2(2.5); // 3
        W2(3.5); // 4
        W2(4.5); // 5
    }
}

/*
/// <summary>
/// <para>Specifies how mathematical rounding methods should
/// process a number that is midway between two numbers.</para>
/// </summary>
public enum MidpointRounding
{
    /// <summary>
    /// <para>When a number is halfway between two others, it is
    /// rounded toward the nearest even number.</para>
    /// </summary>
    ToEven,

    /// <summary>
    /// <para>When a number is halfway between two others, it is
    /// rounded toward the nearest number that is away from zero.</para>
    /// </summary>
    AwayFromZero,
}
*/
