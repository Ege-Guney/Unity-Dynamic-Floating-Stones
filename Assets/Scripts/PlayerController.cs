using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController ch;
    public Transform playerCamera = null;
    public Transform proj = null;
    
    
    [SerializeField][Range(0.0f, 0.5f)] float mouseSmoothTime = 0.03f;
    public float gravity = -13.0f;
    float cameraPitch = 0.0f;
    float velocityY = 0.0f;
    public float speed = 50.0f;
    public float jumpSpeed = 6.0f;
    private float playerYnow;
    

    private Vector3 move = Vector3.zero;

    Vector2 currentMouseDelta = Vector2.zero;
    Vector2 currentMouseDeltaVelocity = Vector2.zero;


    // Start is called before the first frame update
    void Start()
    {
        ch = GetComponent<CharacterController>();
 
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        playerYnow = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        //camera
        Vector2 targetMouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        currentMouseDelta = Vector2.SmoothDamp(currentMouseDelta, targetMouseDelta, ref currentMouseDeltaVelocity, mouseSmoothTime);
        cameraPitch -= currentMouseDelta.y * 3.5f;
        cameraPitch = Mathf.Clamp(cameraPitch, -90.0f, 90.0f);

        playerCamera.localEulerAngles = Vector3.right * cameraPitch;
        transform.Rotate(Vector3.up * currentMouseDelta.x* 3.5f) ;
        playerCamera.Rotate(Vector3.up * currentMouseDelta.x * 3.5f);
        
        

        if (ch.isGrounded){

            move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            move = transform.TransformDirection(move);
            move *= speed;
           
            if (Input.GetButton("Jump") && transform.position.y <= playerYnow + 15.0f && transform.position.y >= playerYnow - 15.0f)
                move.y = jumpSpeed;

        }

        move.y += gravity * Time.deltaTime;
        ch.Move(move * Time.deltaTime);
}
}
