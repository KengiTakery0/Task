using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    public float moveDir;
    public bool isJumped;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            moveDir = -1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveDir = 1;
        }
        else moveDir = 0;

        if (Input.GetKey(KeyCode.Space))
        {
            isJumped = true;
        }
        else isJumped = false;
    }
}
