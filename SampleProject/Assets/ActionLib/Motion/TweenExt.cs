using System;
using System.Diagnostics;

namespace ActionLib.Motion
{
	/// <summary>
	/// Extension methods for creating tween animations on objects.
	/// </summary>
	public static class TweenExt
	{
		public static Tweener Tween(this Object target)
		{
			Debug.Assert(target != null, "target is null");
			return TweenManager.instance.Tween(target);
		}
		
		public static Tweener Tween(this Object target, int duration)
		{
			Debug.Assert(target != null, "target is null");
			return TweenManager.instance.Tween(target).Duration(duration);
		}

		public static Tweener Tween<TTarget, TValue>(
			this TTarget target,
			int duration,
			ITweenProperty<TValue> property,
			TValue to,
			EasyFunction easing = null) where TTarget : class
		{
			Debug.Assert(target != null, "target is null");
			return TweenManager.instance.Tween(target, duration, property, to, easing);
		}

		public static bool HasAnyTweens(this Object target)
		{
			Debug.Assert(target != null, "target is null");
			return TweenManager.HasAnyTweensOf(target);
		}
		
		public static object RemoveAllTweens(this Object target)
		{
			Debug.Assert(target != null, "target is null");
			TweenManager.RemoveAllTweensOf(target);
			return target;
		}
	}
}