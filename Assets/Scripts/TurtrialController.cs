using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtrialController : MonoBehaviour
{
    [SerializeField]
    private Canvas firstCanvas, secondCanvas, threeCanvas;

    private int selectCanvas = 1; //選択中のイメージ
    // Start is called before the first frame update
    void Start()
    {
        ShowSelectedCanvas();
    }

    // Update is called once per frame
    void Update()
    {
        SelectCanvas();
    }

    private void SelectCanvas()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (selectCanvas == 1)
            {
                selectCanvas++;
                ShowSelectedCanvas();
                Debug.Log("プレイヤー選択中" + selectCanvas.ToString());
            }
            else if (selectCanvas == 2)
            {
                selectCanvas++;
                ShowSelectedCanvas();
                Debug.Log("プレイヤー選択中" + selectCanvas.ToString());
            }
            else if (selectCanvas == 3)
            {
                selectCanvas++;
                ShowSelectedCanvas();
                Debug.Log("プレイヤー選択中" + selectCanvas.ToString());
            }
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            if (selectCanvas == 1)
            {
                selectCanvas--;
                ShowSelectedCanvas();
                Debug.Log("プレイヤー選択中" + selectCanvas.ToString());
            }
            else if (selectCanvas == 2)
            {
                selectCanvas--;
                ShowSelectedCanvas();
                Debug.Log("プレイヤー選択中" + selectCanvas.ToString());
            }
            else if (selectCanvas == 3)
            {
                selectCanvas--;
                ShowSelectedCanvas();
                Debug.Log("プレイヤー選択中" + selectCanvas.ToString());
            }
        }
    }

    private void ShowSelectedCanvas()
    {
        if (selectCanvas == 1)
        {
            firstCanvas.enabled = true;
            secondCanvas.enabled = false;
            threeCanvas.enabled = false;
        }
        else if (selectCanvas == 2)
        {
            firstCanvas.enabled = false;
            secondCanvas.enabled = true;
            threeCanvas.enabled = false;
        }
        else if (selectCanvas == 3)
        {
            firstCanvas.enabled = false;
            secondCanvas.enabled = false;
            threeCanvas.enabled = true;
        }
        else if (selectCanvas == 4)
        {
            
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneLoader.Instance.LoadScene("GameScene");
            }
        }
    }
}
