using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectControl : MonoBehaviour
{
    public static int scoreCount;//score
    public Text scoreCountTXT;//Text UI

    //public GameObject scoreCountDisplay;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreCountTXT.text = "" + scoreCount;//display the Score Count

        //scoreCountDisplay.GetComponent<Text>().text = "" + scoreCount;
    }
}
