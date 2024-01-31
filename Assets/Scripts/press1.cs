using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class press1 : MonoBehaviour
{

    [SerializeField] Text text;

    [SerializeField] GameObject alles;

    float time;
    // Start is called before the first frame update
    void Awake()
    {
        alles.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        text.text = DateTime.Now.ToString();

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            alles.SetActive(true);
            text.enabled = false;
        }
    }
}
