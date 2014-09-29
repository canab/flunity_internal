//-- This is generated content, don't modify this file!

using Flunity;
using UnityEngine;

namespace FlashBundles
{
	public class SceneBundle : ContentBundle
	{
		public static readonly MovieClipResource McDemo1 = new MovieClipResource("SceneBundle/McDemo1");
		public static readonly SpriteResource blue_circle = new SpriteResource("SceneBundle/blue_circle");
		public static readonly FontResource default_font = new FontResource("SceneBundle/default_font");

		public static readonly SceneBundle instance = new SceneBundle();

		private SceneBundle() {}
	}

	public class McDemo1 : MovieClip
	{
		protected override DisplayObject[] ConstructInstances()
		{
			var instances = new DisplayObject[6];
			instances[0] = new TextField("Arial", 24)
			{
				text = "Demo 1\n",
				textColor = new Color32(255, 255, 204, 255),
				hAlignment = HAlign.CENTER,
				size = new Vector2(944f, 30f),
				shadowColor = new Color32(0, 51, 102, 255),
				shadowOffset = new Vector2(1f, 1f),
			};
			instances[1] = new FlashSprite(SceneBundle.blue_circle);
			instances[2] = new FlashSprite(SceneBundle.blue_circle);
			instances[3] = new FlashSprite(SceneBundle.blue_circle);
			instances[4] = new FlashSprite(SceneBundle.blue_circle);
			instances[5] = new FlashSprite(SceneBundle.blue_circle);
			return instances;
		}

		public McDemo1() : base(SceneBundle.McDemo1) {}
		public McDemo1(DisplayContainer parent) : this() { this.parent = parent; }
	}

}