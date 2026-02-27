using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public int a;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            a = 1;
        }
    }

    public void OnCollisionExit(Collision collision)
    {

            a = 0;
    }

    public void OnClicked1()
    {if (gameObject.tag != "wall")
        {
            if (a == 1)
            {
                Renderer red = gameObject.GetComponent<Renderer>();
                red.material.color = new Color(44, 125, 0);
            }
        }
    }
}
