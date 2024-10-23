using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeeklySchedule : MonoBehaviour
{

    public int weekday = 0;
    public int weekday2 = 0;
    public string[] todo;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Today I have to:");
        weekday = Random.Range(0, 7);
        weekday2 = Random.Range(0, 7);
        DescribeDay(weekday);

        Debug.Log("And");

        switch (weekday2)
        {
            case 0:
                Debug.Log("Mow the lawn");
                break;
            case 1:
                Debug.Log("Do the dishes");
                break;
            case 2:
                Debug.Log("Eat food");
                break;
            case 3:
                Debug.Log("Sleep in");
                break;
            case 4:
                Debug.Log("Go home");
                break;
            case 5:
                Debug.Log("Write c#");
                break;
            case 6:
                Debug.Log("Hold meat with a towel");
                break;
        }
        
        }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DescribeDay(int weekday)
    {
        Debug.Log(todo[weekday]);
/*
        //This feels ineffecient somehow...
        if (weekday == 0)
        {
            Debug.Log("Get up early");
        }
        else if (weekday == 1)
        {
            Debug.Log("Stay late");
        }
        else if (weekday == 2)
        {
            Debug.Log("Buy groceries");
        }
        else if (weekday == 3)
        {
            Debug.Log("Waste time");
        }
        else if (weekday == 4)
        {
            Debug.Log("Pretend it's Saturday");
        }
        else if (weekday == 5)
        {
            Debug.Log("Enjoy Saturday");
        }
        else if (weekday == 6)
        {
            Debug.Log("Dread Monday");
        }
*/


    }
}
