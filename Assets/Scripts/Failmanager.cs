using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Failmanager : MonoBehaviour
{

    public AudioSource sound;

    Text text;
    [SerializeField] Text text2;

    GameObject gamemanager;

    // Start is called before the first frame update
    void Awake()
    {
        gamemanager = GameObject.Find("Gamemanager");
        text = gamemanager.GetComponent<Input_manager>().text;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        }
    }

    public void Failed(int a)
    {
        text.text = a.ToString();
        text2.enabled = true;

        sound.enabled = false;
        sound.enabled = true;

        gamemanager.GetComponent<Counter>().enabled = false;
        gamemanager.GetComponent<Input_manager>().enabled = false;
    }
}
