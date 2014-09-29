//-- This is generated content, don't modify this file!

using Flunity.Display;
using Flunity.Resources;

namespace FlashBundles
{
	public class SceneBundle : ContentBundle
	{
		public static readonly MovieClipResource McScene1 = new MovieClipResource("SceneBundle/McScene1");
		public static readonly SpriteResource blue_circle = new SpriteResource("SceneBundle/blue_circle");

		public static readonly SceneBundle instance = new SceneBundle();

		private SceneBundle() {}
	}

	public class McScene1 : MovieClip
	{
		protected override DisplayObject[] ConstructInstances()
		{
			var instances = new DisplayObject[2];
			instances[0] = new FlashSprite(SceneBundle.blue_circle);
			instances[1] = new FlashSprite(SceneBundle.blue_circle);
			return instances;
		}

		public McScene1() : base(SceneBundle.McScene1) {}
		public McScene1(DisplayContainer parent) : this() { this.parent = parent; }
	}

}