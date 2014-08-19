using ActionLib.Display;

namespace ActionLib.Resources
{
	/// <summary>
	/// Interface for resources that can instantiate DisplayObject
	/// </summary>
	public interface IDisplayResource : IResource
	{
		DisplayObject CreateInstance();
	}
}

