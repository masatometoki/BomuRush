using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataVase : MonoBehaviour
{
    public Item[] items; //�A�C�e���f�[�^�̔z��

    private void Start()
    {
        //�A�C�e���f�[�^�̏�����
        items = new Item[2];

        //1�ڂ̃A�C�e��
        items[1] = new Item(
            "�{���{",
            "��x�ɂ�����{���̐�������",
            1,
            1,
            Resources.Load<Sprite>("BomuIcon"));

        //2�ڂ̃A�C�e��
        items[1] = new Item(
            "�Η�up",
            "�����͈͂�����",
            2,
            2,
            Resources.Load<Sprite>("FireIcon"));
    }
}
