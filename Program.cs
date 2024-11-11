namespace Kodestil;

class Program
{
    static void Main(string[] args)
    {
        // example with the string class and the string primitive
        // primitive datatype string
        string someText = "";
        Console.WriteLine(someText);
        // C# Docs does not like the code below
        string classString = "";
        Console.WriteLine(classString);
        string hello = String.Concat("Hello ", "there!");
        Console.WriteLine(hello);

        Console.WriteLine(Convert.ToInt32("2"));


        ExampleType exampleType = new ExampleType();
        exampleType.textValue = "Some value";
        exampleType.ID = 2;
        Generic generic = new Generic(exampleType, exampleType.ID, exampleType.textValue);
        Console.WriteLine($"generic ID: {exampleType.ID} generic text: {exampleType.textValue}");
        generic.PrintGeneric();
    }

}
