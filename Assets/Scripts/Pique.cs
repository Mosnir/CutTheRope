﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pique : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ScenesManager.instance.Reload();
        }
    }

}
