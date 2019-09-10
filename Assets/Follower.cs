using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    Vector3 desired =  Vector3.zero;
    Vector3 velocity =  Vector3.zero;
    Vector3 steer =  Vector3.zero;

   public float MAX_SPEED = 5;
   public float MAX_STEER = 1;

   Transform target;

  

   void Update(){
       
       

       target = GameObject.Find("Target").transform;      
       Vector3 player = transform.position;
       
      

       desired = -(target.position - transform.position).normalized * MAX_SPEED;
       steer = Vector3.ClampMagnitude(desired - velocity, MAX_STEER);
       
       Vector3 screenPosition =  Camera.main.WorldToScreenPoint(transform.position);

       if( player.x >= -1  &&  player.x <= 1 && player.y >= -1 && player.y <= 1) 
       {
           print("u win");
            Destroy(this.gameObject);   
        }
       if( player.x > screenPosition.x || player.y > screenPosition.y) {
           print("u lose");
           Destroy(this.gameObject); 
           }


       velocity+=desired*Time.deltaTime;
       transform.position += velocity * Time.deltaTime;
   }   
}
