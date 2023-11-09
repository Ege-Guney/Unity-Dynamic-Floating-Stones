using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject target;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if(other.GetComponent<Collider>().tag != "Player" && other.GetComponent<Collider>().tag != "gun"){
            Destroy(gameObject);
            if(other.GetComponent<Collider>().tag == "target"){
               Destroy(target);
               Destroy(text); 
            }
        }

        
       
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y >= 250 || transform.position.y <= -250){
            Destroy(gameObject);
        }
        
    }
}
