using GeneralTesting.LazyLoading.Classes;
using GeneralTesting.LazyLoading.Contracts;

namespace GeneralTesting.LazyLoading;

public class LazyLoading
{
    private readonly Lazy<IClass1> _class1;

    public LazyLoading(Lazy<IClass1> class1)
    {
        _class1 = class1;
    }

    public void Do()
    {
        Console.WriteLine("lazy injection");
        Thread.Sleep(5);
    }
}