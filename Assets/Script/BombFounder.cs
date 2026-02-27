
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BombFounder : MonoBehaviour
{
    public int mine;
    public int CanceledMine;
    public int k = 0;
    GameObject player;
    public GameObject Dig_button;
    public GameObject flag_button;
    public GameObject thisObject = null;
    public Image image;
    public Renderer yellow;

    public GameObject flag;

    public Element element;
    

    Vector3 tr;
    public void Start()
    {
        tr = this.gameObject.transform.localPosition;
        element = gameObject.GetComponent<Element>();
        flag_button = GameObject.FindGameObjectWithTag("Flag");
     }

    public void Update()
    {
        if (mine == 1)
        {
            element.SetActiveText(1);
        }
        else if(mine == 2)
        {
            element.SetActiveText(2);
        }
        else if (mine == 3)
        {
            element.SetActiveText(3);
        }
        else if (mine == 4)
        {
            element.SetActiveText(4);
        }
        else if (mine == 5)
        {
            element.SetActiveText(5);
        }
        else if (mine == 6)
        {
            element.SetActiveText(6);
        }
        else if (mine == 7)
        {
            element.SetActiveText(7);
        }
        else if (mine == 8)
        {
            element.SetActiveText(8);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Dig_button.SetActive(true);
            flag_button.SetActive(true);
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        Dig_button.SetActive(false);
        flag_button.SetActive(false);
    }

    public void buttonPushed()
    {
        k = 1;
    }

    public void FlagButtonClicked()
    {
        if(flag.activeSelf == true) { 
            flag.SetActive(false);
        }
        else if(flag.activeSelf == false && this.tag != "Mine")
        {
            flag.SetActive(true);
            this.tag = "misFlag";
        }
        else
        {
            flag.SetActive(true);
        }
    }

}
