using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dev_Part1 : MonoBehaviour
{
    public double quantity = 10;
    public double price = 10;
    string result = "Your total purchase was 200 Kruks or more. You reived 10% discount.\n";
    string withDiscount = "With discount: ";
    double totalPurchase;
    double finalCost;

    // Start is called before the first frame update
    void Start()
    {
        totalPurchase = quantity * price;
        if (totalPurchase < 200) 
        {
            result = "Your total purchase was NOT 200 Kruks or more. You didn't qualify for a discount.\n";
            withDiscount = "";
            finalCost = 1.05 * totalPurchase;
        }
        else 
        {
            double discount = 0.9 * totalPurchase;
            finalCost = 1.05 * discount;
            withDiscount = withDiscount + discount.ToString() + " Kruk\n";
        }
        
        Debug.Log("<color=red><size=20>Bill</size></color>\n" + result + 
        "Your total purchase = " + totalPurchase + " Kruks\n" + withDiscount + 
        "The tax = 5%\n" +  "The quantity you purchased = " + quantity + "\n" + 
        "Your bill = " + finalCost + " Kruks");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
