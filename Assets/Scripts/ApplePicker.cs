using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    public GameObject basketPrefab;
    public int numBaskets= 3;
    public float basketBottomY= -14f;
    public float basketSpacingY= 2f;
    public List<GameObject> basketList; 

    // Start is called before the first frame update
    void Start(){ //instantiates three copies of the Basket prefab that are spaced out vertically 
        basketList= new List<GameObject>(); 
        for(int i=0; i<numBaskets; i++){
            GameObject tBasketGo= Instantiate<GameObject>(basketPrefab); 
            Vector3 pos= Vector3.zero; //create new Vector3 variable named pos, set it to (0,0,0)
            pos.y= basketBottomY+(basketSpacingY*i);//change pos variable's vector y value 
            tBasketGo.transform.position= pos; //sets created basket object's position to pos 
            basketList.Add(tBasketGo); //adds basket to basketlist. added bottom to top
        }
    }

    public void AppleDestroyed(){
        //Destroy all of the falling apples
        GameObject[] tAppleArray= GameObject.FindGameObjectsWithTag("Apple"); //create and return an array of all existing Apple GameObjects
        foreach (GameObject tGo in tAppleArray){ //foreach loop goes through array and destroys each Apple GameObject
            Destroy(tGo);
        }
        //Destroy one of the baskets
        int basketIndex= basketList.Count-1; //get the index of the last basket in basketList
        GameObject tBasketGo= basketList[basketIndex]; //get reference to that basket game object
        //Remove the Basket from the list and destroy the GameObject
        basketList.RemoveAt(basketIndex);
        Destroy(tBasketGo);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
