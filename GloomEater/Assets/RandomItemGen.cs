using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomItemGen : MonoBehaviour
{
    public GameObject[] enemyList;
    public GameObject[] collectibleList;
    private float randomNumberX;
    private float randomNumberY;
    private float randomNumberZ;
    private int relative;
    private int randomItem;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Generate", 3f, 3f);
    }

    public void Generate()
    {
        randomNumberX = Random.Range(5f, 10f);
        randomNumberY = Random.Range(5f, 10f);
        randomNumberZ = Random.Range(5f, 10f);
        relative = Random.Range(0, 8);
        randomItem = Random.Range(0, enemyList.Length);
        switch (relative)
        {
            case 0:
                Instantiate(enemyList[randomItem], transform.position + new Vector3(randomNumberX, randomNumberY, randomNumberZ), Quaternion.identity);
                break;
            case 1:
                Instantiate(enemyList[randomItem], transform.position + new Vector3(randomNumberX, randomNumberY, -randomNumberZ), Quaternion.identity);
                break;
            case 2:
                Instantiate(enemyList[randomItem], transform.position + new Vector3(randomNumberX, -randomNumberY, randomNumberZ), Quaternion.identity);
                break;
            case 3:
                Instantiate(enemyList[randomItem], transform.position + new Vector3(randomNumberX, -randomNumberY, -randomNumberZ), Quaternion.identity);
                break;
            case 4:
                Instantiate(enemyList[randomItem], transform.position + new Vector3(-randomNumberX, randomNumberY, randomNumberZ), Quaternion.identity);
                break;
            case 5:
                Instantiate(enemyList[randomItem], transform.position + new Vector3(-randomNumberX, randomNumberY, -randomNumberZ), Quaternion.identity);
                break;
            case 6:
                Instantiate(enemyList[randomItem], transform.position + new Vector3(-randomNumberX, -randomNumberY, randomNumberZ), Quaternion.identity);
                break;
            case 7:
                Instantiate(enemyList[randomItem], transform.position + new Vector3(-randomNumberX, -randomNumberY, -randomNumberZ), Quaternion.identity);
                break;
            default:
                break;

        }

        randomNumberX = Random.Range(5f, 10f);
        randomNumberY = Random.Range(5f, 10f);
        randomNumberZ = Random.Range(5f, 10f);
        relative = Random.Range(0, 8);
        randomItem = Random.Range(0, collectibleList.Length);
        switch (relative)
        {
            case 0:
                Instantiate(collectibleList[randomItem], transform.position + new Vector3(randomNumberX, randomNumberY, randomNumberZ), Quaternion.identity);
                break;
            case 1:
                Instantiate(collectibleList[randomItem], transform.position + new Vector3(randomNumberX, randomNumberY, -randomNumberZ), Quaternion.identity);
                break;
            case 2:
                Instantiate(collectibleList[randomItem], transform.position + new Vector3(randomNumberX, -randomNumberY, randomNumberZ), Quaternion.identity);
                break;
            case 3:
                Instantiate(collectibleList[randomItem], transform.position + new Vector3(randomNumberX, -randomNumberY, -randomNumberZ), Quaternion.identity);
                break;
            case 4:
                Instantiate(collectibleList[randomItem], transform.position + new Vector3(-randomNumberX, randomNumberY, randomNumberZ), Quaternion.identity);
                break;
            case 5:
                Instantiate(collectibleList[randomItem], transform.position + new Vector3(-randomNumberX, randomNumberY, -randomNumberZ), Quaternion.identity);
                break;
            case 6:
                Instantiate(collectibleList[randomItem], transform.position + new Vector3(-randomNumberX, -randomNumberY, randomNumberZ), Quaternion.identity);
                break;
            case 7:
                Instantiate(collectibleList[randomItem], transform.position + new Vector3(-randomNumberX, -randomNumberY, -randomNumberZ), Quaternion.identity);
                break;
            default:
                break;
        }

    }

}
