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
        // ������ ������ ���� ����Ʈ�� ����� ����
        if(other.CompareTag("Bus"))
        {
            Debug.Log("���� ��ҽ��ϴ�.");


            humanPrefab.transform.position = humanRegenPoint.position;
            humanPrefab.transform.rotation = humanRegenPoint.rotation;

            // ������ hum�� �ڽ����� �ֱ�
            humanPrefab.transform.SetParent(humanRegenPoint);
            humanPrefab.SetActive(true);

            // 5���� hum�� setactive(false)
            StartCoroutine(DeactivateHum(humanPrefab, 5f));
        }

    }


    private IEnumerator DeactivateHum(GameObject gameobject, float time)
    {
        yield return new WaitForSeconds(time);
        gameobject.SetActive(false);
    }

}
