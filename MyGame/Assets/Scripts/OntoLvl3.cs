using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OntoLvl3: MonoBehaviour
{

    public GameObject cube2;

    void Start()
    {
        cube2.SetActive(true);
    }

    void Update()
    {

    }
    void OnTriggerEnter()
    {
        cube2.SetActive(false);
#pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel("Level 3");
#pragma warning restore CS0618 // Type or member is obsolete

    }
}

