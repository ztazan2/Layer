using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoock : MonoBehaviour
{
    public Transform cameraRig;

    public float mouseSensivity;

    private float rigAngle = 0f;

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X"); //���콺�� ������ delta
        float mouseY = Input.GetAxis("Mouse Y");

        //���콺�� �¿� �����ӿ� ���� ĳ������ Transform�� Rotate
        transform.Rotate(0, mouseX * mouseSensivity * Time.deltaTime, 0);

        rigAngle -= mouseY * mouseSensivity * Time.deltaTime;
        //ī�޶��� x�� ������ ���� 
        rigAngle = Mathf.Clamp(rigAngle, -90f, 90f);

        //���ѵ� ������ŭ ī�޶��� x�� ������ ����
        cameraRig.localEulerAngles = new Vector3(rigAngle, 0, 0);
        
        //���콺�� ���� �����ӿ� ���� ī�޶� ������ Transform�� Rotate
        //cameraRig.Rotate(-mouseY * mouseSensivity * Time.deltaTime, 0, 0);
    }
}
