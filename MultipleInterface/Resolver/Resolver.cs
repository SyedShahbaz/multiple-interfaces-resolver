using MultipleInterface.Abstraction;

namespace MultipleInterface.Resolver
{
	public class Resolver
	{
        public delegate IProcessor ServiceResolver(string Key);
    }
}

