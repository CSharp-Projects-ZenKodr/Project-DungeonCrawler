using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Item : MonoBehaviour
{
	public Sprite itemSprite;
	public string itemName;
	public string itemDesc;
	public int itemAmount;
	public int itemSellAmt;

	public Item(Sprite itemSprite, string itemName, string itemDesc)
	{
		this.itemSprite = itemSprite;
		this.itemName = itemName;
		this.itemDesc = itemDesc;

		itemAmount = 400;
		itemSellAmt = (int)(itemAmount * 0.5);
	}

	public Sprite GetSprite()
	{
		return itemSprite;
	}

	public string GetItemName()
	{
		return itemName;
	}

	public string GetItemDesc()
	{
		return itemDesc;
	}

	public int GetItemAmount()
	{
		return itemAmount;
	}

	public int GetItemSellAmt()
	{
		return itemSellAmt;
	}

	public Item GetItem()
	{
		return this;
	}


}