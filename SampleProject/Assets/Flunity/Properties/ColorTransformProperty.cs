using System;
using Flunity.Common;

namespace Flunity.Properties
{
	/// <summary>
	/// Interpolates ColorTransform values
	/// </summary>
	public class ColorTransformProperty<TTarget> : ITweenProperty<ColorTransform> where TTarget : class
	{
		protected readonly Func<TTarget, ColorTransform> getter;
		protected readonly Action<TTarget, ColorTransform> setter;

		public ColorTransformProperty(Func<TTarget, ColorTransform> getter,
			Action<TTarget, ColorTransform> setter)
		{
			this.getter = getter;
			this.setter = setter;
		}

		public void WriteValue(float[] array, ColorTransform value)
		{
			array[0] = value.rMult;
			array[1] = value.gMult;
			array[2] = value.bMult;
			array[3] = value.aMult;
			array[4] = value.rOffset;
			array[5] = value.gOffset;
			array[6] = value.bOffset;
			array[7] = value.aOffset;
		}

		public ColorTransform ReadValue(float[] array)
		{
			return new ColorTransform
			(
				array[0],
				array[1],
				array[2],
				array[3],
				array[4],
				array[5],
				array[6],
				array[7]);
		}

		public ColorTransform Interpolate(float[] start, float[] end, float t)
		{
			ColorTransform ct;

			ct.rMult = start[0] + t * (end[0] - start[0]);
			ct.gMult = start[1] + t * (end[1] - start[1]);
			ct.bMult = start[2] + t * (end[2] - start[2]);
			ct.aMult = start[3] + t * (end[3] - start[3]);

			ct.rOffset = start[4] + t * (end[4] - start[4]);
			ct.gOffset = start[5] + t * (end[5] - start[5]);
			ct.bOffset = start[6] + t * (end[6] - start[6]);
			ct.aOffset = start[7] + t * (end[7] - start[7]);

			return ct;
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