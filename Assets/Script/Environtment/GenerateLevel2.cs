using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel2 : MonoBehaviour
{
    public float maxTime = 10;
    private float timer = 0;
    public GameObject[] section;
    public int zPos = 54;//location add number
    public int zNegativePos = 0;//location add number
    public int secNum;

    void Start()
    {
        secNum = Random.Range(0, 3); // random section
        GameObject newSection = Instantiate(section[secNum],
            new Vector3(0, 0, zPos), Quaternion.identity);
    }

    void Update()
    {
        if (timer > maxTime)
        {
            secNum = Random.Range(0, 3); // random section
            GameObject newSection = Instantiate(section[secNum], 
                new Vector3(0, 0, zPos), Quaternion.identity);
            zPos += 54;
            zNegativePos += 54;
            Destroy(newSection, zNegativePos);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
    /*
    public float maxTime = 10;
    private float timer = 0;
    public GameObject pipe;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
    */
}
