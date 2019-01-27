using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed = 6f;
    private void FixedUpdate()
    {
        //Check input axes
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(h, v) * Speed;

        //Set Animation Parameter
        GetComponent<Animator>().SetInteger("X", (int)h);
        GetComponent<Animator>().SetInteger("Y", (int)v);
    }
    private void Update()
    {
    if(Input.GetKeyDown(KeyCode.Escape))
     {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
     }


    }
        
}

