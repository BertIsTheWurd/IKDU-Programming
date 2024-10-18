using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstVariableAndMethod : MonoBehaviour
{

    public int currentAge;
    private int ageInOneYear;
    private int ageInSomeYear;

    public int yearsOfSome;


    // Start is called before the first frame update
    void Start()
    {
        Debug.LogFormat("I am {0} years old", currentAge);
        Debug.LogFormat("In one year I'll be {0} years old", oneYear(currentAge));
        Debug.LogFormat("In {0} years I'll be {1} years old", yearsOfSome, someYear(currentAge));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int oneYear(int age)
    {
        ageInOneYear = age + 1;
        return ageInOneYear;
    }

    public int someYear(int age)
    {
        ageInSomeYear = age + yearsOfSome;
        return ageInSomeYear;
    }
}
