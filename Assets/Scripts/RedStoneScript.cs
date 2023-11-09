using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedStoneScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.GetComponent<Collider>().tag == "Player"){
            Destroy(gameObject);
        } 
    }

    void Update() {
        
    }
}
