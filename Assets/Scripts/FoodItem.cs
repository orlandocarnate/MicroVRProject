using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodItem : MonoBehaviour
{
    public MeshRenderer mr;
    public float CookRate;
    private bool isCooking;

    // Update is called once per frame
    void Update()
    {
        // update color over time while food is on CookSurface
        if(isCooking)
        {
            // Lerp params: (current object color, target color, rate)
            mr.material.color = Color.Lerp(mr.material.color, Color.black, CookRate * Time.deltaTime);
        }
    }

    // if object enters tagged object named CookSurface
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("CookSurface"))
        {
            isCooking = true;
        }
            
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("CookSurface"))
        {
            isCooking = false;
        }   
    }
}
