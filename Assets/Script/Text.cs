using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Text : MonoBehaviour
{
    public TextMeshProUGUI score, speed, duration;
    public float timeLeft;
    private PlayerControls pc;
    // Start is called before the first frame update
    void Start()
    {
        pc = GetComponent<PlayerControls>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pc != null)
        {
            score.text = "Score: " + pc.score.ToString();
            speed.text = "Speed: " + pc.newMoveSpeed.ToString();
            
            timeLeft = pc.speedDuration - pc.timer;
            duration.text = "Speed boost time left: " + (Mathf.RoundToInt(timeLeft).ToString()) + "s";
            if (timeLeft >= pc.speedDuration)
            {
                duration.text = "";
            }
        }
    }
}
