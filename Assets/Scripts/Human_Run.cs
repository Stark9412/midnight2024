using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human_Run : MonoBehaviour // ������ ����� transform.foward�� �Ȱ� �ϱ�
{
    float humWalkSpeed = 8f;


    void Start()
    {
        
    }

    void Update()
    {
        Vector3 humdir = transform.forward * humWalkSpeed * Time.deltaTime; 

        transform.position += humdir;


    }


}
