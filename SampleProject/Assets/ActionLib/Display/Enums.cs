using System;

namespace ActionLib.Display
{
	/// <summary>
	/// Horisontal alignment constants
	/// </summary>
	public enum HAlign
	{
		LEFT, CENTER, RIGHT
	}

	/// <summary>
	/// Vertical alignment constants
	/// </summary>
	public enum VAlign
	{
		TOP, MIDDLE, BOTTOM
	}

	/// <summary>
	/// Texture flipping constants
	/// </summary>
	[Flags]
	public enum TextureFlip
	{
		NONE,
		HORIZONTAL,
		VERTICAL,
	}
}
