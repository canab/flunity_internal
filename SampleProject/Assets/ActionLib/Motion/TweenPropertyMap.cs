using System.Collections.Generic;

namespace Flunity.Motion
{
	internal class TweenPropertyMap : Dictionary<ITweenProperty, TweenDataHolder>
	{
		public TweenPropertyMap(int capacity) : base(capacity)
		{}
	};
}