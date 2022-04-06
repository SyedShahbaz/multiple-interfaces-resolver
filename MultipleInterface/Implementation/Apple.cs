using MultipleInterface.Abstraction;

namespace MultipleInterface.Implementation
{
	public class Apple : IEmoji
	{
        public void Apply(ref string value)
        {
            value += "🍎";
        }
    }
}

