namespace Lesson_005_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICalculator calculator = new Calculator();

            calculator.GetResult += Calculator_GetResult;

            while (true)
            {
                Console.Write("Введите число: ");

                if (!Double.TryParse(Console.ReadLine(), out double number))
                {
                    Console.WriteLine("Ошибка ввода числа!");
                    continue;
                }


                while (true)
                {

                    Console.Write("Введите операцию: +, -, *, /, 'q' - для выхода из программы, 'с' - для возврата к предидущему значению: ");
                    string operation = Console.ReadLine();

                    switch (operation)
                    {
                        case "+":
                            calculator.Sum(number);
                            break;
                        case "-":
                            calculator.Substract(number);
                            break;
                        case "*":
                            calculator.Multiply(number);
                            break;
                        case "/":
                            calculator.Divide(number);
                            break;
                        case "c":
                            calculator.CancelLast();
                            break;
                        case "q":
                            return;
                        default:
                            Console.WriteLine("Неверная команда");
                            continue;
                    }
                    break;
                }


            }

        }
        private static void Calculator_GetResult(object? sender, OperandChangedEventArgs e)
        {
            Console.WriteLine(e.Operand);
        }

    }
}
