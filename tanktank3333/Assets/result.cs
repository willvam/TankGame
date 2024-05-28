using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class result : MonoBehaviour
{

    public Text myScore;
    public Text myTimer;
    public Text myResult;
    public float timer = 10.0f;
    private int thisscore =  NewBehaviourScript1.score ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myScore.text = NewBehaviourScript1.score.ToString();

        if(timer>0)
        {
            timer -= Time.deltaTime;
            myTimer.text = timer.ToString();

            if (timer <= 0 && thisscore >= 80)
            {
                myTimer.text = "0";
                myResult.text = "YOU WIN!!";
                
            }
            else if(timer <= 0 && thisscore < 80)
            {
                myTimer.text = "0";
                myResult.text = "Game Over~";
            }

        }
    }
}
