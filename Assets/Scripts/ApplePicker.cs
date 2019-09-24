using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePicker : MonoBehaviour
{
    public GameObject basketPrefab;
    public int numBaskets= 3;
    public float basketBottomY= -14f;
    public float basketSpacingY= 2f;

    // Start is called before the first frame update
    void Start(){ //instantiates three copies of the Basket prefab that are spaced out vertically 
        for(int i=0; i<numBaskets; i++){
            GameObject tBasketGo= Instantiate<GameObject>(basketPrefab); 
            Vector3 pos= Vector3.zero; //create new Vector3 variable named pos, set it to (0,0,0)
            pos.y= basketBottomY+(basketSpacingY*i);//change pos variable's vector y value 
            tBasketGo.transform.position= pos; //sets created basket object's position to pos 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
