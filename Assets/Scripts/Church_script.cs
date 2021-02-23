using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Church_script : MonoBehaviour
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

    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.tag == "Player")
        {
            startText.text = "Congratulations you won the game!!!"; ;
        }
    }
}

