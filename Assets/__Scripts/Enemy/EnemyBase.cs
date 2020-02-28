using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {
        
        if(Mathf.Abs(transform.position.x) > GameManager.ScreenBounds)
        {
            SendMessageUpwards("MoveDown");
        }
    }


}
