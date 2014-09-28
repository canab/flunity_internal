using UnityEngine;
using ActionLib.Unity;
using FlashBundles;
using System.Collections.Generic;
using ActionLib.Motion;
using ActionLib.Display;

namespace Scripts
{
		/*
	public class SceneController : MonoBehaviour
	{
		#region initializing

		bool readyFlag = false;

		void OnEnable()
		{
			readyFlag = true;
		}

		void Update()
		{
			// Initialize here for dynamyc scene creation
			// when unity does recompile scripts.
			if (readyFlag)
			{
				readyFlag = false;
				startup();
			}
		}

		void startup()
		{
			// Create scene on ResourceBundle.Loaded event
			// for fetching newly generated flash resources on-the-fly
			SceneBundle.instance.Loaded += it => createScene();
			SceneBundle.instance.Load();
		}		

		#endregion

		void createScene()
		{
			var comp = GetComponent<FlashStage>();

			// in case when flash resources has been updated in runtime
			// it is necessary remove all previous content
			comp.root.RemoveChildren();

			// create scene MovieClip and attach it to the root
			var scene = new McShipScene(comp.root);

			// framerate is 60 fps, but
			// animations was created for 30 fps
			// so we will tick animation 2 times slower
			scene.animation.ticksPerFrame = 2;

			var ship = scene.ship;
			ship.Play();

			// do not play nested animations,
			// we will control them programmatically
			ship.nestedAnimationEnabled = false;

			// Draw touch zones
			// DebugDraw.drawHitAreas = true;

			ConfigureCannons(ship);
			ConfigureBags(ship);
			ConfigureFlag(ship);
			ConfiguerPirates(ship);

			ConfigureSounds(comp.root);
		}

		static void ConfigureCannons(McShip ship)
		{
			foreach (var cannon in ship.mSide.GetChildren<McCannon>())
			{
				cannon.mRect.Pressed += it => it.target.parent.PlayFromBeginToEnd();
			}
		}

		void ConfigureBags(McShip ship)
		{
			foreach (var bag in ship.GetChildren<McBag>())
			{
				new TouchListener(bag.GetTopChild()).Pressed += it =>  {
					PlaySound("bag");
					var clip = it.target.parent;
					if (clip.IsLastFrame())
						clip.PlayToBegin();
					else
						clip.PlayToEnd();
				};
			}
		}

		void ConfigureFlag(McShip ship)
		{
			// animate scull color on press
			new TouchListener(ship.mFlag.mScull).Pressed += it =>  {
				PlaySound("flag");
				it.target.Tween(500, DisplayObject.COLOR, Color.red);
			};

			ship.mFlag.Play();
		}

		void ConfiguerPirates(McShip ship)
		{
			ship.mPirate1.mRect.Pressed += it =>
			{
				PlaySound("pirate1");
				ship.mPirate1.PlayFromBeginToEnd();
			};

			ship.mPirate2.mRect.Pressed += it =>
			{
				PlaySound("pirate2");
				ship.mPirate2.PlayFromBeginToEnd();
			};

			ship.mPirate3.mRect.Pressed += it =>
			{
				PlaySound("pirate3");
				ship.mPirate3.PlayFromBeginToEnd();
			};
		}

		void ConfigureSounds(DisplayContainer root)
		{
			// find all nested clips
			var clips = root.GetNestedChildren<MovieClip>();

			// assign action for each frame label
			foreach (MovieClip clip in clips)
			{
				foreach (var label in clip.GetAllLabels())
				{
					var l = label;
					clip.SetFrameAction(l.frame, () => PlaySound(l.name));
				}
			}
		}

		void PlaySound(string soundName)
		{
			var resName = "Sounds/" + soundName;
			var asset = Resources.Load<AudioClip>(resName);
			if (asset != null)
				AudioSource.PlayClipAtPoint(asset, Camera.main.transform.position);
			else
				Debug.LogError("Sound not found: " + resName);
		}
	}*/
}

