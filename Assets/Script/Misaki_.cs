using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misaki_ : MonoBehaviour
{
    public GameObject line1;
    public GameObject line2;
    public GameObject line3;
    public GameObject line4;
    public GameObject line5;
    public GameObject line6;
    public GameObject line7;
    public GameObject line8;
    public GameObject line9;
    public GameObject Misaki;
    public int A;

    public void Awake()
    {
        A = 0;

        Transform line1_2 = line1.transform.Find("2nd_1");
        Transform line1_3 = line1.transform.Find("3th");
        Transform line1_4 = line1.transform.Find("4th");
        Transform line1_5 = line1.transform.Find("5th");
        Transform line1_6 = line1.transform.Find("6th");
        Transform line1_7 = line1.transform.Find("7th_2");

        Transform line2_2 = line2.transform.Find("2nd_1");
        Transform line2_3 = line2.transform.Find("3th");
        Transform line2_4 = line2.transform.Find("4th");
        Transform line2_5 = line2.transform.Find("5th");
        Transform line2_6 = line2.transform.Find("6th");
        Transform line2_7 = line2.transform.Find("7th");

        Transform line3_1 = line3.transform.Find("1st_1");
        Transform line3_2 = line3.transform.Find("2nd_1");
        Transform line3_3 = line3.transform.Find("3th");
        Transform line3_4 = line3.transform.Find("4th_1");
        Transform line3_5 = line3.transform.Find("5th_1");
        Transform line3_6 = line3.transform.Find("6th_1");
        Transform line3_7 = line3.transform.Find("7th_1");
        Transform line3_8 = line3.transform.Find("8th_1");
        Transform line3_9 = line3.transform.Find("9th_1");

        Transform line4_1 = line4.transform.Find("1st");
        Transform line4_2 = line4.transform.Find("2nd");
        Transform line4_3 = line4.transform.Find("3th");
        Transform line4_4 = line4.transform.Find("4th");
        Transform line4_6 = line4.transform.Find("6th");
        Transform line4_7 = line4.transform.Find("7th");
        Transform line4_8 = line4.transform.Find("8th");
        Transform line4_9 = line4.transform.Find("9th");

        Transform line5_1 = line5.transform.Find("1st");
        Transform line5_2 = line5.transform.Find("2nd_1");
        Transform line5_6 = line5.transform.Find("6th_1");
        Transform line5_7 = line5.transform.Find("7th_1");
        //Misaki
        Transform line5_9 = line5.transform.Find("9th_1");

        Transform line6_1 = line6.transform.Find("1st");
        Transform line6_2 = line6.transform.Find("2nd_1");
        Transform line6_5 = line6.transform.Find("5th_1");
        Transform line6_6 = line6.transform.Find("6th");
        Transform line6_7 = line6.transform.Find("7th_1");
        Transform line6_8 = line6.transform.Find("8th");

        Transform line7_1 = line7.transform.Find("1st_1");
        Transform line7_2 = line7.transform.Find("2nd_2");
        Transform line7_3 = line7.transform.Find("3th_2");
        Transform line7_4 = line7.transform.Find("4th_2");
        Transform line7_5 = line7.transform.Find("5th_1");
        Transform line7_6 = line7.transform.Find("6th_1");
        Transform line7_7 = line7.transform.Find("7th_2");
        Transform line7_8 = line7.transform.Find("8th_1");
        Transform line7_9 = line7.transform.Find("9th_1");

        Transform line8_2 = line8.transform.Find("2nd_1");
        Transform line8_3 = line8.transform.Find("3th");
        Transform line8_4 = line8.transform.Find("4th");
        Transform line8_5 = line8.transform.Find("5th");
        Transform line8_6 = line8.transform.Find("6th_1");

        Transform line9_2 = line9.transform.Find("2nd_1");
        Transform line9_3 = line9.transform.Find("3th");
        Transform line9_4 = line9.transform.Find("4th");
        Transform line9_5 = line9.transform.Find("5th");
        Transform line9_6 = line9.transform.Find("6th_1");
    }
    // Update is called once per frame
    public void MisakiPushed()
    {
        if (A == 1)
        {
           
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision == Misaki.GetComponent<Collision>())
        {
            A = 1;
        }
    }
}
