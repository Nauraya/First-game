using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public List<float> PosSpawnY;
    private float PosSpawnX;
    public GameObject ennemy;
    public float decreaseTime;
    private int random;
    private int cycle = 3;
    private float TimeLeft = 1f;
    
    void Start()
    {
        PosSpawnX = 3;
        random =  Random.Range(0, PosSpawnY.Count);
    }

    void Update()
    {
        if(TimeLeft <= 0)
        {
            for(int i = 1; i < cycle;)
            {
                Debug.Log("rand "+i);
                Instantiate(ennemy, new Vector3(PosSpawnX, PosSpawnY[random], 0),Quaternion.identity);
                random =  Random.Range(0, PosSpawnY.Count);
                i++;
                TimeLeft =Random.Range(0.8f, 2f);

            }
        }

        TimeLeft -= Time.deltaTime;
        
        
    }
}
