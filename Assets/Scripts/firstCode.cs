using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstCode : MonoBehaviour
{
    public float moveSpeed;
    float xDirection;

    // Update is called once per frame
    void Update()
    {
        moveSpeed = 8;
        xDirection = Input.GetAxisRaw("Horizontal"); // -1 if left , 1 if right
        float moveStep = moveSpeed * xDirection * Time.deltaTime;
        if ((transform.position.x >= 7f && xDirection > 0) || (transform.position.x <= -7 && xDirection < 0))
            return;

        transform.position = transform.position + new Vector3(moveStep, 0, 0);

    }
}
