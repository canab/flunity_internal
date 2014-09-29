using UnityEngine;
using FlashBundles;
using Flunity;

namespace Examples
{
	public class FractalTree : LiveReloadableScene
	{
		protected override void CreateScene()
		{
			stage.root.AddChild(new MovieClip(SceneBundle.McScene1));
		}
	}
}

