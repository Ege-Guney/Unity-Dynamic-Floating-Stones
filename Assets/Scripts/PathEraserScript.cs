using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathEraserScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider other) {
        if(other.GetComponent<Collider>().tag == "Player"){
            Destroy(gameObject);
        } 
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
