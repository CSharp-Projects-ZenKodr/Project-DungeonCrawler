using UnityEngine;

namespace CaptainSly.ItemSystem
{
	public interface IISObject
	{
		// Name
		// Gold Value
		// Icon
		// Short Description
		// Long Description
		// Rarity
		// QuestItem Flag

		Sprite ISIcon { get; set; }
		ISRarity ISRarity { get; set; }
		string ISName { get; set; }
		string ISShortDesc { get; set; }
		string ISLongDesc { get; set; }
		int ISGoldValue { get; set; }
		bool ISQuestFlag { get; set; }

	}

}