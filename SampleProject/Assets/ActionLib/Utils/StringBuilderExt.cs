using System;
using System.Diagnostics;
using System.Text;

namespace ActionLib.Utils
{
	/// <summary>
	/// Provides memory-allocation-free methods for StringBuilder
	/// </summary>
	public static class StringBuilderExt
	{
		private const int BUFFER_SIZE = 128;
		private const uint DEFAULT_BASE = 10;
		private const uint DEFAULT_DECIMAL_PLACES = 5;
		private const char DEFAULT_PAD_CHAR = '0';

		private static readonly char[] digits = new[]
		{'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};

		private static readonly char[] buffer = new char[BUFFER_SIZE];

		public static StringBuilder AppendULong(this StringBuilder builder, ulong value,
			int padAmount = 0, char padChar = DEFAULT_PAD_CHAR, uint @base = DEFAULT_BASE)
		{
			Debug.Assert(@base > 0 && @base <= 16);

			// write digits
			var i = 0;
			do
			{
				i++;
				buffer[BUFFER_SIZE - i] = digits[value % @base];
				value /= @base;
			} while (value > 0);

			// write remaining pads
			while (i < padAmount)
			{
				i++;
				buffer[BUFFER_SIZE - i] = padChar;
			}

			builder.Append(buffer, BUFFER_SIZE - i, i);
			
			return builder;
		}

		
		public static StringBuilder AppendLong(this StringBuilder builder, long value,
			int padAmount = 0, char padChar = DEFAULT_PAD_CHAR, uint @base = DEFAULT_BASE)
		{
			Debug.Assert(@base > 0 && @base <= 16);

			if (value < 0)
			{
				builder.Append('-');
				ulong ulongValue = ulong.MaxValue - ((ulong) value) + 1; // This is to deal with MinValue
				builder.AppendULong(ulongValue, padAmount - 1, padChar, @base);
			}
			else
			{
				builder.AppendULong((ulong) value, padAmount, padChar, @base);
			}

			return builder;
		}
		
		public static StringBuilder AppendUInt(this StringBuilder builder, uint value,
		                                      int padAmount = 0, char padChar = DEFAULT_PAD_CHAR, uint @base = DEFAULT_BASE)
		{
			return builder.AppendULong((ulong) value, padAmount, padChar, @base);
		}
		
		public static StringBuilder AppendInt(this StringBuilder builder, int value,
		                                      int padAmount = 0, char padChar = DEFAULT_PAD_CHAR, uint @base = DEFAULT_BASE)
		{
			return builder.AppendLong((long) value, padAmount, padChar, @base);
		}

		public static StringBuilder AppendFloat(this StringBuilder builder, float value,
			uint decimalPlaces = DEFAULT_DECIMAL_PLACES, int padAmount = 0, char padChar = '0', bool trimEndingZero = true)
		{
			var intPart = (int)value;

			if (Math.Abs(intPart - value) < 1e-9)
			{
				builder.AppendLong(intPart, padAmount, padChar);
				
				if (!trimEndingZero)
				{
					builder.Append('.');
					for (int i = 0; i < decimalPlaces; i++)
					{
						builder.Append('0');
					}
				}
				
				return builder;
			}
			
			decimalPlaces = Math.Max(decimalPlaces, 1);

			builder.AppendLong(intPart, padAmount, padChar);
			builder.Append('.');

			float remainder = Math.Abs(value - intPart);
			int digitsCount = 0;
			for (int i = 0; i < decimalPlaces; i++)
			{
				remainder *= 10;

				if (remainder >= 1)
					digitsCount = i + 1;
			}

			// Round up. It's guaranteed to be a positive number, so no extra work required here.
			var uintValue = (uint) (remainder + 0.5f);
			
			// trim ending zero
			while (trimEndingZero && (uintValue % 10 == 0 && digitsCount > 1))
			{
				uintValue /= 10;
				digitsCount--;
			}
			
			builder.AppendLong(uintValue, digitsCount);

			return builder;
		}
	}
}