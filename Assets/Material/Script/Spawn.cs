using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
        public GameObject ship;
        public float interval = 1;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("NextShip", interval, interval);
    }

    // Update is called once per frame
    void NextShip()
    {
        Instantiate (ship, transform.position, Quaternion.identity);
    }
}
