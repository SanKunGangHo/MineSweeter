using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element : MonoBehaviour
{
    public bool mine;

    public int mine_1;

    public GameObject[] blankText;
    public GameObject mineImage;

    public BombFounder bomb;
    public GameObject BombImpact;
    public MineFinder Min;

    public int a;

    void Start()
    {
        mine = Random.value < 0.10;
        bomb = gameObject.GetComponent<BombFounder>();
        Min = GameObject.Find("Plane").GetComponent<MineFinder>();
    }

    public void SetActiveText(int a)
    {
        if (mine)
        {
            mineImage.SetActive(true);
        }
        else
        {
            blankText[a].SetActive(true);
        }
    }


    public void Update()
    {
        if (mine==true)
        {
            this.tag = "Mine";
        }
    }
}
