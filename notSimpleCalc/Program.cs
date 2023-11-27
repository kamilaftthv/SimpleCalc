class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] elements = input.Split(' ');
        List<string> operators = new List<string>();
        List<int> operand = new List<int>();

        for (int i = 0; i < elements.Length; i++)
        {
            if (i % 2 == 0)
            {
                operand.Add(int.Parse(elements[i]));
            }
            else
            {
                operators.Add(elements[i]);
            }
        }

        for (int i = 0; i < operators.Count; i++)
        {
            switch (operators[i])
            {
                case "*":
                    operand[i] *= operand[i + 1];
                    operand.RemoveAt(i + 1);
                    operators.RemoveAt(i);
                    i--; 
                    break;
                case "/":
                    if (operand[i + 1] != 0)
                    {
                        operand[i] /= operand[i + 1];
                        operand.RemoveAt(i + 1);
                        operators.RemoveAt(i);
                        i--;
                    }
                    else
                    {
                        Console.WriteLine("Нельзя делить на 0!!");
                    }
                    break;
            }
        }

        int result = operand[0];
        for (int i = 0; i < operators.Count; i++)
        {
            switch (operators[i])
            {
                case "+":
                    result += operand[i + 1];
                    break;
                case "-":
                    result -= operand[i + 1];
                    break;
            }
        }

        Console.WriteLine(result);
    }
}