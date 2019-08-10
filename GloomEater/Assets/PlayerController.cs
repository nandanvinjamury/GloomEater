using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Vector3 sharkMovementInput;
    public Vector3 sharkMovementInputRaw;
    public Rigidbody sharkRB;
    public float speed;
    private float speedFactor = 10;

    // Start is called before the first frame update
    void Start()
    {
        sharkRB = GetComponent<Rigidbody>();
        sharkMovementInput = Vector3.zero;
        sharkMovementInputRaw = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        movementInput();
    }


    public void movementInput()
    {
        float movementX = 0;

        float movementZ = sharkMovementInputRaw.z;

        if (Input.GetKeyDown(KeyCode.W))
        {
            movementZ = 1;
        } else if (Input.GetKey(KeyCode.S))
        {
            movementZ = -1;
        }

        if (Input.GetKey(KeyCode.A))
        {
            movementX = -1;
        } else if (Input.GetKey(KeyCode.D))
        {
            movementX = 1;
        }
        else
        {
            movementX = 0;
        }

        sharkMovementInputRaw = new Vector3(movementX, 0, movementZ);
        sharkMovementInput = sharkMovementInputRaw * Time.deltaTime * speed * speedFactor;

        sharkRB.velocity = sharkMovementInput;
    }
}
