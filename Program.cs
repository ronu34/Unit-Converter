using System;

namespace unit_converter
{
    class program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    double convertednum;

                    Console.WriteLine("=====================");
                    Console.WriteLine("    Unit Converter   ");
                    Console.WriteLine("=====================");

                    Console.Write("Enter a Unit : ");
                    string unit = Console.ReadLine();

                    Console.Write("Enter the number without the unit : ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter the second Unit to be converted : ");
                    string unit2 = Console.ReadLine();

                    if (unit == "kg" && unit2 == "g")
                    {
                        convertednum = num1 * 1000;
                        Console.WriteLine($"The converted number is {convertednum} {unit2}");
                    }
                    else if (unit == "g" && unit2 == "kg")
                    {
                        convertednum = num1 / 1000;
                        Console.WriteLine($"The converted number is {convertednum} {unit2}");
                    }
                    else if (unit == "kg" && unit2 == "tons")
                    {
                        convertednum = num1 / 1000;
                        Console.WriteLine($"The converted number is {convertednum} {unit2}");
                    }
                    else if (unit == "tons" && unit2 == "kg")
                    {
                        convertednum = num1 * 1000;
                        Console.WriteLine($"The converted number is {convertednum} {unit2}");
                    }
                    else if (unit == "kg" && unit2 == "mg")
                    {
                        convertednum = num1 * 1e+6;
                        Console.WriteLine($"The converted number is {convertednum} {unit2}  (Approx)");
                    }
                    else if (unit == "mg" && unit2 == "kg")
                    {
                        convertednum = num1 / 1e+6;
                        Console.WriteLine($"The converted number is {convertednum} {unit2} (Approx)");
                    }
                    else if (unit == "kg" && unit2 == "microgram")
                    {
                        convertednum = num1 * 1e+9;
                        Console.WriteLine($"The converted number is {convertednum} {unit2} (Approx)");
                    }
                    else if (unit == "kg" && unit2 == "imperial tons")
                    {
                        convertednum = num1 / 1016;
                        Console.WriteLine($"The converted number is {convertednum} {unit2} (Approx)");
                    }
                    else if (unit == "imperial tons" && unit2 == "kg")
                    {
                        convertednum = num1 * 1016;
                        Console.WriteLine($"The converted number is {convertednum} {unit2} (Approx)");
                    }
                    else if (unit == "us tons" && unit2 == "kg")
                    {
                        convertednum = num1 * 907.2;
                        Console.WriteLine($"The converted number is {convertednum} {unit2} (Approx)");
                    }
                    else if (unit == "kg" && unit2 == "us tons")
                    {
                        convertednum = num1 / 907.2;
                        Console.WriteLine($"The converted number is {convertednum} {unit2} (Approx)");
                    }
                    else if (unit == "kg" && unit2 == "stone")
                    {
                        convertednum = num1 * 6.35;
                        Console.WriteLine($"The converted number is {convertednum} {unit2} (Approx)");
                    }
                    else if (unit == "kg" && unit2 == "pounds")
                    {
                        convertednum = num1 * 2.4062;
                        Console.WriteLine($"The converted number is {convertednum} {unit2} (Approx)");
                    }
                    else if (unit == "pounds" && unit2 == "kg")
                    {
                        convertednum = num1 / 2.4062;
                        Console.WriteLine($"The converted number is {convertednum} {unit2} (Approx)");
                    }
                    else if (unit == "ounce" && unit2 == "kg")
                    {
                        convertednum = num1 / 35.274;
                        Console.WriteLine($"The converted number is {convertednum} {unit2}");
                    }
                    else if (unit == "kg" && unit2 == "ounce")
                    {
                        convertednum = num1 * 35.274;
                        Console.WriteLine($"The converted number is {convertednum} {unit2}");
                    }
                    else if (unit == "km" && unit2 == "m")
                    {
                        convertednum = num1 * 1000;
                        Console.WriteLine($"The converted number is {convertednum} {unit2}");
                    }
                    else if (unit == "m" && unit2 == "km")
                    {
                        convertednum = num1 / 1000;
                        Console.WriteLine($"The converted number is {convertednum} {unit2}");
                    }
                    else if (unit == "km" && unit2 == "cm")
                    {
                        convertednum = num1 * 100000;
                        Console.WriteLine($"The converted number is {convertednum} {unit2}");
                    }
                    else if (unit == "cm" && unit2 == "km")
                    {
                        convertednum = num1 / 100000;
                        Console.WriteLine($"The converted number is {convertednum} {unit2}");
                    }
                    else if (unit == "km" && unit2 == "mm")
                    {
                        convertednum = num1 * 1e+6;
                        Console.WriteLine($"The converted number is {convertednum} {unit2}");
                    }
                    else if (unit == "mm" && unit2 == "km")
                    {
                        convertednum = num1 * 1e+6;
                        Console.WriteLine($"The converted number is {convertednum} {unit2}");
                    }
                    else if (unit == "m" && unit2 == "micrometer")
                    {
                        convertednum = num1 * 1e+9;
                        Console.WriteLine($"The converted number is {convertednum} {unit2}");
                    }
                    else
                    {
                        Console.WriteLine("Not Defined");
                        continue;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                Console.WriteLine("=========================");
                Console.WriteLine("  Made By Ronu Enderman  ");
                Console.WriteLine("=========================");
                Console.Write("Type Q to exit or type C to do another conversion: ");
                string quit = Console.ReadLine();
                if (quit == "Q" ||  quit == "q")
                {
                    break;
                }
                else if (quit == "C" || quit == "c")
                {
                    continue;
                }
                
            }
        }
    }
}