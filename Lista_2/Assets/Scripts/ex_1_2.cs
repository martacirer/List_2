using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_1_2 : MonoBehaviour
{
    
    public GameObject Appear;

    public int Counter = 1;
    private int WaveCounter = 1;

    //  sphere limits
    private float XRange = 10.5f;
    private float YRange = 5f;
  
    // random position
    private Vector3 RandomPos()
    {
        return new Vector3 (Random.Range(-XRange, XRange),Random.Range(-YRange, YRange), 0);
    }
    // enemy appear when the other disappear and add 1
    void Update()
    {   
        if(Counter == 0)
        {
            WaveCounter++;
            Counter = WaveCounter;

             for(int enemy = 0; enemy < WaveCounter; enemy++)
             {
                  Instantiate(Appear, RandomPos(), Appear.transform.rotation);
             }
        }

    }
}
