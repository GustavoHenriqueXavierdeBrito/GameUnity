using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UVScroll : MonoBehaviour
{
    public Vector2 speed;

    void Update(){
        GetComponent<Renderer> ().material.mainTextureOffset = speed * Time.time;
    }

}
