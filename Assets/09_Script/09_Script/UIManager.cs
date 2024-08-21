using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // 어플 종료
    public void exitApp()
    {
        Debug.Log("종료");
        Application.Quit();
    }
}
