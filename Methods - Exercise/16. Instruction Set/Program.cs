using System;

class InstructionSet_broken
{
    static void Main()
    {
        string[] command = Console.ReadLine()
            .Split(' ');

        decimal result = 0;
        decimal operandOne = 0;
        decimal operandTwo = 0;

        while (command[0] != "END")
        {
            if (command[0] == "INC")
            {
                operandOne = decimal.Parse(command[1]);
                result = operandOne + 1;
                Console.WriteLine(result);

            }
            else if (command[0] == "DEC")
            {
                operandOne = decimal.Parse(command[1]);
                result = operandOne - 1;
                Console.WriteLine(result);
            }
            else if (command[0] == "ADD")
            {
                operandOne = decimal.Parse(command[1]);
                operandTwo = decimal.Parse(command[2]);
                result = operandOne + operandTwo;
                Console.WriteLine(result);
            }
            else if (command[0] == "MLA")
            {
                operandOne = decimal.Parse(command[1]);
                operandTwo = decimal.Parse(command[2]);
                result = (operandOne * operandTwo);
                Console.WriteLine(result);
            }

            command = Console.ReadLine().Split(' ');
        }

    }


}
