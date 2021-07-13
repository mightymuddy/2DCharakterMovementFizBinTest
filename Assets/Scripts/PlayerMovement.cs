using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float movespeed = 1;
    public float jumpspeed = 1;


   
    private Rigidbody2D _ridgidbody;
    private float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        _ridgidbody = transform.GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");


        if (Input.GetKey(KeyCode.LeftShift))
            transform.position += new Vector3(movement, 0,0) * Time.deltaTime * movespeed;
        else
            transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * 2 * movespeed;
        if (Input.GetButtonDown("Jump"))
        {
            _ridgidbody.AddForce(new Vector2(0, jumpspeed), ForceMode2D.Impulse);
        }

    }



    Vector3 Movement()
    {
        Vector3 moveVector = Vector3.zero;

        moveVector += transform.right * Input.GetAxis("Horizontal");
        

        return moveVector;

    }
}
