using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Investory : MonoBehaviour
{
    [Header("Investory Panel")]
    public GameObject trainPanel, invesPanel;
   
    [Header("Inves Panel")]
    public GameObject bondPanel, tradePanel;

    public Status status;
    public Work work;

    //CheckBuy
    public GameObject[] blockBuy;
    public GameObject[] checkBuy;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //In the Investory Panel
    public void Train()
    {
        trainPanel.SetActive(true);
        invesPanel.SetActive(false);
    }
    public void Inves()
    {
        invesPanel.SetActive(true);
        trainPanel.SetActive(false);
    }

    //In the Inves Panel
    public void DebtInstruments()
    {
        bondPanel.SetActive(true);
        tradePanel.SetActive(false);
    }
    public void Trade()
    {
        tradePanel.SetActive(true);
        bondPanel.SetActive(false);
    }

    public void CourseOne()
    {
        if(status.money >= 500 && status.energy != 0)
        {
            status.money -= 500;
            status.knowledge += 30;

            status.OneAction(); /// Use Energy

            checkBuy[0].SetActive(true);
        }
        else
        {
            blockBuy[0].SetActive(true);
        }
    }

    public void CourseTwo()
    {
        if (status.money >= 750 && status.energy != 0)
        {
            status.money -= 750;
            status.knowledge += 20;

            status.OneAction(); /// Use Energy

            checkBuy[1].SetActive(true);
        }
        else
        {
            blockBuy[1].SetActive(true);
        }
    }

    public void UnBlockCourse()
    {
        for(int i = 0; i < blockBuy.Length; i++)
        {
            blockBuy[i].SetActive(false);
        }
    }

}
