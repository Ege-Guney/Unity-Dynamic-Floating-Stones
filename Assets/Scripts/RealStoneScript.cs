using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealStoneScript : MonoBehaviour
{
    public GameObject diss;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(diss.gameObject == null){
            Destroy(gameObject);
        }
    }
}
