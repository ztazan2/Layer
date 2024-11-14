using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMouseControl : MonoBehaviour
{
    private void Start()
    {
        //마우스 커서 화면에 잠금
        //Locked : 중앙에 잠김
        //Confined : 화면 테두리 안에 갇힘
        //None : 안잠금

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
