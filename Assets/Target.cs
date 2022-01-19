using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    public Scoring score;
    public int amount;

    void OnTriggerEnter(Collider collision)
    {
        score.IncreaseScore(amount);

    }




}
