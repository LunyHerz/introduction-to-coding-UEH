enum TriangleType
{
    Type1,
    Type2,
    Type3
}
class Bai4
{
    static void Main(string[] args)
    {
        Console.Write("Enter triangle type (Type1/Type2/Type3): ");
        TriangleType type = Enum.Parse<TriangleType>(Console.ReadLine());
        Console.Write("Enter triangle size: ");
        int size = int.Parse(Console.ReadLine());
        if (type == TriangleType.Type1)
        {
            for (int row = 1; row <= size; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col);
                }
                Console.WriteLine();
            }
        }
        if (type == TriangleType.Type2)
        {
            int currentnumber = 1;
            for (int row = 1; row <= size; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write($"{currentnumber} ");
                    currentnumber++;
                }
                Console.WriteLine();
            }
        }
        if (type == TriangleType.Type3)
        {
            int currentNumber = 1;
            int lastRowStart = 1;
            for (int r = 1; r < size; r++)
            {
                lastRowStart += r;
            }
            int maxWidth = 0;
            int tempNum = lastRowStart;
            for (int c = 1; c <= size; c++)
            {
                maxWidth += tempNum.ToString().Length;
                if (c < size) maxWidth++;
                tempNum++;
            }
            for (int row = 1; row <= size; row++)
            {
                int currentRowWidth = 0;
                int checkNum = currentNumber;
                for (int c = 1; c <= row; c++)
                {
                    currentRowWidth += checkNum.ToString().Length;
                    if (c < row) currentRowWidth++;
                    checkNum++;
                }
                int spacesNeeded = (maxWidth - currentRowWidth) / 2;
                Console.Write(new string(' ', spacesNeeded));
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(currentNumber);
                    if (col < row)
                    {
                        Console.Write(" ");
                    }
                    currentNumber++;
                }
                Console.WriteLine();
            }
        }
    }
}