using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

    public Rigidbody rb;

    // Update is called once per frame
    void Update () {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
	}
}
