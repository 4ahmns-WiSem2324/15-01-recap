using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{

    Input_manager input_manager_script;

    [SerializeField] float time_till_next;
    public float calculate_time;
    float take_time = 20;

    // Start is called before the first frame update
    void Awake()
    {
        input_manager_script = gameObject.GetComponent<Input_manager>();
        time_till_next = 20;
    }


    public void reset()
    {
        if (calculate_time >= 3)
        {
            take_time = calculate_time -= 1;
        }
        else
        {
            take_time = 2;
        }

    }
    // Update is called once per frame
    void Update()
    {
        if (time_till_next >= 0)
        {
            time_till_next = (take_time -= Time.deltaTime)/10;                      
        }
        if (time_till_next <= 0)
        {
            gameObject.GetComponent<Input_manager>().Fail();
        }
    }
}
