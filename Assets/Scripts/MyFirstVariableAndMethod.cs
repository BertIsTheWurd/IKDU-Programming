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
        Debug.Log("I am " + currentAge + " years old");
        Debug.Log("In one year I'll be " + oneYear(currentAge) + " years old");
        Debug.Log("In " + yearsOfSome + " years I'll be " + someYear(currentAge) + " years old");
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
