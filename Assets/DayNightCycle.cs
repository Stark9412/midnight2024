using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public Light directionalLight;  // Directional Light를 연결합니다.
    public float dayDuration = 120f;  // 하루가 지나가는 시간(초)
    public float nightIntensity = 0f; // 밤에 적용할 Light의 밝기
    public float dayIntensity = 1f;   // 낮에 적용할 Light의 밝기

    private float _time;
    
    void Update()
    {
        // 시간 진행
        _time += Time.deltaTime;
        if (_time > dayDuration)
        {
            _time = 0;
        }

        // 시간에 따라 Light 회전
        float angle = (_time / dayDuration) * 360f;
        directionalLight.transform.rotation = Quaternion.Euler(new Vector3(angle - 90f, 170f, 0));

        // 밤과 낮에 따른 Light intensity 조절
        if (angle > 180f) // 밤일 때 (180도에서 360도 사이)
        {
            directionalLight.intensity = nightIntensity;
        }
        else // 낮일 때 (0도에서 180도 사이)
        {
            directionalLight.intensity = dayIntensity;
        }
    }
}