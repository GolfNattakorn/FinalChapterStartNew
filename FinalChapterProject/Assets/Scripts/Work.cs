using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Work : MonoBehaviour
{
    public Status status;

    //Lock Work Panel
    public GameObject lockWorkTwo;
    public GameObject lockWorkThree;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WorkOne()
    {
        if(status.energy != 0)
        {
            status.money += 100;
            status.health -= 5;

            status.OneAction(); //Use Energey
        }
    }

    public void WorkTwo()
    {
        if (status.energy != 0)
        {
            status.money += 300;
            status.health -= 10;
            status.happy -= 5;

            status.OneAction(); //Use Energey
        }
    }

    public void WorkThree()
    {
        if (status.energy != 0)
        {
            status.money += 500;
            status.health -= 15;
            status.happy -= 7;

            status.OneAction(); //Use Energey
        }
    }

    public void UnLockWork()
    {
        if(status.knowledge >= 30)
        {
            lockWorkTwo.SetActive(false);
            if(status.knowledge >= 50)
            {
                lockWorkThree.SetActive(false);
            }
        }
    }

    
}
