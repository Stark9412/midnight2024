using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanRegen_Trigger : MonoBehaviour
{
    public Transform humanRunDestination;
    public GameObject humanPrefab;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //������ ��������
        if(other.CompareTag("Bus"))
        {
            // ��� �������� �����ϰ�
           GameObject humanRun = Instantiate(humanPrefab);

            // humanRunDestination ���� �����Ѵ�.
            humanRun.transform.position = humanRunDestination.position;
    

           


        }

    }


}
