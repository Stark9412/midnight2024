using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Simulation_Manager : MonoBehaviour
{
    public GameObject simulationStopPanel; // UI 패널을 GameObject로 선언


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnButtonClick1() // 시뮬레이션 종료 버튼을 눌러서 패널을 띄움
    {
        Debug.Log("anjsep ");
        SetActive(simulationStopPanel, true);
        
    }

    public void OnButtonClick2() // 진짜 종료
    {
        Debug.Log("Quit button clicked.");
        Application.Quit();
    }

    public void OnButtonClick3() // 돌아가기
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
