using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 8f;
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 temp = transform.position;
        temp.y -= speed * Time.deltaTime;
        transform.position = temp;
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
