using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float moveSpeed;
    public float rotationSpeed;
    public Rigidbody rigidBody;
    public float jumpForce;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // using Input Manager
        float translation = Input.GetAxis("Vertical") * moveSpeed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(0,0,translation);
        transform.Rotate(0, rotation, 0);

        if (Input.GetButton("Jump"))
        {
            rigidBody.AddForce(new Vector3(0, jumpForce, 0));
        }

        //another way to move the object
        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.position += transform.forward * (Time.deltaTime * moveSpeed);
        //}


        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.Translate(Vector3.forward * (Time.deltaTime * moveSpeed));
        //}

        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.Translate(Vector3.back * (Time.deltaTime * moveSpeed));
        //}

        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(Vector3.left * (Time.deltaTime * moveSpeed));
        //}

        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.Translate(Vector3.right * (Time.deltaTime * moveSpeed));
        //}

        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Rotate(Vector3.right * (Time.deltaTime * moveSpeed));
        //}






    }
}
