public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Check for null before accessing MyProperty
        if (MyProperty != null)
        {
            Console.WriteLine(MyProperty.ToString());
        }
        else
        {
            Console.WriteLine("MyProperty is null.");
        }
    }
} 