using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CubeGameUI : MonoBehaviour
{
    public TextMeshProUGUI TimerText;       //UI 선언
    public float Timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Timer += Time.deltaTime;
        TimerText.text = "생존시간:" + Timer.ToString("0.00");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
