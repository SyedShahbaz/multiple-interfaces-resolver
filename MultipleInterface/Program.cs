using MultipleInterface;
using MultipleInterface.Abstraction;
using MultipleInterface.Implementation;
using static MultipleInterface.Resolver.Resolver;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        services.AddHostedService<WorkerTwo>();
        services.AddHostedService<EmojiWorker>();

        services.AddSingleton<IEmoji, Smile>();
        services.AddSingleton<IEmoji, Apple>();
        services.AddSingleton<IEmoji, ThumbsUp>();

        services.AddTransient<ProcessingOne>();
        services.AddTransient<ProcessingTwo>();

        services.AddTransient<ServiceResolver>(serviceProvider => Key =>
        {
            switch (Key)
            {
                case "One":
                    return serviceProvider.GetService<ProcessingOne>();
                case "Two":
                    return serviceProvider.GetService<ProcessingOne>();
                default:
                    throw new KeyNotFoundException();
            }
        });

    })
    .Build();

await host.RunAsync();

