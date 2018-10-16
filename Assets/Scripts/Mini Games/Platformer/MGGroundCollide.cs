using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGGroundCollide : MonoBehaviour {

public bool isGrounded = true;

    // ...

    void OnCollisionStay(Collision other)
    {
        isGrounded = true;
        Debug.Log("player is on air");
    }

    void OnCollisionExit(Collision other)
    {
        isGrounded = false;
        Debug.Log("player is not on air");
    }
}
