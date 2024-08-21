using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusSlow_Tirgger : MonoBehaviour // 버스가 닿으면 최대속도를 n값으로 줄이는 트리거 박스
{

    BusNav_Controller bus;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        //안에 있을때 속도가 느려지게
        BusNav_Controller bus = other.GetComponent<BusNav_Controller>();

        if (bus != null)
        {
            bus.maxSpeed = 20;
        }
    }

    private void OnTriggerExit(Collider other)
    { 
        // stay 콜라이더 밖에 나오면 
        bus = other.GetComponent<BusNav_Controller>();

        if (bus != null)
        {
            bus.maxSpeed = 50;
        }
    }
}
