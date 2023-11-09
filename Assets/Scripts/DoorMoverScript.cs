using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMoverScript : MonoBehaviour
{
    public GameObject door;
    public float doorMoveBy = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    void OnTriggerEnter(Collider other) {

        if (other.gameObject.tag == "Player" ) {
            Debug.Log("Hit");
            Debug.Log("pos:" + door.transform.position.y);
            door.transform.position += -door.transform.up * doorMoveBy;
            Debug.Log("pos:" + door.transform.position.y);
            Destroy(gameObject);

        }
    }
}
