//-- This is generated content, don't modify this file!

using ActionLib.Display;
using ActionLib.Resources;
using UnityEngine;

namespace FlashBundles
{
	public class SceneBundle : ContentBundle
	{
		public static readonly MovieClipResource McBag = new MovieClipResource("SceneBundle/anim/McBag");
		public static readonly MovieClipResource McCannon = new MovieClipResource("SceneBundle/anim/McCannon");
		public static readonly MovieClipResource McFlag = new MovieClipResource("SceneBundle/anim/McFlag");
		public static readonly MovieClipResource McPirate1 = new MovieClipResource("SceneBundle/anim/McPirate1");
		public static readonly MovieClipResource McPirate2 = new MovieClipResource("SceneBundle/anim/McPirate2");
		public static readonly MovieClipResource McPirate3 = new MovieClipResource("SceneBundle/anim/McPirate3");
		public static readonly MovieClipResource McShip = new MovieClipResource("SceneBundle/anim/McShip");
		public static readonly MovieClipResource McShipPart1 = new MovieClipResource("SceneBundle/anim/McShipPart1");
		public static readonly MovieClipResource McZzz = new MovieClipResource("SceneBundle/anim/McZzz");
		public static readonly FontResource font1 = new FontResource("SceneBundle/fonts/font1");
		public static readonly MovieClipResource McShipScene = new MovieClipResource("SceneBundle/scene/McShipScene");
		public static readonly SpriteResource bag_e = new SpriteResource("SceneBundle/sprites/bag_e");
		public static readonly SpriteResource balloon = new SpriteResource("SceneBundle/sprites/balloon");
		public static readonly SpriteResource cannon_e1 = new SpriteResource("SceneBundle/sprites/cannon_e1");
		public static readonly SpriteResource cannon_e2 = new SpriteResource("SceneBundle/sprites/cannon_e2");
		public static readonly SpriteResource cannon_e4 = new SpriteResource("SceneBundle/sprites/cannon_e4");
		public static readonly SpriteResource flag_e1 = new SpriteResource("SceneBundle/sprites/flag_e1");
		public static readonly SpriteResource flag_e2 = new SpriteResource("SceneBundle/sprites/flag_e2");
		public static readonly SpriteResource pirat_e14 = new SpriteResource("SceneBundle/sprites/pirat_e14");
		public static readonly SpriteResource pirat_e15 = new SpriteResource("SceneBundle/sprites/pirat_e15");
		public static readonly SpriteResource pirat_e2_e1 = new SpriteResource("SceneBundle/sprites/pirat_e2_e1");
		public static readonly SpriteResource pirat_e2_e2 = new SpriteResource("SceneBundle/sprites/pirat_e2_e2");
		public static readonly SpriteResource pirat_e2_e3 = new SpriteResource("SceneBundle/sprites/pirat_e2_e3");
		public static readonly SpriteResource pirat_e2_e4 = new SpriteResource("SceneBundle/sprites/pirat_e2_e4");
		public static readonly SpriteResource pirat_e2_e5 = new SpriteResource("SceneBundle/sprites/pirat_e2_e5");
		public static readonly SpriteResource pirat_e2_e6 = new SpriteResource("SceneBundle/sprites/pirat_e2_e6");
		public static readonly SpriteResource pirat_e7 = new SpriteResource("SceneBundle/sprites/pirat_e7");
		public static readonly SpriteResource pirat_e9 = new SpriteResource("SceneBundle/sprites/pirat_e9");
		public static readonly SpriteResource pirat_ryka2 = new SpriteResource("SceneBundle/sprites/pirat_ryka2");
		public static readonly SpriteResource pirate1_e = new SpriteResource("SceneBundle/sprites/pirate1_e");
		public static readonly SpriteResource pirate4_e = new SpriteResource("SceneBundle/sprites/pirate4_e");
		public static readonly SpriteResource ship = new SpriteResource("SceneBundle/sprites/ship");
		public static readonly SpriteResource ship_e10 = new SpriteResource("SceneBundle/sprites/ship_e10");
		public static readonly SpriteResource ship_e11 = new SpriteResource("SceneBundle/sprites/ship_e11");
		public static readonly SpriteResource ship_e13 = new SpriteResource("SceneBundle/sprites/ship_e13");
		public static readonly SpriteResource ship_e15 = new SpriteResource("SceneBundle/sprites/ship_e15");
		public static readonly SpriteResource ship_e16 = new SpriteResource("SceneBundle/sprites/ship_e16");
		public static readonly SpriteResource ship_e18 = new SpriteResource("SceneBundle/sprites/ship_e18");
		public static readonly SpriteResource ship_obj_1 = new SpriteResource("SceneBundle/sprites/ship_obj_1");

		public static readonly SceneBundle instance = new SceneBundle();

		private SceneBundle() {}
	}

	public class McBag : MovieClip
	{
		protected override DisplayObject[] ConstructInstances()
		{
			var instances = new DisplayObject[1];
			instances[0] = new FlashSprite(SceneBundle.bag_e);
			return instances;
		}

		public McBag() : base(SceneBundle.McBag) {}
		public McBag(DisplayContainer parent) : this() { this.parent = parent; }
	}


	public class McCannon : MovieClip
	{
		public TouchRect mRect;

		protected override DisplayObject[] ConstructInstances()
		{
			var instances = new DisplayObject[4];
			instances[0] = mRect = new TouchRect()
			{
				name = "mRect",
				size = new Vector2(100f, 100f),
				anchor = new Vector2(0f, 0f),
			};
			instances[1] = new FlashSprite(SceneBundle.cannon_e2);
			instances[2] = new FlashSprite(SceneBundle.cannon_e1);
			instances[3] = new FlashSprite(SceneBundle.cannon_e4);
			return instances;
		}

		public McCannon() : base(SceneBundle.McCannon) {}
		public McCannon(DisplayContainer parent) : this() { this.parent = parent; }
	}


	public class McFlag : MovieClip
	{
		public FlashSprite mScull;

		protected override DisplayObject[] ConstructInstances()
		{
			var instances = new DisplayObject[2];
			instances[0] = new FlashSprite(SceneBundle.flag_e1);
			instances[1] = mScull = new FlashSprite(SceneBundle.flag_e2) {name = "mScull"};
			return instances;
		}

		public McFlag() : base(SceneBundle.McFlag) {}
		public McFlag(DisplayContainer parent) : this() { this.parent = parent; }
	}


	public class McPirate1 : MovieClip
	{
		public TouchRect mRect;

		protected override DisplayObject[] ConstructInstances()
		{
			var instances = new DisplayObject[2];
			instances[0] = new FlashSprite(SceneBundle.pirate1_e);
			instances[1] = mRect = new TouchRect()
			{
				name = "mRect",
				size = new Vector2(100f, 100f),
				anchor = new Vector2(0f, 0f),
			};
			return instances;
		}

		public McPirate1() : base(SceneBundle.McPirate1) {}
		public McPirate1(DisplayContainer parent) : this() { this.parent = parent; }
	}


	public class McPirate2 : MovieClip
	{
		public TouchRect mRect;

		protected override DisplayObject[] ConstructInstances()
		{
			var instances = new DisplayObject[10];
			instances[0] = new FlashSprite(SceneBundle.pirat_e2_e2);
			instances[1] = new FlashSprite(SceneBundle.pirat_e2_e3);
			instances[2] = new FlashSprite(SceneBundle.pirat_e9);
			instances[3] = new FlashSprite(SceneBundle.pirat_e2_e5);
			instances[4] = new FlashSprite(SceneBundle.pirat_e2_e6);
			instances[5] = new FlashSprite(SceneBundle.pirat_e2_e1);
			instances[6] = new FlashSprite(SceneBundle.pirat_e7);
			instances[7] = new FlashSprite(SceneBundle.pirat_e2_e2);
			instances[8] = new FlashSprite(SceneBundle.pirat_e2_e4);
			instances[9] = mRect = new TouchRect()
			{
				name = "mRect",
				size = new Vector2(100f, 100f),
				anchor = new Vector2(0f, 0f),
			};
			return instances;
		}

		public McPirate2() : base(SceneBundle.McPirate2) {}
		public McPirate2(DisplayContainer parent) : this() { this.parent = parent; }
	}


	public class McPirate3 : MovieClip
	{
		public TouchRect mRect;

		protected override DisplayObject[] ConstructInstances()
		{
			var instances = new DisplayObject[2];
			instances[0] = new FlashSprite(SceneBundle.pirate4_e);
			instances[1] = mRect = new TouchRect()
			{
				name = "mRect",
				size = new Vector2(100f, 100f),
				anchor = new Vector2(0f, 0f),
			};
			return instances;
		}

		public McPirate3() : base(SceneBundle.McPirate3) {}
		public McPirate3(DisplayContainer parent) : this() { this.parent = parent; }
	}


	public class McShip : MovieClip
	{
		public McPirate2 mPirate2;
		public McPirate1 mPirate1;
		public McPirate3 mPirate3;
		public McShipPart1 mSide;
		public McFlag mFlag;
		public TextLabel mText;

		protected override DisplayObject[] ConstructInstances()
		{
			var instances = new DisplayObject[30];
			instances[0] = new FlashSprite(SceneBundle.ship_e10);
			instances[1] = new FlashSprite(SceneBundle.ship_e15);
			instances[2] = new FlashSprite(SceneBundle.balloon);
			instances[3] = new FlashSprite(SceneBundle.balloon);
			instances[4] = new FlashSprite(SceneBundle.ship_e11);
			instances[5] = new FlashSprite(SceneBundle.ship_e11);
			instances[6] = new FlashSprite(SceneBundle.balloon);
			instances[7] = new FlashSprite(SceneBundle.ship_e18);
			instances[8] = new FlashSprite(SceneBundle.ship_e18);
			instances[9] = new FlashSprite(SceneBundle.ship_e13);
			instances[10] = new FlashSprite(SceneBundle.ship_e13);
			instances[11] = new FlashSprite(SceneBundle.balloon);
			instances[12] = mPirate2 = new McPirate2() {name = "mPirate2"};
			instances[13] = mPirate1 = new McPirate1() {name = "mPirate1"};
			instances[14] = new FlashSprite(SceneBundle.ship_e16);
			instances[15] = mPirate3 = new McPirate3() {name = "mPirate3"};
			instances[16] = mSide = new McShipPart1() {name = "mSide"};
			instances[17] = new McBag();
			instances[18] = new McBag();
			instances[19] = mFlag = new McFlag() {name = "mFlag"};
			instances[20] = new FlashSprite(SceneBundle.pirat_e15);
			instances[21] = new FlashSprite(SceneBundle.pirat_e15);
			instances[22] = new FlashSprite(SceneBundle.pirat_e15);
			instances[23] = new FlashSprite(SceneBundle.pirat_e15);
			instances[24] = new FlashSprite(SceneBundle.pirat_e15);
			instances[25] = new FlashSprite(SceneBundle.ship_obj_1);
			instances[26] = mText = new TextLabel("a_FuturaRound", 32)
			{
				name = "mText",
				text = "TextLabel",
				textColor = new Color32(255, 255, 153, 255),
				hAlignment = HAlign.CENTER,
				size = new Vector2(215f, 42f),
				shadowColor = new Color32(153, 0, 0, 255),
				shadowOffset = new Vector2(1f, 1f),
			};
			instances[27] = new FlashSprite(SceneBundle.pirat_e15);
			instances[28] = new FlashSprite(SceneBundle.pirat_e15);
			instances[29] = new FlashSprite(SceneBundle.pirat_e15);
			return instances;
		}

		public McShip() : base(SceneBundle.McShip) {}
		public McShip(DisplayContainer parent) : this() { this.parent = parent; }
	}


	public class McShipPart1 : MovieClip
	{
		protected override DisplayObject[] ConstructInstances()
		{
			var instances = new DisplayObject[6];
			instances[0] = new FlashSprite(SceneBundle.ship);
			instances[1] = new FlashSprite(SceneBundle.ship);
			instances[2] = new McCannon();
			instances[3] = new McCannon();
			instances[4] = new McCannon();
			instances[5] = new McCannon();
			return instances;
		}

		public McShipPart1() : base(SceneBundle.McShipPart1) {}
		public McShipPart1(DisplayContainer parent) : this() { this.parent = parent; }
	}


	public class McZzz : MovieClip
	{
		protected override DisplayObject[] ConstructInstances()
		{
			var instances = new DisplayObject[1];
			instances[0] = new FlashSprite(SceneBundle.pirat_e15);
			return instances;
		}

		public McZzz() : base(SceneBundle.McZzz) {}
		public McZzz(DisplayContainer parent) : this() { this.parent = parent; }
	}


	public class McShipScene : MovieClip
	{
		public McShip ship;
		public EmptyObject mcRect;
		public EmptyObject mcPoint;

		protected override DisplayObject[] ConstructInstances()
		{
			var instances = new DisplayObject[3];
			instances[0] = ship = new McShip() {name = "ship"};
			instances[1] = mcRect = new EmptyObject()
			{
				name = "mcRect",
				size = new Vector2(101f, 101f),
				anchor = new Vector2(0f, 0f),
			};
			instances[2] = mcPoint = new EmptyObject()
			{
				name = "mcPoint",
				size = new Vector2(21f, 21f),
				anchor = new Vector2(10f, 10f),
			};
			return instances;
		}

		public McShipScene() : base(SceneBundle.McShipScene) {}
		public McShipScene(DisplayContainer parent) : this() { this.parent = parent; }
	}

}