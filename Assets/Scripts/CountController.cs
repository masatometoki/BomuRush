using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountController : MonoBehaviour
{
    [SerializeField]
    private float startCountdownTimer = 3f; // 最初のカウントダウンの時間

    [SerializeField]
    private float gameCountdownTimer = 60f; // プレイ中のカウントダウンの時間

    [SerializeField]
    private Text startCountdownText; // 最初のカウントテキストオブジェクト

    [SerializeField]
    private Text gameCountdownText; // プレイ中のカウントテキストオブジェクト

    [SerializeField]
    private Text finishText; //フィニッシュを表示するテキスト

    private void Start()
    {
        StartCoroutine(StartCountdown());
    }

    //ゲーム開始前のカウントダウン
    private IEnumerator StartCountdown()
    {
        float startCount = startCountdownTimer;

        while (startCount > 0)
        {
            startCountdownText.text = startCount.ToString("F0");
            yield return new WaitForSeconds(1f);
            startCount--;
        }

        startCountdownText.text = "スタート!";
        yield return new WaitForSeconds(1f);
        Destroy(startCountdownText);
        StartCoroutine(CountDown());
    }

    //ゲーム開始後のカウントダウン
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
        finishText.text = "フィニッシュ!";
        yield return new WaitForSeconds(3f);
        SceneLoader.Instance.LoadScene("ResultScene");
    }
}
