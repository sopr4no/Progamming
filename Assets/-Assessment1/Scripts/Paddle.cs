using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assessment1
{ 

public class Paddle : MonoBehaviour
    {


    public KeyCode input;

    private Animator anim;
	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>(); 
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKey(input))
        {
            anim.SetBool("isOpened", true);
        }
        else
        {
            anim.SetBool("isOpened", false);
        }
	}
}
}
