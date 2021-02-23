using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text_script : MonoBehaviour
{

    public Text startText;
    // Start is called before the first frame update
    void Start()
    {
        startText = GameObject.Find("StartText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("o"))
        {
            startText.text = "Find a Bench, Column, Parasol, Lamppost and a BIG Tree";
        }
    }
}
