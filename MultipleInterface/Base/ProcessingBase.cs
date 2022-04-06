namespace MultipleInterface.Base
{
	public class ProcessingBase
	{
		private readonly ILogger<ProcessingBase> _logger;

		public ProcessingBase(ILogger<ProcessingBase> logger)
		{
			_logger = logger;
		}

		public ILogger Logger { get => _logger; }

		protected void MethodOne()
        {
			_logger.LogInformation("Method One called from base");
            Console.WriteLine("Method One in base class");
        }

		protected void MethodTwo()
        {
			_logger.LogInformation("Method Two is called from base");
            Console.WriteLine("Method Two in base class");
        }
	}
}

