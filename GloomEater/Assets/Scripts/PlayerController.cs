using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Vector3 sharkMovementInput;
    public Vector3 sharkMovementInputRaw;
    public Vector3 sharkRotationInputRaw;
    public Rigidbody sharkRB;
    public float speed;
    private float speedFactor = 10;
    private float rotationY = 0;
    private float rotationX = 0;
    private float movementZ = 0;

    // Start is called before the first frame update
    void Start()
    {
        sharkRB = GetComponent<Rigidbody>();
        sharkMovementInput = Vector3.zero;
        sharkMovementInputRaw = Vector3.zero;
        sharkRotationInputRaw = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        movementInput();
    }


    public void movementInput()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            movementZ = 1;
        } else if (Input.GetKey(KeyCode.DownArrow))
        {
            movementZ = -1;
        }
        else if(Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            movementZ = 0;
        }

        if (Input.GetKey(KeyCode.A))
        {
            rotationY -= 1;
        } else if (Input.GetKey(KeyCode.D))
        {
            rotationY += 1;
        }

        if (Input.GetKey(KeyCode.W))
        {
            rotationX -= 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rotationX += 1;
        }

        sharkMovementInputRaw = transform.forward*movementZ;
        sharkRotationInputRaw = new Vector3(rotationX,rotationY,0);
        transform.eulerAngles = sharkRotationInputRaw;
        sharkMovementInput = sharkMovementInputRaw * Time.deltaTime * speed * speedFactor;

        sharkRB.velocity = sharkMovementInput;

    }
}
