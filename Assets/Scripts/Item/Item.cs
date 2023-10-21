using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string itemName; //アイテム名
    public string description; //アイテムの説明
    public int itemID; //アイテムの一意のID
    public int itemValue; //アイテムの価値(例: 価格、攻撃力、回復力など)
    public Sprite icon;//アイテムのアイコン (UnityのSprite型を使用)

    public Item(string name, string desc, int id, int value, Sprite itemIcon)
    {
        itemName = name;
        description = desc;
        itemID = id;
        itemValue = value;
        icon = itemIcon;
    }
}
