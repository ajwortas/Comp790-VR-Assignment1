using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBall : MonoBehaviour
{

    void OnTriggerEnter(Collider collision)
    {
        Destroy(collision.gameObject);

    }

}
