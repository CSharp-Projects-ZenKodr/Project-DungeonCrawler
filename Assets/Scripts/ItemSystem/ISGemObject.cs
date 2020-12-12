using System;
using UnityEngine;

namespace CaptainSly.ItemSystem
{

	public enum ISGemType
	{
		GEM_AMETHIST, GEM_CRYSTAL, GEM_EMERALD, GEM_RUBY, GEM_SAPPHIRE, GEM_DIAMOND, GEM_PEARL, GEM_SUN, GEM_MOON
	}

	public class ISGemObject : ISObject
	{
		ISGemType _gemType;
	}
}