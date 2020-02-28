using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySenoid : MonoBehaviour
{
    float yDistFromCommander;
    private void Start()
    {
        yDistFromCommander = transform.localPosition.y;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.parent.transform.position.y+yDistFromCommander+Mathf.Sin(transform.position.x));   
    }
}
