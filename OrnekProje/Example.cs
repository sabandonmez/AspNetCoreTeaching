using OrnekProje.Services;

namespace OrnekProje
{
    public class Example
    {
        public Example()
        {
            IServiceCollection services = new ServiceCollection();
            //services.Add(ServiceDescriptor(typeof(ConsoleLog) , new ConsoleLog() ));
            //services.Add(ServiceDescriptor(typeof(TextLog), new TextLog()));
            //services.Add(ServiceDescriptor(typeof(PerformanceLog), new PerformanceLog(12) ));

            ServiceProvider provider = services.BuildServiceProvider();
            provider.GetService<ConsoleLog>();
            provider.GetService<TextLog>();
            provider.GetService<PerformanceLog>();  

        }
    }
}
