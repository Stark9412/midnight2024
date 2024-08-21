using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human_Run : MonoBehaviour // 생성된 사람이 transform.foward로 걷게 하기
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
