using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{

    public GameObject Black;
    public GameObject Au1dioSource;
    public Timer timer;
    public int K;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        K = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Time.timeScale = 1;
            Black.SetActive(false);
            Au1dioSource.SetActive(true) ;
            K += 1;
            timer.timerStart();
        }
        if (K == 1)
        {
            Au1dioSource.GetComponent<AudioSource>().Play();
            
        }

    }
}
