using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Vector3 sharkMovementInput;
    public Rigidbody sharkRB;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        sharkRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movementInput();
    }


    public void movementInput()
    {
        float movementX = 0;
        float movementZ = 1;

        if (Input.GetKeyDown(KeyCode.W))
        {
            movementZ = 1;
        } else if (Input.GetKeyDown(KeyCode.S))
        {
            movementZ = -1;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            movementX = -1;
        } else if (Input.GetKeyDown(KeyCode.D))
        {
            movementX = 1;
        }
        else
        {
            movementX = 0;
        }

        sharkMovementInput = new Vector3(movementX, 0, movementZ)*Time.deltaTime*speed;


        sharkRB.velocity = sharkMovementInput;
    }
}
