using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBackOffScript : MonoBehaviour
{

    public GameObject invisWall;
    private bool checkWall = true;

    void OnTriggerEnter(Collider other) {
        if(other.GetComponent<Collider>().tag == "Player" && checkWall){
            Debug.Log("Working Trigger");
            invisWall.transform.position += new Vector3(0f,61f,0f);
            checkWall = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        checkWall = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
