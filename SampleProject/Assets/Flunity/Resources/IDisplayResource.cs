using Flunity.Display;

namespace Flunity.Resources
{
	/// <summary>
	/// Interface for resources that can instantiate DisplayObject
	/// </summary>
	public interface IDisplayResource : IResource
	{
		DisplayObject CreateInstance();
	}
}

