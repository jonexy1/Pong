using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class PushBall : MonoBehaviour
{
    public Rigidbody2D rb;
    private float thrust = 100f;



    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.zero;
        rb.AddForce(new Vector2(0f, 1f) * thrust);
    }
}
