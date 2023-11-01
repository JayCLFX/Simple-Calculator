namespace Calculator
{
    public class Program
    {
        static void Main(string[] args) => Calculate(0, 0, 0);
        static void Calculate(double Number1, double Number2, double result)
        {
            char op;
            Console.Clear();
            Console.WriteLine("Number 1: \n"); if (Double.TryParse(Console.ReadLine(), out Number1) == false) Calculate(0, 0, 0);
            Console.Clear();
            Console.WriteLine("Number 2: \n"); if (Double.TryParse(Console.ReadLine(), out Number2) == false) Calculate(0, 0, 0);
            Console.Clear();
            Console.WriteLine("Operator"); char.TryParse(Console.ReadLine(), out op); bool valid = !Char.IsLetter(op); if (valid == false) Calculate(0, 0, 0);
            Console.Clear();
            result = op switch { '+' => Number1 + Number2, '-' => Number1 - Number2, '*' => Number1 * Number2, '/' => Number1 / Number2, _ => throw new NotImplementedException() };
            Console.Write($"{Number1}  {op}  {Number2}  =  {result}"); Console.ReadLine(); Calculate(0, 0, 0);
        }
    }
}
