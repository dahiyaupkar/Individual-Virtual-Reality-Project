using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class timerTwo : MonoBehaviour {
    Image fillImg;
    float timeAmt = 30;
    float time;
    public Text timeText;
    public Image splashImage;
    public string loadLevel;

    // Use this for initialization
    void Start () {
        fillImg = this.GetComponent<Image>();
        time = timeAmt;
    }

    // Update is called once per frame
    void Update () {
        if(time  > 0){
            time -= Time.deltaTime;
            fillImg.fillAmount = time / timeAmt;
            timeText.text = "Time : "+time.ToString("F");
        }
        else
        {
            SceneManager.LoadScene(loadLevel);
        }
    }
}
