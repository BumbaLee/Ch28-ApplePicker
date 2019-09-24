using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    public GameObject applePrefab; //prefab for instantiating apples
    public float speed= 1f; //speed at which apple will move
    public float leftAndRightEdge= 10f; //distance where apple tree changes direction
    public float chanceToChangeDirections= 0.1f; //chance the apple tree changes directions without hitting edge
    public float secondsBetweenAppleDrops= 1f; //rate at which apples will be instantiated

    
    void Start(){
    // Dropping apples every second 
        
    }

    
    void Update() {

    // Basic Movement
    Vector3 pos= transform.position; //defines the Vector3 pos to be current position of Apple Tree
    pos.x = pos.x+ (speed*Time.deltaTime); //increases x pos value by speed times deltaTime
    //deltaTime is a measure of the seconds since the last frame. makes the movement of the appleTree TIME BASED
    transform.position= pos; //assigns this modified pos back to transform.position (which moves AppleTree to a new position)

    //Changing Directions    
    if(pos.x < -leftAndRightEdge){ //if tree is at left edge
        speed=Mathf.Abs(speed); //move right. sets speed to absolute value of speed, guaranteeing it will be positive
        //positive speed translates into movement to the right
    }else if (pos.x > leftAndRightEdge){ //if tree is at right edge
        speed=-Mathf.Abs(speed); //move left 
    }
    else if(Random.value<chanceToChangeDirections){ //
        speed= speed*-1; //change directions
    }

    }
}
