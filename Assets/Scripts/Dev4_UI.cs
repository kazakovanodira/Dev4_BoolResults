using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class Dev4_UI : MonoBehaviour
{
    public TextMeshProUGUI myOutputFieldText1;
    public TextMeshProUGUI myOutputFieldText2;
    public TextMeshProUGUI myOutputFieldText3;
    public TextMeshProUGUI myOutputFieldText4;
    public TextMeshProUGUI myOutputFieldText5;

    public GameObject a;
    string astring;

    public GameObject b;
    string bstring;

    public GameObject c;
    string cstring;

    public GameObject d;
    string dstring;

    public GameObject e;
    string estring;

    public GameObject f;
    string fstring;

    public GameObject g;
    string gstring;

    public GameObject h;
    string hstring;

    public GameObject i;
    string istring;

    public GameObject j;
    string jstring;

    public GameObject tf1;
    string tfstring1;

    public GameObject tf2;
    string tfstring2;

    public GameObject tf3;
    string tfstring3;

    public GameObject tf4;
    string tfstring4;

    public GameObject tf5;
    string tfstring5;

    string output1 = "Wrong";
    string output2 = "Wrong";
    string output3 = "Wrong";
    string output4 = "Wrong";
    string output5 = "Wrong";

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        astring = a.GetComponent<TMP_InputField>().text;
        bstring = b.GetComponent<TMP_InputField>().text;
        cstring = c.GetComponent<TMP_InputField>().text; 
        dstring = d.GetComponent<TMP_InputField>().text;
        estring = e.GetComponent<TMP_InputField>().text;
        fstring = f.GetComponent<TMP_InputField>().text;
        gstring = g.GetComponent<TMP_InputField>().text;
        hstring = h.GetComponent<TMP_InputField>().text; 
        istring = i.GetComponent<TMP_InputField>().text;
        jstring = g.GetComponent<TMP_InputField>().text;
        tfstring1 = tf1.GetComponent<TMP_InputField>().text;
        tfstring2 = tf2.GetComponent<TMP_InputField>().text;
        tfstring3 = tf3.GetComponent<TMP_InputField>().text;
        tfstring4 = tf4.GetComponent<TMP_InputField>().text;
        tfstring5 = tf5.GetComponent<TMP_InputField>().text;


    }

    public void OnClick_one()
    {
        int aint = Int32.Parse(astring);
        int bint = Int32.Parse(bstring);
        bool result = (aint + bint > 10 && aint * bint < 50) || (aint / bint == 0 || aint % bint == 0);

        int cint = Int32.Parse(cstring);
        int dint = Int32.Parse(dstring);
        bool result2 = (cint + dint < 50 || cint * dint == 600) && (cint / dint < 1 || cint % dint != 0);

        int eint = Int32.Parse(estring);
        int fint = Int32.Parse(fstring);
        bool result3 = (eint - fint > 10 && eint * fint < 100) || (eint / fint < 5 && eint % fint != 0);

        int gint = Int32.Parse(gstring);
        int hint = Int32.Parse(hstring);
        bool result4 = (gint + hint == 30 || gint * hint > 200) && (gint / hint == 2 || gint % hint != 0);

        int iint = Int32.Parse(istring);
        int jint = Int32.Parse(jstring);
        bool result5 = (iint - jint > 10 && iint * jint < 800) || (iint / jint == 2 && iint % jint == 0);

        if (result.ToString().ToLower() == tfstring1.ToLower())
        {
            output1 = "Right";
        }
        myOutputFieldText1.text = output1.ToString();

        if (result2.ToString().ToLower() == tfstring2.ToLower())
        {
            output2 = "Right";
        }
        myOutputFieldText2.text = output2.ToString();

        if (result3.ToString().ToLower() == tfstring3.ToLower())
        {
            output3 = "Right";
        }
        myOutputFieldText3.text = output3.ToString();

        if (result4.ToString().ToLower() == tfstring4.ToLower())
        {
            output4 = "Right";
        }
        myOutputFieldText4.text = output4.ToString();

        if (result5.ToString().ToLower() == tfstring5.ToLower())
        {
            output5 = "Right";
        }
        myOutputFieldText5.text = output5.ToString();


       

        Debug.Log("Correct answers: " + result + "\n"
            + result2 + "\n"
            + result3 + "\n"
            + result4 + "\n"
            + result5);
    }

    
}
