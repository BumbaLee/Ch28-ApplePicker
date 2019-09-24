using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos2D= Input.mousePosition; //gets the current screen position of the mouse from Input
        mousePos2D.z= -Camera.main.transform.position.z; //camera's z position sets how far to push the mouse into 3D

        Vector3 mousePos3D= Camera.main.ScreenToWorldPoint(mousePos2D); //convert the point from 2D screen space into 3D game world space

        //move the x position of this Basket to the x position of the Mouse 
        Vector3 pos= this.transform.position;
        pos.x = mousePos3D.x; 
        this.transform.position= pos; 
    }

    void OnCollisionEnter(Collision coll){
        //find out what hits this basket
        GameObject collidedWith= coll.gameObject; 
        if(collidedWith.tag=="Apple"){ //if collided object is an Apple...
            Destroy(collidedWith); // ... FUCKING DESTROOOOY IIIIIIIT!!!
        }
    }
}
