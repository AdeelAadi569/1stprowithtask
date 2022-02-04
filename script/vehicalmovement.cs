using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vehicalmovement : MonoBehaviour
{
    public GameObject players;
    public Transform playerpos;
    public float speed=5.0f,turnspeed=5.0f;
    private float horizontalinput,verticalinput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //for player move to forward
       // transform.Translate(0,0,1);
      // transform.Translate(Vector3.forward);
      horizontalinput=Input.GetAxis("Horizontal");
      verticalinput=Input.GetAxis("Vertical");
      transform.Translate(Vector3.forward*Time.deltaTime*speed*verticalinput);
      transform.Rotate(Vector3.up*Time.deltaTime*turnspeed*horizontalinput);
      //transform.Translate(Vector3.right*Time.deltaTime*turnspeed*horizontalinput);
      if (players.transform.position.y<1)
      {
          Debug.Log("player want to destroyed");
      }
    }
    public void OnCollisionEnter(Collision col){
     if (col.gameObject.tag=="enemytag")
     {
         Debug.Log("Collided with enemyvehical");
         var save=players;
         Destroy(save);
         Time.timeScale=0;
     }  
    }
}
