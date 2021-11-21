using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    private float leftBound = -8.264982f;
    private float rightBound = 8.264982f;
    public GameObject go;

    public Vector3 ReadInput(){
        float x = 0;
        if((Input.GetButton("Left")) && (go.transform.position.x > leftBound)){
            x = -0.1f;
        } else if ((Input.GetButton("Right")) && (go.transform.position.x < rightBound)){
            x = 0.1f;
        }
        else{
            x = 0;
        }
        
        if(x != 0){
            Vector3 direction = new Vector3(x, 0, 0);
            return direction;
        }
        return Vector3.zero;
    }
}
