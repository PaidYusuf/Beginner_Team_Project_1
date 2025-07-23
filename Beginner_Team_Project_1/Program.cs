using Beginner_Team_Project_1.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner_Team_Project_1 {
    internal class Program {
        static void Main(string[] args) {


            while (true) {
                Console.WriteLine("\n=== Main Menu ===");
                Console.WriteLine("1. Date Helper");
                Console.WriteLine("2. Random Fun Tool");
                Console.WriteLine("3. Simple Math Tool");
                Console.WriteLine("4. Text Analyzer");
                Console.WriteLine("5. Unit Converter");
                Console.WriteLine("0. Exit");
                Console.Write("Choose: ");
                string choice = Console.ReadLine();


                switch (choice) {
                    case "1":
                        Console.Clear();
                        //Date_Helper.Run();
                        break;
                    case "2":
                        Console.Clear();
                        //Random_Fun_Tool.Run();
                        break;
                    case "3":
                        Console.Clear();
                        Simple_Math_Tool.Run();
                        break;
                    case "4":
                        Console.Clear();
                        //Text_Analyzer.Run();
                        break;
                    case "5":
                        Console.Clear();
                        //Unit_Converter.Run();
                        break;
                    case "0":
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }


        }
    }
}
