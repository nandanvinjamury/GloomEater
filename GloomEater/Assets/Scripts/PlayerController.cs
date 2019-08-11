using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    private Vector3 sharkMovementInput;
    private Vector3 sharkMovementInputRaw;
    private Vector3 sharkRotationInputRaw;
    private Rigidbody sharkRB;
    public float speed;
    private float speedFactor = 10;
    private float rotationY = 0;
    private float rotationX = 0;
    private float movementZ = 0;
    public Image gloomMeter;

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
            rotationY -= 3;
        } else if (Input.GetKey(KeyCode.D))
        {
            rotationY += 3;
        }

        if (Input.GetKey(KeyCode.S))
        {
            rotationX -= 3f;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            rotationX += 3f;
        }

        sharkMovementInputRaw = transform.forward*movementZ;
        sharkRotationInputRaw = new Vector3(rotationX,rotationY,0);
        transform.eulerAngles = sharkRotationInputRaw;
        sharkMovementInput = sharkMovementInputRaw * Time.deltaTime * speed * speedFactor;

        sharkRB.velocity = sharkMovementInput;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("collectible"))
        {
            Destroy(collision.gameObject);
            if (gloomMeter.fillAmount >= .2f)
                gloomMeter.fillAmount -= .2f;
            else
                gloomMeter.fillAmount = 0f;
        }
        if (collision.gameObject.tag.Equals("collectible2"))
        {
            Destroy(collision.gameObject);
            if (gloomMeter.fillAmount >= .1f)
                gloomMeter.fillAmount -= .1f;
            else
                gloomMeter.fillAmount = 0f;
        }
        if (collision.gameObject.tag.Equals("enemy"))
        {
            gloomMeter.fillAmount = 1f;
        }
    }
}
