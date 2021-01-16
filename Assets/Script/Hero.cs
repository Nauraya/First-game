using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hero : MonoBehaviour
{
    private Vector2 targetPos= new Vector2(-2,0);
    public float Yincrement;
    public bool Gameover = false;

    public float speed;
    public float maxHeight;
    public float minHeight;

    public int health = 3;

    void Start()
    {

    }
    void Update()
    {
        if(Gameover==false)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

            if(Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
            {
                targetPos = new Vector2(-2f, transform.position.y + Yincrement);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
            {
                targetPos = new Vector2(-2f, transform.position.y - Yincrement);
            }
        }

        if(health <= 0)
        {
            Gameover = true;
        }
        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }   


}
