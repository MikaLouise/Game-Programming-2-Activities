using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekDaysActivity : MonoBehaviour
{

    public TestEnum WeekDays;

    void Start()
    {

        switch (WeekDays)
        {
            case TestEnum.Monday: Debug.Log("Today is Monday"); break;
            case TestEnum.Tuesday: Debug.Log("Today is Tuesday"); break;
            case TestEnum.Wednesday: Debug.Log("Today is Wednesday"); break;
            case TestEnum.Thursday: Debug.Log("Today is Thursday"); break;
            case TestEnum.Friday: Debug.Log("Today is Friday"); break;
            case TestEnum.Saturday: Debug.Log("Today is Saturday"); break;
            case TestEnum.Sunday: Debug.Log("Today is Sunday"); break;
            default: Debug.Log("None of the Above"); break;
        }
    }
}



