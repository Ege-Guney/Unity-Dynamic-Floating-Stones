using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.GetComponent<Collider>().tag == "Player"){
            Debug.Log("GAME OVER");
            UnityEditor.EditorApplication.isPlaying = false;
            //Application.Quit();
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
