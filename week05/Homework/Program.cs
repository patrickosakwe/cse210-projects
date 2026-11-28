
class Program
{
    static void Main(string[] args)
    {
        // Test the Assignment class
        Assignment assignment = new Assignment(
            "Lola Adekola",
            "Multiplication");

        Console.WriteLine(assignment.GetSummary());

        Console.WriteLine();

        // Test the MathAssignment class
        MathAssignment math = new MathAssignment(
            "Roseline Roberts",
            "Fractions",
            "7.3",
            "8-19");

        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        Console.WriteLine();

        // Test the WritingAssignment class
        WritingAssignment writing = new WritingAssignment(
            "Mary Olawale",
            "African History",
            "The Causes of Nigeria Civil War");

        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}
