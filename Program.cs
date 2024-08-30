using System;

class Program
{
    // Phương thức đếm số lần xuất hiện của ký tự trong chuỗi
    public static int CountCharacterOccurrences(string str, char character)
    {
        int count = 0;
        foreach (char c in str)
        {
            if (c == character)
            {
                count++;
            }
        }
        return count;
    }

    // Phương thức nhập chuỗi từ người dùng
    public static string InputString()
    {
        Console.Write("Enter the string: ");
        return Console.ReadLine();
    }

    // Phương thức nhập ký tự từ người dùng
    public static char InputCharacter()
    {
        char character;
        while (true)
        {
            Console.Write("Enter the character to count: ");
            string input = Console.ReadLine();

            if (input.Length == 1 && char.TryParse(input, out character))
            {
                return character; // Trả về ký tự nếu đầu vào hợp lệ
            }
            Console.WriteLine("Invalid input. Please enter a single character.");
        }
    }

    // Phương thức xuất kết quả ra màn hình
    public static void OutputResult(char character, int count)
    {
        Console.WriteLine($"The character '{character}' appears {count} times in the string.");
    }

    public static void Main(string[] args)
    {
        // Nhập chuỗi và ký tự từ người dùng
        string str = InputString();
        char character = InputCharacter();

        // Đếm số lần xuất hiện của ký tự trong chuỗi
        int count = CountCharacterOccurrences(str, character);

        // Xuất kết quả
        OutputResult(character, count);
    }
}
