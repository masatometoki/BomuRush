using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string itemName; //�A�C�e����
    public string description; //�A�C�e���̐���
    public int itemID; //�A�C�e���̈�ӂ�ID
    public int itemValue; //�A�C�e���̉��l(��: ���i�A�U���́A�񕜗͂Ȃ�)
    public Sprite icon;//�A�C�e���̃A�C�R�� (Unity��Sprite�^���g�p)

    public Item(string name, string desc, int id, int value, Sprite itemIcon)
    {
        itemName = name;
        description = desc;
        itemID = id;
        itemValue = value;
        icon = itemIcon;
    }
}
