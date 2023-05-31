using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerContoller : MonoBehaviour
{
    public float speed = 20.0f;
    public float turnSpeed=20.0f;
    public float horizontalInput;
    public float forwardInput;
    public Camera mainCamara;
    public Camera hoodCamara;
    public KeyCode switchKey;
    // Start is called before the first frame update

    public string InputID;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput= Input.GetAxis("Horizontal"+InputID);
        forwardInput= Input.GetAxis("Vertical"+ InputID);

        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput);
        //transform.Translate(Vector3.right*Time.deltaTime*turnSpeed*horizontalInput);
        transform.Rotate(Vector3.up, horizontalInput*turnSpeed*Time.deltaTime);

        if(Input.GetKeyDown(switchKey)){
            mainCamara.enabled= !mainCamara.enabled;
            hoodCamara.enabled= !hoodCamara.enabled;
        }
    }
}
