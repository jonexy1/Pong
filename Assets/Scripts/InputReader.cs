using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    public Vector3 ReadInput(){
        float x = 0;
        if(Input.GetButton("Left")){
            x = -0.1f;
        } else if (Input.GetButton("Right")){
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
