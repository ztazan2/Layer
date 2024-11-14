using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMouseControl : MonoBehaviour
{
    private void Start()
    {
        //���콺 Ŀ�� ȭ�鿡 ���
        //Locked : �߾ӿ� ���
        //Confined : ȭ�� �׵θ� �ȿ� ����
        //None : �����

        OnApplicationFocus(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isFocusing = false;
        }
     
    }

    public static bool isFocusing = true;

    private void OnApplicationFocus(bool focus)
    {
        isFocusing = focus;

        if(isFocusing)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        else 
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
