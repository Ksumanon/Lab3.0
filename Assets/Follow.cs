using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

    private void Start()
    {

    }
    public Transform GameObject;
    void Update()
    {

        transform.LookAt(GameObject);
    }
}