using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTargetMover : MonoBehaviour
{
    // Start is called before the first frame update
    public float spinSpeed = 180.0f;
    public float motionMagnitude = 0.1f;

    public bool doSpin = true;
    public bool doMotion = false;

    // Update is called once per frame
    void Update(){
        if (doSpin){
            gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
        }
        //Rotate around the up axis of the gameObject
        

        //move up and down over time
        if (doMotion){
            gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
        }

    }
}
