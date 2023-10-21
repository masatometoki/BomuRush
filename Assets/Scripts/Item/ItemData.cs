using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItemData", menuName = "BomuRush/Item Data")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public Sprite itemIcon;
    public ItemEffect effect;
    public float duration;
    public int quantity;
}

public enum ItemEffect
{
    ExtraBomb,
    IncreasedExplosion,
    SpeedBost,
    Invincibility,
}
