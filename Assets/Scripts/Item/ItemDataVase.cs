using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataVase : MonoBehaviour
{
    public Item[] items; //アイテムデータの配列

    private void Start()
    {
        //アイテムデータの初期化
        items = new Item[2];

        //1つ目のアイテム
        items[1] = new Item(
            "ボム＋",
            "一度におけるボムの数が増加",
            1,
            1,
            Resources.Load<Sprite>("BomuIcon"));

        //2つ目のアイテム
        items[1] = new Item(
            "火力up",
            "爆発範囲が増加",
            2,
            2,
            Resources.Load<Sprite>("FireIcon"));
    }
}
