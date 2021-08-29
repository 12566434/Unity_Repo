using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public int i;
    public Renderer rend;
    public int randint;
    // Start is called before the first frame update
    void Start()
    {
        i = 3;

        randint = Random.Range(200,251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);
        if (gameObject.CompareTag("Red") && (i == 100)) {
            gameObject.SetActive(false);
        }
        else if(gameObject.CompareTag("Blue") && (i == randint)) {
            rend.enabled = false;
        }
    }
}
