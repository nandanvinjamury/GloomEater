using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomItemGen : MonoBehaviour
{

    int number;

    // Start is called before the first frame update
    void Start()
    {
        for(int i =0; i< number; i++)
        {
            Instantiate(gameObject, Random.insideUnitSphere * 5);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
