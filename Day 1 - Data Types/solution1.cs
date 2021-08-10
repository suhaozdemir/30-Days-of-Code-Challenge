             // Declare second integer, double, and String variables.
        int j;
        double e;
        string t;

        // Read and save an integer, double, and String to your variables.
        //Console.WriteLine("enter integer");
        j = int.Parse(Console.ReadLine());

        //Console.WriteLine("enter double");
        e = double.Parse(Console.ReadLine());

        //Console.WriteLine("enter string");
        t = Console.ReadLine();

        int i3 = i + j;
        double d3 = d + e;
        string s3 = s + t;
        // Print the sum of both integer variables on a new line.

        Console.WriteLine(i3);

        // Print the sum of the double variables on a new line.

        Console.WriteLine("{0:F1}", d3);

        // Concatenate and print the String variables on a new line
        // The 's' variable abo


        Console.WriteLine(s3);

        Console.ReadKey();