using MultipleInterface.Abstraction;
using static MultipleInterface.Resolver.Resolver;

namespace MultipleInterface;

public class Worker : BackgroundService
{
    private readonly IProcessor _processor;

    public Worker(ServiceResolver serviceResolver)
    {
        _processor = serviceResolver("Two");
    }

    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _processor.Process();

        return Task.CompletedTask;
    }
}

