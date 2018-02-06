using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rocketscript : MonoBehaviour {
    Rigidbody _rigidBody;
    Transform _transform;
    public AudioSource sound;

    // Use this for initialization
    void Start() {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        ProcessInput();
    }
    private void ProcessInput(){

        if(Input.GetKey(KeyCode.Space)){
            _rigidBody.AddRelativeForce(Vector3.up * 45 * Time.deltaTime);
            sound.Play();
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * 100 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward * 100 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.O)) {
            SceneManager.LoadScene(0);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if ((col.gameObject.name != "Launchpad") && (col.gameObject.name != "Targetpad") &&
            (col.gameObject.name != "Launchpad (1)") && (col.gameObject.name != "Targetpad (1)") &&
            (col.gameObject.name != "Launchpad (2)") && (col.gameObject.name != "Targetpad (2)"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
