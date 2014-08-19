using System.Collections.Generic;

namespace ActionLib.Motion
{
	internal class TweenPropertyMap : Dictionary<ITweenProperty, TweenDataHolder>
	{
		public TweenPropertyMap(int capacity) : base(capacity)
		{}
	};
}