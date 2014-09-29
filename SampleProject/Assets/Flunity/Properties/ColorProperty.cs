using System;
using UnityEngine;
using Flunity.Common;

namespace Flunity.Properties
{
	/// <summary>
	/// Interpolates Color values
	/// </summary>
	public class ColorProperty<TTarget> : ITweenProperty<Color> where TTarget : class
	{
		protected readonly Func<TTarget, Color> getter;
		protected readonly Action<TTarget, Color> setter;

		public ColorProperty(Func<TTarget, Color> getter, Action<TTarget, Color> setter)
		{
			this.getter = getter;
			this.setter = setter;
		}

		public void WriteValue(float[] array, Color value)
		{
			array[0] = value.r;
			array[1] = value.g;
			array[2] = value.b;
			array[3] = value.a;
		}

		public Color ReadValue(float[] array)
		{
			return new Color(
				array[0],
				array[1],
				array[2],
				array[3]);
		}

		public Color Interpolate(float[] start, float[] end, float t)
		{
			var r = start[0] + t * (end[0] - start[0]);
			var g = start[1] + t * (end[1] - start[1]);
			var b = start[2] + t * (end[2] - start[2]);
			var a = start[3] + t * (end[3] - start[3]);

			return new Color(r, g, b, a);
		}

		public void GetValue(float[] array, object target)
		{
			WriteValue(array, getter((TTarget) target));
		}

		public void SetValue(object target, float[] array)
		{
			setter((TTarget) target, ReadValue(array));
		}

		public void Interpolate(object target, float[] startValue, float[] endValue, float position)
		{
			setter((TTarget) target, Interpolate(startValue, endValue, position));
		}
	}
}