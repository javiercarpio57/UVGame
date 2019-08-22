using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    CharacterController characterController;
    public float speed = 0.1f;
    private Vector3 moveDirection = Vector3.zero;
    private Vector3 rotation;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, 50.631f, transform.position.z);
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        rotation = new Vector3(moveHorizontal, 0, moveVertical);

        if (rotation != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(rotation);
        }

        moveDirection = new Vector3(moveHorizontal, 0, moveVertical) * speed;

        if (moveDirection != Vector3.zero)
        {
            characterController.Move(moveDirection);
        }
    }
}
