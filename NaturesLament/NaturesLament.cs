using Terraria.ModLoader;

namespace NaturesLament
{
	class NaturesLament : Mod
	{
		public NaturesLament()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
