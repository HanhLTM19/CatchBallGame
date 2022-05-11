using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    public float moveSpeed;
    float xDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //bam sang trai la -1, sang phai la 1
        xDirection = Input.GetAxisRaw("Horizontal");
        float moveStep = moveSpeed * xDirection * Time.deltaTime;
        //Gioi han vung di chuyen cua line
        if ((transform.position.x <=-12.5 && xDirection < 0) || (transform.position.x >= 12.5 && xDirection > 0))
        {
            return;
        }
        //thay doi gia tri position khi di chu
        Vector3 movement = new Vector3(moveStep, 0, 0);
        transform.position += movement;
    }
}
