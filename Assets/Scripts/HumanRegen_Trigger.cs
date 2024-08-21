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
        //버스가 지나가면
        if(other.CompareTag("Bus"))
        {
            // 사람 프레펍을 생성하고
           GameObject humanRun = Instantiate(humanPrefab);

            // humanRunDestination 에서 생성한다.
            humanRun.transform.position = humanRunDestination.position;
    

           


        }

    }


}
