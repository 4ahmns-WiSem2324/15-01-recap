using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input_manager : MonoBehaviour
{

    public AudioSource sounds;

    Counter counter_script;

    int random_zahl;

    int richtig = -1;

    public Text text;
    // Start is called before the first frame update
    void Awake()
    {
        counter_script = gameObject.GetComponent<Counter>();
        zahlengenerator();
    }

    void zahlengenerator()
    {
        random_zahl = Random.Range(1, 7);
        text.text = random_zahl.ToString();
        richtig++;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (random_zahl == 1)
            {
                counter_script.reset();
                zahlengenerator();
                sounds.enabled = false;
                sounds.enabled = true;
            }
            else
            {
                Fail();
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (random_zahl == 2)
            {
                counter_script.reset();
                zahlengenerator();
                sounds.enabled = false;
                sounds.enabled = true;
            }
            else
            {
                Fail();
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (random_zahl == 3)
            {
                counter_script.reset();
                zahlengenerator();
                sounds.enabled = false;
                sounds.enabled = true;
            }
            else
            {
                Fail();
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            if (random_zahl == 4)
            {
                counter_script.reset();
                zahlengenerator();
                sounds.enabled = false;
                sounds.enabled = true;
            }
            else
            {
                Fail();
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            if (random_zahl == 5)
            {
                counter_script.reset();
                zahlengenerator();
                sounds.enabled = false;
                sounds.enabled = true;
            }
            else
            {
                Fail();
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            if (random_zahl == 6)
            {
                counter_script.reset();
                zahlengenerator();
                sounds.enabled = false;
                sounds.enabled = true;
            }
            else
            {
                Fail();
            }
        }

    }


    public void Fail()
    {
        GameObject.FindGameObjectWithTag("Failmanager").GetComponent<Failmanager>().Failed(richtig);

    }
}
