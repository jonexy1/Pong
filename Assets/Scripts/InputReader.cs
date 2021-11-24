using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    private float leftBound = -8.164982f;
    private float rightBound = 8.164982f;
    private float moveSpeed = 40.0f;
    public GameObject go;

    public float ReadInput(){
        float x = 0;
        if((Input.GetButton("Left")) && (go.transform.position.x > leftBound)){
            x = -moveSpeed;
        } else if ((Input.GetButton("Right")) && (go.transform.position.x < rightBound)){
            x = moveSpeed;
        }
        else{
            x = 0;
        }
        
        if(x != 0){
            return x;
        }
        return x;
    }
}
