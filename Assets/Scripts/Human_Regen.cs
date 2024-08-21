using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human_Regen : MonoBehaviour
{
    public Transform humanRegenPoint;
    public GameObject humanPrefab;


    void Start()
    {
        
    }

    void Update()
    {
        

    }

    private void OnTriggerEnter(Collider other)
    {
        // 버스가 닿으면 리젠 포인트에 사람을 생성
        if(other.CompareTag("Bus"))
        {
            Debug.Log("벽에 닿았습니다.");

            GameObject hum = Instantiate(humanPrefab);

            hum.transform.position = humanRegenPoint.position;
            hum.transform.rotation = humanRegenPoint.rotation;

            // 생성된 hum을 자식으로 넣기
            hum.transform.SetParent(humanRegenPoint);

            // 5초후 hum을 setactive(false)
            StartCoroutine(DeactivateHum(hum, 5f));
        }

    }


    private IEnumerator DeactivateHum(GameObject gameobject, float time)
    {
        yield return new WaitForSeconds(time);
        gameobject.SetActive(false);
    }

}
