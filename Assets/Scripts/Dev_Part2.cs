using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dev_Part2 : MonoBehaviour
{
    double hrsWorked = 40;
    double numItems = 10;
    double itemCost = 100;
    double payRate = 5;
    double percentSales = 5;
    double weeklyPay = 0;
    string report = "Salesman's Pay with Bonus";

    // Start is called before the first frame update
    void Start()
    {
        double basePay = payRate * hrsWorked;
        double sales = numItems * itemCost;
        if (sales > 0.5 * basePay)
        {
            weeklyPay = basePay + sales * (percentSales/100) + basePay * 0.1;
        }
        else 
        {
            weeklyPay = basePay + sales * (percentSales/100+1);
            report = "Salesman's Pay withput Bonus because he didn't earn it :(";
        }

        Debug.Log("<color=red><size=20>" + report + "</size></color>\n" + 
        "The weapons salesperson's weekly pay = " + weeklyPay + " Kruks\n");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
