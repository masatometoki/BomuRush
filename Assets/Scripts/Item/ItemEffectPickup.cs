using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEffectPickup : MonoBehaviour
{
    public string itemname;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            ItemData itemdata = ItemManager.Instance.GetItemData(itemname);

            if(itemdata != null)
            {
                ApplyItemEffectToPlayer(other.gameObject, itemdata);

                Destroy(gameObject);
            }
        }
    }

    private void ApplyItemEffectToPlayer(GameObject player, ItemData itemdata)
    {
        
    }
}
