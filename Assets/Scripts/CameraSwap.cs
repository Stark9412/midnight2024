using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwap : MonoBehaviour // 1, 2�� ������ ī�޶� ����
{

    public Transform cameraPos1;
    public Transform cameraPos2;

    private Camera mainCamera;
    void Start()
    {
        // ���� ī�޶� ã���ϴ�.
        mainCamera = Camera.main; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            mainCamera.transform.position = cameraPos1.transform.position;
            mainCamera.transform.rotation = cameraPos1.transform.rotation;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            mainCamera.transform.position = cameraPos2.transform.position;
            mainCamera.transform.rotation = cameraPos2.transform.rotation;
        }


    }
}
