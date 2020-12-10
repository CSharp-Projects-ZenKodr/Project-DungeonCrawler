using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpBarScript : MonoBehaviour
{
	public Slider slider;

	public void SetXP(int xp)
	{
		slider.value = xp;
	}

	public void setMaxXP(int xp)
	{
		slider.maxValue = xp;
		slider.value = 0;
	}
}
