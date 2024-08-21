using System.Collections;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    private float stopPotion = 0;
    private Coroutine moveCoroutine = null;
    public GameObject startButtonObject;
    public GameObject titleObject;
    public GameObject seleteList1;
    public GameObject inputNameObject;
    public GameObject sendButton;

    void Start()
    {
        moveCoroutine = StartCoroutine(MoveCamera());
        sendButton.SetActive(false);
    }

    IEnumerator MoveCamera()
    {
        while (stopPotion > -510)
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
    public void startButton()
    {
        if (moveCoroutine != null)
        {
            StopCoroutine(moveCoroutine);
            moveCoroutine = null;
            startButtonObject.SetActive(false);
            titleObject.SetActive(false);
            seleteList1.SetActive(true);
            inputNameObject.SetActive(true);
            sendButton.SetActive(true);
            
        }

        // 특정 위치로 카메라
        transform.position = new Vector3(0, 1, 27.55f);
    
        // 카메라의 회전
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
    
    

}
