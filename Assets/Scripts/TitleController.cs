using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleController : MonoBehaviour
{
    [SerializeField]
    private Image gameStartImage;

    [SerializeField]
    private Image gameEndImage;

    private int selectImage = 1; //選択中のイメージ

    void Start()
    {
        ShowSelectedImage();
    }

    void Update()
    {
        SelectImage();
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            switch (selectImage)
            {
                case 1:
                    SelectOneActivation();
                    break;

                case 2:
                    SelectTwoActivation();
                    break;

                default:
                    break;
            }
        }
    } /// <summary>
      /// 選択中のイメージの切り替え
      /// </summary>
    private void SelectImage()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (selectImage > 1)
            {
                selectImage--;
                ShowSelectedImage();
                Debug.Log("プレイヤー選択中" + selectImage.ToString());
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (selectImage < 2)
            {
                selectImage++;
                ShowSelectedImage();
                Debug.Log("プレイヤー選択中" + selectImage.ToString());
            }
        }
    }
    //Startを押した後の処理
    private void SelectOneActivation()
    {
        SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
    }
    //Endを押した後の処理
    private void SelectTwoActivation()
    {
        Application.Quit();
    }
    /// <summary>
    /// 選択中の各イメージの状態等
    /// </summary>
    private void ShowSelectedImage()
    {
        if (selectImage == 1)
        {
            //ゲーム終了のアイコンを暗くする
            gameEndImage.color = new Color(0.5f, 0.5f, 0.5f, 1);
            gameStartImage.color = new Color(1, 1, 1, 1);
        }   
        else if (selectImage == 2)
        {
            //スタートのアイコンを暗くする
            gameStartImage.color = new Color(0.5f, 0.5f, 0.5f, 1);
            gameEndImage.color = new Color(1, 1, 1, 1);
        }
    }
}
