﻿using UnityEngine;
using System.Collections;

public class FlipperScript : MonoBehaviour {
    Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.RightControl))
        {
            anim.SetBool("Flipper", true);
        }

        if (Input.GetKeyUp(KeyCode.RightControl))
        {
            anim.SetBool("Flipper", false);
        }
	
	}
}
