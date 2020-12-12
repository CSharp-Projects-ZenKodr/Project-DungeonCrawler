using UnityEngine;
using System.Collections;

namespace CaptainSly.ItemSystem
{
	public interface IISRarity
	{
		// Name of Quality
		// Stat Boost 
		// Quality Icon
		// Quality Color

		Sprite Icon { get; set; }
		string Name { get; set; }
		string ToolTip { get; set; }
		double StatBoost { get; set; }
		Color Color { get; set; }

	}
}