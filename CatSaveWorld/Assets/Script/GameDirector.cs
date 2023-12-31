using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    GameObject timeText;
    GameObject openNumText;
    float time = 20.0f;
    int openNum = 18;
    // Start is called before the first frame update
    public void OpenCardNum()
    {
        this.openNum--;
        if(this.openNum<0)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
    void Start()
    {
        this.timeText = GameObject.Find("Time");
        this.openNumText = GameObject.Find("OpenNum");
    }

    // Update is called once per frame
    void Update()
    {
        this.time -= Time.deltaTime;
        
        this.timeText.GetComponent<Text>().text = "남은 시간: " + this.time.ToString("F1") + "초";
        this.openNumText.GetComponent<Text>().text = "뒤집기 횟수 : " + this.openNum.ToString() + "회";
        if(this.time<0)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
