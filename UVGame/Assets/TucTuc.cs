using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TucTuc : MonoBehaviour
{
    public float force = 65f;
    private Vector3 moveTo;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        moveTo = new Vector3(horizontalMovement, 0, verticalMovement);

    }

    private void FixedUpdate()
    {
        if (moveTo.magnitude > 0.1)
        {
            rb.AddForce(force * moveTo);
            transform.forward = -moveTo;
        }
    }
}
