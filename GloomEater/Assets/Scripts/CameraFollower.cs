using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{

    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Sharky");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(0, 4, -10);
        transform.eulerAngles = player.transform.eulerAngles + new Vector3(20, 0, 0);
        transform.LookAt(player.transform, Vector3.up);
    }
}
