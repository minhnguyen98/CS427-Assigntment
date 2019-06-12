﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject characterObject;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject == characterObject) {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
