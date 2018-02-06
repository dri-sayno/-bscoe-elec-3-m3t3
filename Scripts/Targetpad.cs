using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Targetpad : MonoBehaviour
{
    GameObject Rocket;
    float dist;
    private void Start()
    {
        Rocket = GameObject.Find("Rocket");
    }

    private void Update()
    {
        Renderer rend = GetComponent<Renderer>();
        Color color = Color.grey;
        dist = Vector3.Distance(Rocket.transform.position, transform.position);

        if (dist <= 20)
        {
            rend.material.color = color;
        }
        if (dist < 11)
        {
            rend.material.color = Color.green;
            SceneManager.LoadScene(1);
        }
    }
}
