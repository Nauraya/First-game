using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public GameObject Life1;
    public GameObject Life2;
    public GameObject Life3;
    public GameObject GameoverUI;
    public int health;
    public Hero hero;

    void Start()
    {
        
        Life1.gameObject.SetActive(true);
        Life2.gameObject.SetActive(true);
        Life3.gameObject.SetActive(true);
        GameoverUI.gameObject.SetActive(false);
        
    }

    void Update()
    {
        if(hero.health == 3)
        {
            Life1.gameObject.SetActive(true);
            Life2.gameObject.SetActive(true);
            Life3.gameObject.SetActive(true);
            GameoverUI.gameObject.SetActive(false);
        }
        if(hero.health == 2)
        {
            Life1.gameObject.SetActive(false);
            Life2.gameObject.SetActive(true);
            Life3.gameObject.SetActive(true);
            GameoverUI.gameObject.SetActive(false);
        }
        if(hero.health == 1)
        {
            Life1.gameObject.SetActive(false);
            Life2.gameObject.SetActive(false);
            Life3.gameObject.SetActive(true);
            GameoverUI.gameObject.SetActive(false);
        }
        if(hero.health == 0)
        {
            Life1.gameObject.SetActive(false);
            Life2.gameObject.SetActive(false);
            Life3.gameObject.SetActive(false);
            GameoverUI.gameObject.SetActive(true);
        }


    }
}
