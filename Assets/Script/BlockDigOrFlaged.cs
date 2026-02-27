using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDigOrFlaged : MonoBehaviour
{
    public GameObject player;
    public Vector3 Player;

    [Space(10f)]
    public GameObject GameOver, plane, win;
    public int K;
    private bool isMine;

    [Space(10f)]
    public GameObject Explosion;
    public Element element;
    public Renderer yellow;
    public BombFounder bomb;

    [Space(10f)]
    public GameObject[] mineChecker;
    public Vector3 tr;
    public Vector3 ariver;

    [Space(10f)]
    public AudioSource audioSource, audioSource2;
    public Touch touch;

    [Space(10f)]
    public int Mine1, Mine_Canceled, minea;

    [Space(10f)]
    public GameObject[] alreadyMine;
    public GameObject[] misflaged;

    [Space(10f)]
    public GameObject Gnomed;
    public bool main = false;
    public int win_num = 0;

    [Space(10f)]
    public Timer timer;

    public void Start()
    {
        win_num = Random.Range(0, 10);
        isMine = false;
        Player = this.gameObject.transform.localPosition;
        Debug.Log(win_num);
        touch = GameObject.Find("TouchManagementObject").GetComponent<Touch>();
    }


    public void DigOnClicked()
    {
        audioSource.Play();
        if (isMine)
        {
            Explosion.SetActive(true);
            Invoke("TimeStop", 1);
            audioSource2.Stop();
        }
        K = 1;
        alreadyMine = GameObject.FindGameObjectsWithTag("Mine");
    }


    public void TimeStop()
    {
        GameOver.SetActive(true);
        Time.timeScale = 0;
    }

    public void Update()
    {
        if (!isMine)
        {
            if (K == 1)
            {
                FindTarget(tr);
                yellow.material.color = new Color(44, 125, 0);
                K = 0;
                element.SetActiveText(Mine1);
                Mine1 = 0;
                if (Mine_Canceled == alreadyMine.Length && misflaged.Length == 0)
                {
                    win.SetActive(true);
                    timer.timerEnd();
                    touch.Au1dioSource.GetComponent<AudioSource>().Stop();
                }
            }
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Mine"))
        {
            isMine = true;
        }

        if (collision.gameObject.CompareTag("Blank"))
        {
            isMine= false;
        }
        element = collision.gameObject.GetComponent<Element>();
        bomb = collision.gameObject.GetComponent<BombFounder>();
        yellow = collision.gameObject.GetComponent<Renderer>();
        tr = collision.transform.position;
    }

    public void FindTarget(Vector3 center)
    {
        Collider[] hits = Physics.OverlapSphere(center, 20);

        for(int i = 0; i<hits.Length; i++)
        {
            if (hits[i].tag == "Mine")
            {
                Mine1++;
            }
        }
   
    }


    public void Pushed()
    {
        
        if(element.mine == true)
        {
            main = true;
            minecheckeded(main);
        }
        main = false;
        bomb.FlagButtonClicked();
    }

    public void minecheckeded(bool main)
    {
        if(main)
        {
            if (bomb.flag.activeSelf == false)
                Mine_Canceled++;
            else if(bomb.flag.activeSelf == true)
                Mine_Canceled--;
        }
    }
}
