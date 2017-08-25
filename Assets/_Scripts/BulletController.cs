﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public float speed;
    private void Start()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = transform.forward * speed;
    }
}
