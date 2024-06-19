using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float moveSpeed;
    public float newMoveSpeed;
    public float rotationSpeed;
    public float jumpForce;
    public int speedDuration;
    public float timer;
    public int score = 0;
    public bool startTime = false;
    public Rigidbody rigidBody;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        newMoveSpeed = moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        // using Input Manager
        float translation = Input.GetAxis("Vertical") * newMoveSpeed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(0,0,translation);
        transform.Rotate(0, rotation, 0);

        

        if (Input.GetButton("Jump"))
        {
            rigidBody.AddForce(new Vector3(0, jumpForce, 0));
        }

        if (startTime == true)
        {
            timer += Time.deltaTime;
            if (timer >= speedDuration)
            {
                newMoveSpeed = moveSpeed;
                startTime = false;
                timer = 0f;
            }
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
