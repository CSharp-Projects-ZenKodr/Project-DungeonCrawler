using System.Collections;
using System;
using UnityEngine;

namespace CaptainSly.ItemSystem
{
	[Serializable]
	public class ISRarity : IISRarity
	{

		[SerializeField] Sprite _icon;
		[SerializeField] string _name;
		[SerializeField] string _tooltip;
		[SerializeField] double _statBoost;
		[SerializeField] Color _textColor;

		public ISRarity()
		{
			_name = "Common";
			_tooltip = "Common Item";
			_statBoost = 1.5;
			_textColor = new Color(212, 172, 53); // Orange-ish Color
		}

		public string Name
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

		public string ToolTip
		{
			get
			{
				return _tooltip;
			}

			set
			{
				_tooltip = value;
			}
		}

		public double StatBoost
		{
			get
			{
				return _statBoost;
			}

			set
			{
				_statBoost = value;
			}
		}

		public Sprite Icon
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

		public Color Color
		{
			get
			{

				return _textColor;
			}

			set
			{
				_textColor = value;
			}
		}
	}
}