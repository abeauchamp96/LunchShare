namespace LunchShare;
public class DeclarationAndTypePattern
{
    public static void DeclarationTypePatterns()
    {
        object thing = 45;
        //object? thing = null;

        if (thing is int)
        {
            var number = (int)thing;

            Console.WriteLine(number + 2);
        }
        else
        {
            Console.WriteLine("thing is null :(");
        }
    }

    public static void DeclarationArrayPatterns()
    {
        var numbers = new[] { 1, 2, 3, 4, 5 };
        //var numbers = new List<int> { 1, 2, 3, 4, 5 };

        if (numbers is IList<int> list)
        {
            list.Add(6);

            Console.WriteLine(string.Join(',', list));
        }
        else
        {
            Console.WriteLine("Is not a list :(");
        }
    }
}
