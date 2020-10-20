/* BackgroundController.cs
 * 
 * Samuel Ko
 * 101168049
 * Last Modified: 2020-10-20
 * 
 * Scrolls background.
 * 
 * 2020-10-20: Swapped veritcal movement with horizontal movement.
 */ 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    /*
     * Reverse vertical movement to horizontal,
     * which is just swapping the x and y values in the vectors.
     */ 

    public float horizontalSpeed;
    public float horizontalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        transform.position = new Vector3(horizontalBoundary, 0.0f);
    }

    private void _Move()
    {
        transform.position -= new Vector3(horizontalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.x <= -horizontalBoundary)
        {
            _Reset();
        }
    }
}
