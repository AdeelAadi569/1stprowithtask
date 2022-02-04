using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnvehical : MonoBehaviour
{
    public GameObject enemvehical,cam,seccam;
    //public Camera cam,seccam;
    public Transform[] pos;
    private bool cameera=true;
    //public KeyCode space;
    // Start is called before the first frame update
    void Start()
    {
      //  seccam.SetActive(false);
       // cam.enabled=true;
        //seccam.enabled=false;
         InvokeRepeating("SpawnEnemyVehicals",0f,5f);
    }

    // Update is called once per frame
    void Update()
    {
       //if ((Input.GetKeyDown(space)))
       //{
           //cam.enabled=!cam.enabled;
           //seccam.enabled=!seccam.enabled;
       //}
       if (Input.GetKeyDown("space") )
       {
           if (cameera==true)
           {
                Debug.Log(cameera);
                cameera=false;
                cam.SetActive(false);
                seccam.SetActive(true);
           }
            if(cameera==false)
           {
           
            Debug.Log(cameera);
           }
          
          
       }
     //  else
     //   if (Input.GetKeyDown("space") && cameera==false)
       //    {
         //      cameera=true;
           //    Debug.Log(cameera);
             //  cam.SetActive(true);
              // seccam.SetActive(false);
           //}    
    }
    public void SpawnEnemyVehicals(){
        int index=Random.Range(0,pos.Length);
        Instantiate(enemvehical,pos[index].position,Quaternion.identity);
    }
    
}
