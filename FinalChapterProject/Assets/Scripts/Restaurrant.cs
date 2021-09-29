using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restaurrant : MonoBehaviour
{
    public Status status;

    //BlockBuy
    public GameObject[] blockBuy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlainWater()
    {
        if(status.money >= 10 && status.energy !=0)
        {
            status.money -= 10;
            status.health += 1;

            status.OneAction(); //Use Energy
        }
        else
        {
            blockBuy[0].SetActive(true);
        }
       
    }

    public void SoftDrink()
    {
        if (status.money >= 20 && status.energy != 0)
        {
            status.money -= 20;
            status.health += 2;

            status.OneAction(); //Use Energy
        }
        else
        {
            blockBuy[1].SetActive(true);
        }

    }

    public void GrilledPork()
    {
        if (status.money >= 50 && status.energy != 0)
        {
            status.money -= 50;
            status.health += 5;

            status.OneAction(); //Use Energy
        }
        else
        {
            blockBuy[2].SetActive(true);
        }

    }

    public void Berger()
    {
        if (status.money >= 100 && status.energy != 0)
        {
            status.money -= 100;
            status.health += 10;
            status.happy += 5;

            status.OneAction(); //Use Energy
        }
        else
        {
            blockBuy[3].SetActive(true);
        }

    }

    public void Pizza()
    {
        if (status.money >= 200 && status.energy != 0)
        {
            status.money -= 200;
            status.health += 20;
            status.happy += 15;

            status.OneAction(); //Use Energy
        }
        else
        {
            blockBuy[4].SetActive(true);
        }

    }

    public void UnBlockBuy()
    {
        if(status.money >= 10)
        {
            blockBuy[0].SetActive(false);
            if(status.money >= 20)
            {
                blockBuy[1].SetActive(false);
                if(status.money >= 50)
                {
                    blockBuy[2].SetActive(false);
                    if (status.money >= 100)
                    {
                        blockBuy[3].SetActive(false);
                        if (status.money >= 200)
                        {
                            blockBuy[4].SetActive(false);
                        }
                    }
                }
            }
        }
        if (status.money < 200)
        {
            blockBuy[4].SetActive(true);
            if (status.money < 100)
            {
                blockBuy[3].SetActive(true);
                if (status.money < 50)
                {
                    blockBuy[2].SetActive(true);
                    if (status.money < 20)
                    {
                        blockBuy[1].SetActive(true);
                        if (status.money < 10)
                        {
                            blockBuy[0].SetActive(true);
                        }
                    }
                }
            }
        }

    }
}
