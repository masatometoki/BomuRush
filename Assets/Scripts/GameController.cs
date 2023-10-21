using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering.LookDev;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public float countdownDuration = 3f; // �J�E���g�_�E���̎��ԁi�b�j
    public Text countdownText; // �e�L�X�g�I�u�W�F�N�g

    private void Start()
    {
        StartCoroutine(StartCountdown());
    }

    private IEnumerator StartCountdown()
    {
        float timer = countdownDuration;
       

        while (timer > 0)
        {            
            countdownText.text = timer.ToString("F0"); // F0�ŏ����_�ȉ��������������\���ɂ���
            yield return new WaitForSeconds(1f);
            timer--;
        }

        // �J�E���g�_�E���I����A�e�L�X�g��\��
        countdownText.text = "�X�^�[�g!";
        yield return new WaitForSeconds(1f);
        Destroy(countdownText);
    }
}
