using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountController : MonoBehaviour
{
    [SerializeField]
    private float startCountdownTimer = 3f; // �ŏ��̃J�E���g�_�E���̎���

    [SerializeField]
    private float gameCountdownTimer = 60f; // �v���C���̃J�E���g�_�E���̎���

    [SerializeField]
    private Text startCountdownText; // �ŏ��̃J�E���g�e�L�X�g�I�u�W�F�N�g

    [SerializeField]
    private Text gameCountdownText; // �v���C���̃J�E���g�e�L�X�g�I�u�W�F�N�g

    [SerializeField]
    private Text finishText; //�t�B�j�b�V����\������e�L�X�g

    private void Start()
    {
        StartCoroutine(StartCountdown());
    }

    //�Q�[���J�n�O�̃J�E���g�_�E��
    private IEnumerator StartCountdown()
    {
        float startCount = startCountdownTimer;

        while (startCount > 0)
        {
            startCountdownText.text = startCount.ToString("F0");
            yield return new WaitForSeconds(1f);
            startCount--;
        }

        startCountdownText.text = "�X�^�[�g!";
        yield return new WaitForSeconds(1f);
        Destroy(startCountdownText);
        StartCoroutine(CountDown());
    }

    //�Q�[���J�n��̃J�E���g�_�E��
    private IEnumerator CountDown()
    {
        float gameCount = gameCountdownTimer;

        while (gameCount > 0)
        {
            gameCountdownText.text = gameCount.ToString("F0");
            yield return new WaitForSeconds(1f);
            gameCount--;
        }
        Destroy(gameCountdownText);
        finishText.text = "�t�B�j�b�V��!";
        yield return new WaitForSeconds(3f);
        SceneLoader.Instance.LoadScene("ResultScene");
    }
}
