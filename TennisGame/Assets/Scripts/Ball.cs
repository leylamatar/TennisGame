using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
   
    public Text aiScore,playerScore;
    private int aiScoreInt = 0, playerScoreInt = 0;

    Vector3 initialpos;
    
    void Start()
    {
        initialpos = transform.position;
    }
   
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Detected");
        if (collision.transform.CompareTag("wall"))
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            transform.position = initialpos;

         }
       if (collision.transform.CompareTag( "AiScoreGround"))
        {
             playerScore.text = "Player : " + (++playerScoreInt).ToString();
             
        }
        else if (collision.transform.CompareTag("PlayerScoreGround") )
        {
         aiScore.text = "Ai: " + (++aiScoreInt).ToString();
         
        }
        
            
    }
}
