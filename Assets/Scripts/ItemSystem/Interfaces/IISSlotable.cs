using UnityEngine;
using System.Collections;

namespace CaptainSly.ItemSystem
{
	public interface IISSlotable : IISObject
	{

		// Amount of Slots
		// Type of Gem

		int slotAmount { get; set; }
		ISGemType GemType { get; set; }


	}
}