using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cube_script : MonoBehaviour
{
    public GameObject bench;
    public GameObject column;
    public GameObject lp;
    public GameObject tree;
    public GameObject parasol;
    public GameObject[] objects;
    public Text startText;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
        bench = GameObject.Find("Bench");
        column = GameObject.Find("greek_column_2");
        lp = GameObject.Find("Lamppost (5)");
        tree = GameObject.Find("Tree Type6 03");
        parasol = GameObject.Find("Parasol");
        objects = new GameObject[5];
        objects[0] = bench;
        objects[1] = column;
        objects[2] = lp;
        objects[3] = tree;
        objects[4] = parasol;


        startText = GameObject.Find("StartText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        bool allInActive = true;

        for (int i = 0; i < objects.Length; i++)
        {
            if (objects[i].activeInHierarchy)
            {
                allInActive = false;
                break;
            }
        }

        if (allInActive)
        {
            gameObject.SetActive(false);
            startText.text = "You have now found all the objects, return to the church!!";
        }
    }
}
