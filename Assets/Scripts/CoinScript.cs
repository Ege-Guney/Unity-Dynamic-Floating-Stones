using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{

    public GameObject winText;
    private void OnTriggerEnter(Collider other) {
        if(other.GetComponent<Collider>().tag == "Player"){
            StartCoroutine(WinCoroutine());
            
            
        } 
    }

    


    IEnumerator WinCoroutine()
    {
        
        Debug.Log("YOU WON!!!");
        winText.transform.position += new Vector3(0f,150.0f,0f);
        this.transform.position += new Vector3(0f, -150.0f, 0f);
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSecondsRealtime(5);

        UnityEditor.EditorApplication.isPlaying = false;
        
    }
    // Start is called before the first frame update
    void Start()
    {   
        winText.transform.position += new Vector3(0f,-150.0f,0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
