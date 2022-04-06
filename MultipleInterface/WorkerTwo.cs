using MultipleInterface.Abstraction;
using static MultipleInterface.Resolver.Resolver;

namespace MultipleInterface
{
	public class WorkerTwo : BackgroundService
	{
        private readonly IProcessor _processor;

		public WorkerTwo(ServiceResolver serviceResolver)
		{
            _processor = serviceResolver("One");
		}

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _processor.Process();

            return Task.CompletedTask;
        }
    }
}

