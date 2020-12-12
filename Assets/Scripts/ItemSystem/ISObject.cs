using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CaptainSly.ItemSystem
{
	public class ISObject : IISObject
	{
		[SerializeField] Sprite _icon;
		[SerializeField] ISRarity _rarity;
		[SerializeField] string _name;
		[SerializeField] string _shortDesc;
		[SerializeField] string _longDesc;
		[SerializeField] int _goldValue;
		[SerializeField] bool _questFlag;

		public Sprite ISIcon
		{
			get
			{
				return _icon;
			}

			set
			{
				_icon = value;
			}
		}

		public ISRarity ISRarity
		{
			get
			{
				return _rarity;
			}

			set
			{
				_rarity = value;
			}

		}

		public string ISName
		{
			get
			{
				return _name;
			}

			set
			{
				_name = value;
			}
		}

		public string ISShortDesc
		{
			get
			{
				return _shortDesc;
			}

			set
			{
				_shortDesc = value;
			}
		}

		public string ISLongDesc
		{
			get
			{
				return _longDesc;
			}

			set
			{
				_longDesc = value;
			}
		}

		public int ISGoldValue
		{
			get
			{
				return _goldValue;
			}

			set
			{
				_goldValue = value;
			}
		}

		public bool ISQuestFlag
		{
			get
			{
				return _questFlag;
			}

			set
			{
				_questFlag = value;
			}
		}

	}
}