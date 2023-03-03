using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Gravity : MonoBehaviour
{
   
    public float gra = -9.8f;
    public Vector3 vel;
    public float strenth = 5f;
    float angel;


    
  
    private void Update()
    {
      

        if (Input.GetKeyDown(KeyCode.Space))
        {
            vel = Vector3.up * strenth;
        }

        //if(Input.touchCount > 0)
        //{
        //    Touch touch = Input.GetTouch(0);
        //    if(touch.phase == TouchPhase.Began)
        //    {
        //        vel = Vector3.up * strenth;
        //    }
        //}
        vel.y += 2f * (gra * Time.deltaTime);

        transform.position += vel * Time.deltaTime;

        angel = 0;
        if (vel.y < 0)
        {
            angel = Mathf.Lerp(0, -80, -vel.y / strenth);
        }
        transform.rotation = Quaternion.Euler(0, 0, angel);

    }

}
