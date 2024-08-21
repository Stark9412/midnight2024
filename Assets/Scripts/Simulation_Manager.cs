using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Simulation_Manager : MonoBehaviour
{
    public GameObject simulationStopPanel; // UI �г��� GameObject�� ����


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnButtonClick1() // �ùķ��̼� ���� ��ư�� ������ �г��� ���
    {
        Debug.Log("anjsep ");
        SetActive(simulationStopPanel, true);
        
    }

    public void OnButtonClick2() // ��¥ ����
    {
        Debug.Log("Quit button clicked.");
        Application.Quit();
    }

    public void OnButtonClick3() // ���ư���
    { 
        Debug.Log("Simulation stop button clicked.");
        SetActive(simulationStopPanel, false);
    }







    void SetActive(GameObject panel, bool isActive)
    {
        if (panel != null)
        {
            panel.SetActive(isActive);
        }
    }





}
