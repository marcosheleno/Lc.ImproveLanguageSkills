using GeneralTesting.LazyLoading.Contracts;

namespace GeneralTesting.LazyLoading.Classes;

public class Class3:IClass3
{
    public Class3()
    {
        Console.WriteLine("Iniciei Class 3");
    }

    public void Do()
    {
        Thread.Sleep(3);
    }
}