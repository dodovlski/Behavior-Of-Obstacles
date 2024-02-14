using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int score = 0;

    private void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag("Hit"))
        {
            score++;
            Debug.Log("You've bumped into a thing " + score + "  times");
        }
      
        
        
    }
}