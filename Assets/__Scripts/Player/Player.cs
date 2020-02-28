using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Velocidade do player")]
    public float speed = 25.0f;

    [Header("Bullet prefab")]
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dh = Input.GetAxis("Horizontal");
        if((transform.position.x > -GameManager.ScreenBounds || dh > 0) &&
            (transform.position.x < GameManager.ScreenBounds || dh < 0))
        {
            transform.position += Vector3.right * dh * speed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject _bullet = Instantiate(bullet);
            _bullet.transform.position = transform.position;

        }

    }
}
