using MultipleInterface.Abstraction;
using MultipleInterface.Base;

namespace MultipleInterface.Implementation
{
    public class ProcessingTwo : ProcessingBase, IProcessor
    {
        public ProcessingTwo(ILogger<ProcessingTwo> logger) : base(logger)
        {
        }

        public void Process()
        {
            Logger.LogInformation("Logging from Processing Two");
            Console.WriteLine("Processing Two started");
            MethodOne();
            MethodTwo();
        }
    }
}

