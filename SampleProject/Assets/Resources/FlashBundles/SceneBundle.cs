//-- This is generated content, don't modify this file!

using Flunity;
using UnityEngine;

namespace FlashBundles
{
	public class SceneBundle : ContentBundle
	{
		public static readonly MovieClipResource McDemo_TouchAndTween = new MovieClipResource("SceneBundle/McDemo_TouchAndTween");
		public static readonly SpriteResource circle_sprite = new SpriteResource("SceneBundle/circle_sprite");
		public static readonly FontResource default_font = new FontResource("SceneBundle/default_font");

		public static readonly SceneBundle instance = new SceneBundle();

		private SceneBundle() {}
	}

	public class McDemo_TouchAndTween : MovieClip
	{
		protected override DisplayObject[] ConstructInstances()
		{
			var instances = new DisplayObject[6];
			instances[0] = new TextField("Arial", 24)
			{
				text = "Tween animation: touch to activate\n",
				textColor = new Color32(255, 255, 204, 255),
				hAlignment = HAlign.CENTER,
				size = new Vector2(944f, 30f),
				shadowColor = new Color32(0, 51, 102, 255),
				shadowOffset = new Vector2(1f, 1f),
			};
			instances[1] = new FlashSprite(SceneBundle.circle_sprite);
			instances[2] = new FlashSprite(SceneBundle.circle_sprite);
			instances[3] = new FlashSprite(SceneBundle.circle_sprite);
			instances[4] = new FlashSprite(SceneBundle.circle_sprite);
			instances[5] = new FlashSprite(SceneBundle.circle_sprite);
			return instances;
		}

		public McDemo_TouchAndTween() : base(SceneBundle.McDemo_TouchAndTween) {}
		public McDemo_TouchAndTween(DisplayContainer parent) : this() { this.parent = parent; }
	}

}