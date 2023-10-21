using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public List<ItemData> itemDataList;

    //シングルトン使用
    public static ItemManager Instance { get; private set; }
    // Start is called before the first frame update
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public ItemData GetItemData(string itemName)
    {
        return itemDataList.Find(item => item.itemName == itemName);
    }
}


