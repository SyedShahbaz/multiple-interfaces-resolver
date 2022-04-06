using MultipleInterface.Abstraction;

namespace MultipleInterface.Implementation
{
	public class ThumbsUp : IEmoji
    {
        public void Apply(ref string value)
        {
            value += "👍🏻";
        }
    }
}

