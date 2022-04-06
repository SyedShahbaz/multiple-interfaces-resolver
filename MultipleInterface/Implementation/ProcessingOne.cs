using MultipleInterface.Abstraction;
using MultipleInterface.Base;

namespace MultipleInterface.Implementation
{
    public class ProcessingOne : ProcessingBase, IProcessor
    {
        public ProcessingOne(ILogger<ProcessingOne> logger) : base(logger)
        {
        }

        public void Process()
        {
            Logger.LogInformation("Logging from Processing One");
            Console.WriteLine("Processing One started");
            MethodOne();
            MethodTwo();
        }
    }
}

