using MultipleInterface.Abstraction;

namespace MultipleInterface.Implementation
{
	public class Smile : IEmoji
    {
        public void Apply(ref string value)
        {
            value += "😀";
        }
    }
}

