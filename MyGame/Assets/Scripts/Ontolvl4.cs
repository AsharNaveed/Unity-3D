using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Ontolvl4: MonoBehaviour
{

    public GameObject cube3;

    void Start()
    {
        cube3.SetActive(true);
    }

    void Update()
    {

    }
    void OnTriggerEnter()
    {
        cube3.SetActive(false);
#pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel("Level 1");
#pragma warning restore CS0618 // Type or member is obsolete

    }
}


