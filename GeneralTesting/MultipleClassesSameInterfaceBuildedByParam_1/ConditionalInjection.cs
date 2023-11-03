using GeneralTesting.MultipleClassesSameInterfaceBuildedByParam_1._3.Feature.FeatureFoo;
using GeneralTesting.MultipleClassesSameInterfaceBuildedByParam_1._4.Shared.SharedFoo;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GeneralTesting.MultipleClassesSameInterfaceBuildedByParam_1;

public class ConditionalInjection
{
    
    public void Inject()
    {
        var builder = Host.CreateApplicationBuilder(null);
        builder.Services.AddScoped<ServiceFoo, Foo1>();
        builder.Services.AddScoped<ServiceFoo, Foo2>();
        using var host = builder.Build();
    }
}