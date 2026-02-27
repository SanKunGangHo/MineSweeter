using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageSwap : MonoBehaviour
{
    public int a = 0;
    public GameObject[] images;
    public void Update()
    {
        images[0].SetActive(false);
        images[1].SetActive(false);
        images[2].SetActive(false);
        images[3].SetActive(false);
        images[4].SetActive(false);
        images[5].SetActive(false);
        images[6].SetActive(false);

        switch (a)
        {
            case 0:
                images[0].SetActive(true);
                break;
            case 1:
                images[1].SetActive(true);
                break;
            case 2:
                images[2].SetActive(true);
                break;
            case 3:
                images[3].SetActive(true);
                break;
            case 4:
                images[4].SetActive(true);
                break;
            case 5:
                images[5].SetActive(true);
                break;
            case 6:
                images[6].SetActive(true);
                break;
        }
        if(a < 0)
        {
            a = 0;
        }
        if (a > 6)
        {
            a = 6;
        }
    }
    public void nextClicked()
    {a++;
        images[0].SetActive(false);
        images[1].SetActive(false);
        images[2].SetActive(false);
        images[3].SetActive(false);
        images[4].SetActive(false);
        images[5].SetActive(false);
        images[6].SetActive(false);
        
    }
    public void prevClicked()
    {a--;
    }
}
