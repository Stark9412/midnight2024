using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CameraManager : MonoBehaviour
{
    private float stopPotion = 0;
    private Coroutine moveCoroutine = null;
    
    //UI
    public GameObject button_Layout_Object;
    public GameObject inputName_Object;
    public Text input_Name;
    public Image errorMessage;
    public GameObject list_Object;
    public Text yourName;

    void Start()
    {
        moveCoroutine = StartCoroutine(MoveCamera());
        inputName_Object.SetActive(false);
        errorMessage.gameObject.SetActive(false);
        list_Object.SetActive(false);
    }

    IEnumerator MoveCamera()
    {
        while (stopPotion > -550)
        {
            Vector3 position = transform.position;
            
            // 카메라 떨어지는 속도
            position.y -= 0.5f;
            stopPotion -= 0.5f;
            
            transform.position = position;
            yield return null;
        }
    }
    
    // Button Event Function
    public void playButton()
    {
        if (moveCoroutine != null)
        {
            StopCoroutine(moveCoroutine);
            moveCoroutine = null;
            
        }

        // 특정 위치로 카메라
        transform.position = new Vector3(0, 1, 27.55f);
    
        // 카메라의 회전
        transform.rotation = Quaternion.Euler(0, 0, 0);
        
        // false
        button_Layout_Object.SetActive(false);
        
        //True
        inputName_Object.SetActive(true);
    }

    public void okBtn()
    {
        if (string.IsNullOrEmpty(input_Name.text))
        {
            errorMessage.gameObject.SetActive(true);
            Invoke("errorMessageActiveFalse",3f);
        }
        else
        {
            Debug.Log("OK_Click");
            inputName_Object.SetActive(false);
            list_Object.SetActive(true);
            yourName.text = input_Name.text + " 님 반갑습니다.";
        }
    }

    public void errorMessageActiveFalse()
    {
        errorMessage.gameObject.SetActive(false);
    }

    public void seletedListNum()
    {
        Debug.Log("선택이 완료됨");
        list_Object.SetActive(false);
    }

    
    

}
