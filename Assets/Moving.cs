using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public int amountZ, amountY, amountX, duration;
    public float count=0;
    private bool moveLeft=true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(count > duration)
        {
            count = 0;
            moveLeft = !moveLeft;
        }
        count+=Time.deltaTime;
        if (moveLeft)
        {
            transform.position = transform.position + new Vector3(amountX, amountY, amountZ) * Time.deltaTime;
        }
        else
        {
            transform.position = transform.position + new Vector3(-amountX, -amountY, -amountZ) * Time.deltaTime;
        }

    }
}
