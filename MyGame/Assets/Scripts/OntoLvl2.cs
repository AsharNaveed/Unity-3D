using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OntoLvl2 : MonoBehaviour
{

    public GameObject cube;

    void Start()
    {
        cube.SetActive(true);
    }

    void Update()
    {

    }
    void OnTriggerEnter()
    {

        cube.SetActive(false);
#pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel("Level 2");
#pragma warning restore CS0618 // Type or member is obsolete

    }
}
