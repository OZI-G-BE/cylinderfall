using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreup : MonoBehaviour
{
    public static float scorevalue = 0f;
    Text scoretext;
    public Text hiscore;
    void Start()
    {
        scoretext = GetComponent<Text>();
        hiscore.text = "BEST:" + PlayerPrefs.GetFloat("Hiscore", 0f);
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.Space)){PlayerPrefs.DeleteKey("Hiscore");
        hiscore.text = "BEST:0";
        }        


        scoretext.text = scorevalue.ToString() + "Ft";
        if (scorevalue > PlayerPrefs.GetFloat("Hiscore", 0f))
       { PlayerPrefs.SetFloat("Hiscore", scorevalue);
            hiscore.text = "BEST:" + scorevalue;
       }
    }
}
