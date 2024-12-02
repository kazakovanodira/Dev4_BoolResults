using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Dev_Part3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        double numHoursWorked = 45;
        double myPayRate = 5;
        double basePay;
        double weeklyPay;
        string report = "Payroll Without Overtime";

        
        if (numHoursWorked > 40) 
        {
            numHoursWorked = (numHoursWorked - 40) * 1.5 + 40;
            report = "Payroll with Overtime";
        }
        
        basePay = numHoursWorked * myPayRate;
        weeklyPay = 0.75 * basePay;

        Debug.Log("<color=red><size=20>" + report + "</size></color>\n" + 
        "The weapons salesperson's weekly pay = " + weeklyPay + " Kruks\n");

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
