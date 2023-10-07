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

    private int selectImage = 1; //�I�𒆂̃C���[�W

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
      /// �I�𒆂̃C���[�W�̐؂�ւ�
      /// </summary>
    private void SelectImage()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (selectImage > 1)
            {
                selectImage--;
                ShowSelectedImage();
                Debug.Log("�v���C���[�I��" + selectImage.ToString());
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (selectImage < 2)
            {
                selectImage++;
                ShowSelectedImage();
                Debug.Log("�v���C���[�I��" + selectImage.ToString());
            }
        }
    }
    //Start����������̏���
    private void SelectOneActivation()
    {
        SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
    }
    //End����������̏���
    private void SelectTwoActivation()
    {
        Application.Quit();
    }
    /// <summary>
    /// �I�𒆂̊e�C���[�W�̏�ԓ�
    /// </summary>
    private void ShowSelectedImage()
    {
        if (selectImage == 1)
        {
            //�Q�[���I���̃A�C�R�����Â�����
            gameEndImage.color = new Color(0.5f, 0.5f, 0.5f, 1);
            gameStartImage.color = new Color(1, 1, 1, 1);
        }   
        else if (selectImage == 2)
        {
            //�X�^�[�g�̃A�C�R�����Â�����
            gameStartImage.color = new Color(0.5f, 0.5f, 0.5f, 1);
            gameEndImage.color = new Color(1, 1, 1, 1);
        }
    }
}
