using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Vector3 sharkMovementInput;
    public Rigidbody sharkRB;

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
        float movementX = Input.GetAxis("Horizontal");
        float movementZ = Input.GetAxis("Vertical");
        sharkMovementInput = new Vector3(movementX, 0, movementZ);


        sharkRB.velocity = sharkMovementInput;
    }
}
