using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomItemGen : MonoBehaviour
{

    float randomNumber;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Generate", 3f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
