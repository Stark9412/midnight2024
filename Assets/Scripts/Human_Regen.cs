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

            GameObject hum = Instantiate(humanPrefab);

            hum.transform.position = humanRegenPoint.position;

            // ������ hum�� �ڽ����� �ֱ�
            hum.transform.parent = humanRegenPoint.transform;

            // 5���� hum�� setactive(false)
            StartCoroutine(DeactivateHum(hum, 5f));
        }

    }


    private IEnumerator DeactivateHum(GameObject gameobject, float time)
    {
        yield return new WaitForSeconds(time);
        gameobject.SetActive(false);
    }

}
