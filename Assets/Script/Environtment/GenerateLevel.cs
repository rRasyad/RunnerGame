using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int zPos = 54;//location add number
    public static bool creatingSection = true;//this value will change in GameManager.cs to start the loop
    public int secNum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    //make a delay for spawner
    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 3); // random section in this case we have 3 section
        Instantiate(section[secNum], new Vector3(0,0,zPos), Quaternion.identity); //crate the GameObject
        zPos += 54;
        yield return new WaitForSeconds(10);//delay
        creatingSection = false;
    }
}
