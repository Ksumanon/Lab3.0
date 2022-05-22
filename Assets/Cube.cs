using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cube : MonoBehaviour
{
    float movex, movez, movey;
    float speed = 10.0f;
    void Update()
    {
        movex = Input.GetAxis("Horizontal")*speed;
        movez = Input.GetAxis("Vertical")*speed;
        movey = Input.GetAxis("Jump")*speed;
        GetComponent<Rigidbody>().AddForce(new Vector3(movex, 0f, movez)); ;
        GetComponent<Rigidbody>().AddForce(new Vector3(0f, movey, 0f));
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu", LoadSceneMode.Single);
        }
    }
}
