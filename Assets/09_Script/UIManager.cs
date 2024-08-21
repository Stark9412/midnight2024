using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject SeletMenu1;
    public GameObject InputNameObject;
    public Text useName;
    public GameObject sendButton;

    private void Start()
    {
        SeletMenu1.SetActive(false);
        InputNameObject.SetActive(false);
    }

    private void Update()
    {
        if (useName.text == null)
        {
            throw new NotImplementedException();
        }
    }
}
