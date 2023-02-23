using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    
    public int sec = -1;
    public int min = 0;
    public Text TimerText;
    public bool tmp = true;
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(TimeFlow());
    }

    void Update()
    {
        
    }

    IEnumerator TimeFlow()
    {
        if (tmp == false)
        {
            TimerText.text = "00" + ":" + "00";
        }
        while(tmp == true)
        {
                if (sec == 59)
                {
                    min++;
                    sec = -1;
                }
                sec++;
                TimerText.text = min.ToString("D2") + ":" + sec.ToString("D2");
                yield return new WaitForSeconds(1);
                

        }
    }

    
}
