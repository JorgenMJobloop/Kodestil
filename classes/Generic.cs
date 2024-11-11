public class Generic
{
    // a generic field that uses the ExampleType class a datatype
    public ExampleType? genericType;

    public Test? something;

    // Constructor that implements a generic type, an integer and a string 
    public Generic(ExampleType generic, int id, string text)
    {
        genericType = generic;
        genericType.ID = id;
        genericType.textValue = text;
    }

    public void PrintGeneric()
    {
        Console.WriteLine($"The value of the generic type E: {genericType}.");
    }
}