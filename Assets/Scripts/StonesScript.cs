using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StonesScript : MonoBehaviour
{

    public GameObject target;
    public GameObject realStone;
    public GameObject fakeStone;
    private bool check = true;
    //private bool check2 = true;

    public float startingOffsetZ = 7; //starting offset from start stone
    public float startingOffsetX = 12;
    private float currentZ;
    private float currentX;
    public int length = 220; //z limit for stepping stones
    public int width = 100; //x limit for stepping stones
    public int size = 10; //size of stepping st
    private int fakerandomizer = 0;

    //create a randomized path that goes forward by a small amount every time while loop goes.
    void CreatePath(){

        while(currentZ >= transform.position.z - length){
            fakerandomizer += 1;
            currentZ -= startingOffsetZ;
            float r;
            if(currentX >= transform.position.x + width){
                r = Random.Range(-17.0f, -12.0f); //randomize the x value diff
            }
            else if(currentX <= transform.position.x - width){
                r = Random.Range(12.0f, 17.0f); //randomize the x value diff
            }
            else{
                float k = Random.Range(0.0f, 1.0f);
                if(k < 0.5){
                     r = Random.Range(-17.0f, -12.0f); //randomize the x value diff
                }
                else{
                     r = Random.Range(12.0f, 17.0f); //randomize the x value diff
                }
               
            }
            
            currentX += r;

            Instantiate(realStone, new Vector3(currentX,this.transform.position.y,currentZ) ,Quaternion.identity);
            Instantiate(fakeStone, new Vector3(currentX - 2*r,this.transform.position.y,currentZ) ,Quaternion.identity);

            /*if(fakerandomizer % 2 == 0){
                float zd = Random.Range(0.0f, 1.0f);
                if(r < 0){
                    if(zd < 0.3){
                        Instantiate(fakeStone, new Vector3(currentX + 2.1f*r, this.transform.position.y,currentZ), Quaternion.identity);
                    }
                    else{
                        Instantiate(fakeStone, new Vector3(currentX + 1.9f*r, this.transform.position.y,currentZ), Quaternion.identity);
                        Instantiate(fakeStone, new Vector3(currentX - 2.3f*r, this.transform.position.y,currentZ), Quaternion.identity);
                    }
                    
                }
                else{
                    if(zd < 0.3){
                        Instantiate(fakeStone, new Vector3(currentX - 2.3f*r, this.transform.position.y,currentZ), Quaternion.identity);
                    }
                    else{
                        Instantiate(fakeStone, new Vector3(currentX + 2.3f*r, this.transform.position.y,currentZ), Quaternion.identity);
                        Instantiate(fakeStone, new Vector3(currentX - 2.1f*r, this.transform.position.y,currentZ), Quaternion.identity);
                    
                    }
                }
            
            }*/
            

        }


    }

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Renderer>().enabled = false;
        this.transform.position -= new Vector3(0f,100f,0f);
        check = true;
        //check2 = true;
        currentZ = this.transform.position.z;
        currentX = this.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(target == null && check){
            this.GetComponent<Renderer>().enabled = true;
            this.transform.position += new Vector3(0f,100f,0f);
            check = false;
            CreatePath();
        }   
    }
}
