using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{

    public float moveSpeed;
    public  float xDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxisRaw("Horizontal");
        // Debug.Log(xDirection);
        float moveStep = moveSpeed * xDirection * Time.deltaTime;
        //Debug.Log(moveStep);

        if((transform.position.x <= -10.4 && xDirection <0 )|| (transform.position.x >= 10.3 && xDirection >0))
        {
            return ;
        }
        transform.position = transform.position + new Vector3(moveStep, 0, 0);
        
    }
}
