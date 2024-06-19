using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    public bool isCoins = true;
    public float speedMultiplier;
    public float rotateSpeed;
    void Update()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
    }


    private void OnTriggerEnter(Collider other)
    {
        if(isCoins) 
        {
            PlayerControls pc = other.GetComponent<PlayerControls>();
            Destroy(gameObject);
            pc.newMoveSpeed = pc.moveSpeed * speedMultiplier;
            pc.score++;
            pc.startTime = true;
        }
    }
}
