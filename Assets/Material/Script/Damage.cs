using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D col) {
        Destroy (col. gameObject);
        Destroy (gameObject);
    }
}
