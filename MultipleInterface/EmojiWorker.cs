using MultipleInterface.Abstraction;

namespace MultipleInterface
{
	public class EmojiWorker : BackgroundService
	{
		private readonly IEnumerable<IEmoji> _emojis;

		public EmojiWorker(IEnumerable<IEmoji> emojis)
		{
			_emojis = emojis;
		}

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var userValue = "Hello";
            foreach (var emoji in _emojis)
            {
                emoji.Apply(ref userValue);
            }

            Console.WriteLine("Processed Value " + userValue);

            return Task.CompletedTask;

        }
    }
}

