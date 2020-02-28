using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCommander : MonoBehaviour
{
    public float speed = 0.5f;
    public GameObject bullet;
    private float timeout = 0.5f;
    private float lastTimeMoved;
    private float lastTimeMovedDown;
    // Start is called before the first frame update
    void Start()
    {
        lastTimeMoved = Time.time;
        lastTimeMovedDown = lastTimeMoved;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time - lastTimeMoved > timeout) Move();
        if (transform.childCount == 0) GameManager.Instance.NextLevel();
    }

    void Move()
    {
        lastTimeMoved = Time.time;

        transform.position += new Vector3(speed, 0, 0);
        Shoot();

    }

    public void MoveDown() {
        if (Time.time - lastTimeMovedDown < 1) return;

        lastTimeMovedDown = Time.time;
        transform.position += new Vector3(0, -Mathf.Abs(speed), 0);
        speed = -speed;
    }

    void Shoot()
    {
        if (Random.value > 0.2) return;

        int chosenShooter = Random.Range(0, transform.childCount - 1);

        Instantiate(bullet, transform.GetChild(chosenShooter).transform);

    }


}
