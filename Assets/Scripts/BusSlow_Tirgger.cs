using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusSlow_Tirgger : MonoBehaviour // ������ ������ �ִ�ӵ��� n������ ���̴� Ʈ���� �ڽ�
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
        //�ȿ� ������ �ӵ��� ��������
        BusNav_Controller bus = other.GetComponent<BusNav_Controller>();

        if (bus != null)
        {
            bus.maxSpeed = 20;
        }
    }

    private void OnTriggerExit(Collider other)
    { 
        // stay �ݶ��̴� �ۿ� ������ 
        bus = other.GetComponent<BusNav_Controller>();

        if (bus != null)
        {
            bus.maxSpeed = 50;
        }
    }
}
