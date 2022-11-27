using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 10f;
    private Vector3 myPosition;
    public SoundManager soundManager;
    void Start()
    {
        myPosition = transform.position;
        soundManager = new SoundManager();
    }

    void Update()
    {
        myPosition.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.position = myPosition;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "enemy")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }
    }
}
