using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering.LookDev;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public float countdownDuration = 3f; // カウントダウンの時間（秒）
    public Text countdownText; // テキストオブジェクト

    private void Start()
    {
        StartCoroutine(StartCountdown());
    }

    private IEnumerator StartCountdown()
    {
        float timer = countdownDuration;
       

        while (timer > 0)
        {            
            countdownText.text = timer.ToString("F0"); // F0で小数点以下を除いた整数表示にする
            yield return new WaitForSeconds(1f);
            timer--;
        }

        // カウントダウン終了後、テキストを表示
        countdownText.text = "スタート!";
        yield return new WaitForSeconds(1f);
        Destroy(countdownText);
    }
}
