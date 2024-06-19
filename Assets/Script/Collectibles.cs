using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    public bool isCoins = true;
    public int speedDuration;
    public float addSpeed;
    private void OnTriggerEnter(Collider other)
    {
        if(isCoins) 
        {
            Destroy(gameObject);
            PlayerControls pc = other.GetComponent<PlayerControls>();
            pc.moveSpeed = pc.moveSpeed + addSpeed;
            pc.score++;
        }
    }
}
