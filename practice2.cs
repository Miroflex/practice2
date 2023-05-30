using System;



class Program

{

    static void Main(string[] args)

    {

        int n = 1;

        double pi = 1.0;

        double delta = 1.0;

        double eps = 0.001;



        // Обчислення з простою точністю 

        while (Math.Abs(delta) > eps)

        {

            n += 2;

            delta = 1.0 / n;

            if (n % 4 == 1)

            {

                pi += delta;

            }

            else if (n % 4 == 3)

            {

                pi -= delta;

            }

        }



        Console.WriteLine($"З простою точністю: π = {4.0 * pi} при {n / 2} доданках");



        // Обчислення з подвійною точністю 

        n = 1;

        double pi2 = 1.0;

        double delta2 = 1.0;

        double eps2 = 0.0001;



        while (Math.Abs(delta2) > eps2)

        {

            n += 2;

            delta2 = 1.0 / n;

            if (n % 4 == 1)

            {

                pi2 += delta2;

            }

            else if (n % 4 == 3)

            {

                pi2 -= delta2;

            }

        }



        Console.WriteLine($"З подвійною точністю: π = {4.0 * pi2} при {n / 2} доданках");

        Console.ReadLine();

    }

}