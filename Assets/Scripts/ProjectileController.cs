using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{

    private bool lockwe = true;
    private bool created = false;

    public GameObject bullet;
    public GameObject gun;
    public Rigidbody bulletRb;
    public float bulletSpeed = 100.0f;

    Rigidbody bulletClone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other){
        
        if(other.GetComponent<Collider>().tag == "Lock"){
            lockwe = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(!lockwe){
            if(Input.GetMouseButton(0)){
                if(!created){
                    bulletClone = Instantiate(bulletRb, gun.transform.position, gun.transform.rotation);
                    //bulletClone.transform.position = gun.transform.position;
                    bulletClone.velocity = gun.transform.forward * bulletSpeed;
                    created = true;
                }
                
            }
            if(created){
                if(bulletClone == null){
                    created = false;
                }
            
            }
        }

        
    }
}
