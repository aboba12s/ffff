using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public pingpong pingPong;

    private void OnBecameInvisible()
    {
        pingPong.Reset(transform.position.x);
    }





}