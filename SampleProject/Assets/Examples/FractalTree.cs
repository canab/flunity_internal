using FlashBundles;

namespace Examples
{
	public class FractalTree : LiveReloadableScene
	{
		protected override void CreateScene()
		{
			new McDemo1(stage.root);
		}
	}
}