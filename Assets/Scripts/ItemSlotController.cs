using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemSlotController : MonoBehaviour
{

    public Image spriteSlot1, spriteSlot2, spriteSlot3;


    public void switchItemSlot1(Image sprite)
	{
        spriteSlot1 = sprite;
	}

    public void switchItemSlot2(Image sprite)
	{
        spriteSlot2 = sprite;
	}

    public void switchItemSlot3(Image sprite)
	{
        spriteSlot3 = sprite;
	}
}
