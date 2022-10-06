using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameManager gm;
    public float speed=5;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            gm.pickupcollected(gameObject); 
        }
    }
    private void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime * speed);
    }
}
