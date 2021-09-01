using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Line_Calculator
{
    class Game
    {
        public string Input;
        public bool inProcess;
        public float Value1;
        public float Value2;
        public float RememberedValue;

        public void Run()
        {
            Value1 = float.NaN;
            Value2 = float.NaN;
            RunTime();
        }

        public void Calculate() 
        {
            
        }

        public void RunTime() 
        {
            Console.Clear();
            while (Input != "Quit") 
            {
                Console.Clear();
                Console.WriteLine("Welcome to the calculator. Please start by entering an argument to begin calculating such as: 'Add' , 'Subtract' , 'Multiply' , 'Divide'");
                Console.WriteLine($"Last sum: {RememberedValue}, You can input '>' to use this in equations rather than inputting a number");
                Input = Console.ReadLine();
                if (inProcess == false && Input == "Add" || Input == "add" || Input == "Addition" || Input == "addition" || Input == "+")
                {
                    inProcess = true;
                    Addition();
                }
                if (inProcess == false && Input == "Subtract" || Input == "subtract" || Input == "Minus" || Input == "minus" || Input == "-")
                {
                    inProcess = true;
                    Subtraction();
                }
                if (inProcess == false && Input == "Multiply" || Input == "multiply" || Input == "Times" || Input == "times" || Input == "*")
                {
                    inProcess = true;
                    Multiply();
                }
                if (inProcess == false && Input == "Divide" || Input == "divide" || Input == "/")
                {
                    inProcess = true;
                    Divide();
                }
                if (inProcess == false && Input == "Power" || Input == "power" || Input == "^")
                {
                    inProcess = true;
                    Power();
                }
                if (inProcess == false && Input == "Clear" || Input == "clear")
                    RememberedValue = float.NaN;
                
            }
        }

        public void Addition() 
        {
            Console.Clear();
            Console.WriteLine($"{Value1}+{Value2}=");
            for (int Index = 0; Index < 2; Index++)
            {
                Input = Console.ReadLine();
                Console.Clear();
                float number;
                if (Single.TryParse(Input, out number))
                {
                    if (Index == 0)
                        Value1 = number;
                    if (Index == 1)
                        Value2 = number;
                }
                else if (Input == ">") 
                {
                    if (Index == 0)
                        Value1 = RememberedValue;
                    if (Index == 1)
                        Value2 = RememberedValue;
                }
                else
                {
                    Console.WriteLine("N/A");
                    Index--;
                }
                Console.WriteLine($"{Value1}+{Value2}=");
            }
            Console.Clear();
            float cal = Value1 + Value2;
            Console.WriteLine($"{Value1}+{Value2}={cal}");
            Console.ReadKey();
            Console.Clear();
            RememberedValue = Value1 + Value2;
            inProcess = false;
            Value1 = float.NaN;
            Value2 = float.NaN;
            RunTime();
        }

        public void Subtraction()
        {
            Console.Clear();
            Console.WriteLine($"{Value1}-{Value2}=");
            for (int Index = 0; Index < 2; Index++)
            {
                Input = Console.ReadLine();
                Console.Clear();
                float number;
                if (Single.TryParse(Input, out number))
                {
                    if (Index == 0)
                        Value1 = number;
                    if (Index == 1)
                        Value2 = number;
                }
                else if (Input == ">")
                {
                    if (Index == 0)
                        Value1 = RememberedValue;
                    if (Index == 1)
                        Value2 = RememberedValue;
                }
                else
                {
                    Console.WriteLine("N/A");
                    Index--;
                }
                Console.WriteLine($"{Value1}-{Value2}=");
            }
            Console.Clear();
            float cal = Value1 - Value2;
            Console.WriteLine($"{Value1}-{Value2}={cal}");
            Console.ReadKey();
            Console.Clear();
            RememberedValue = Value1 - Value2;
            inProcess = false;
            Value1 = float.NaN;
            Value2 = float.NaN;
            RunTime();
        }

        public void Multiply()
        {
            Console.Clear();
            Console.WriteLine($"{Value1}*{Value2}=");
            for (int Index = 0; Index < 2; Index++)
            {
                Input = Console.ReadLine();
                Console.Clear();
                float number;
                if (Single.TryParse(Input, out number))
                {
                    if (Index == 0)
                        Value1 = number;
                    if (Index == 1)
                        Value2 = number;
                }
                else if (Input == ">")
                {
                    if (Index == 0)
                        Value1 = RememberedValue;
                    if (Index == 1)
                        Value2 = RememberedValue;
                }
                else
                {
                    Console.WriteLine("N/A");
                    Index--;
                }
                Console.WriteLine($"{Value1}*{Value2}=");
            }
            Console.Clear();
            float cal = Value1 * Value2;
            Console.WriteLine($"{Value1}*{Value2}={cal}");
            Console.ReadKey();
            Console.Clear();
            RememberedValue = Value1 * Value2;
            inProcess = false;
            Value1 = float.NaN;
            Value2 = float.NaN;
            RunTime();
        }

        public void Divide()
        {
            Console.Clear();
            Console.WriteLine($"{Value1}/{Value2}=");
            for (int Index = 0; Index < 2; Index++)
            {
                Input = Console.ReadLine();
                Console.Clear();
                float number;
                if (Single.TryParse(Input, out number))
                {
                    if (Index == 0)
                        Value1 = number;
                    if (Index == 1)
                        Value2 = number;
                }
                else if (Input == ">")
                {
                    if (Index == 0)
                        Value1 = RememberedValue;
                    if (Index == 1)
                        Value2 = RememberedValue;
                }
                else
                {
                    Console.WriteLine("N/A");
                    Index--;
                }
                Console.WriteLine($"{Value1}/{Value2}=");
            }
            Console.Clear();
            float cal = Value1 / Value2;
            Console.WriteLine($"{Value1}/{Value2}={cal}");
            Console.ReadKey();
            Console.Clear();
            RememberedValue = Value1 / Value2;
            inProcess = false;
            Value1 = float.NaN;
            Value2 = float.NaN;
            RunTime();
        }

        public void Power()
        {
            Console.Clear();
            Console.WriteLine($"{Value1}^{Value2}=");
            for (int Index = 0; Index < 2; Index++)
            {
                Input = Console.ReadLine();
                Console.Clear();
                float number;
                if (Single.TryParse(Input, out number))
                {
                    if (Index == 0)
                        Value1 = number;
                    if (Index == 1)
                        Value2 = number;
                }
                else if (Input == ">")
                {
                    if (Index == 0)
                        Value1 = RememberedValue;
                    if (Index == 1)
                        Value2 = RememberedValue;
                }
                else
                {
                    Console.WriteLine("N/A");
                    Index--;
                }
                Console.WriteLine($"{Value1}^{Value2}=");
            }
            Console.Clear();
            float cal = MathF.Pow(Value1, Value2);
            Console.WriteLine($"{Value1}^{Value2}={cal}");
            Console.ReadKey();
            Console.Clear();
            RememberedValue = MathF.Pow(Value1, Value2);
            inProcess = false;
            Value1 = float.NaN;
            Value2 = float.NaN;
            RunTime();
        }
    }
}
