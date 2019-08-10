using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GloomMeter : MonoBehaviour
{
    public Image gloomMeter;
    public bool hasStarted;

    // Start is called before the first frame update
    void Start()
    {
        gloomMeter.fillAmount = 0f;
        hasStarted = false;
        Invoke("Begin", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (gloomMeter.fillAmount < 1 && hasStarted) {
            gloomMeter.fillAmount += 0.05f*Time.deltaTime;
        }

        if(gloomMeter.fillAmount >= 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void Begin()
    {
        hasStarted = true;
    }

}
