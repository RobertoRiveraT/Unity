﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveController : MonoBehaviour
{
    private Transform prevParent;
    private void OnCollisionEnter2D(Collision2D other)     
    {
        Debug.Log(other);
        prevParent = other.gameObject.transform.parent;
        other.gameObject.transform.parent = gameObject.transform;
    }
    private void OnCollisionExit2D(Collision2D other) {
        other.gameObject.transform.parent = prevParent;
    }
}
