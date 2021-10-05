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
    public DebtDetail debtDetail;

    //CheckBuyCouse
    public GameObject[] blockBuy;
    public GameObject[] checkBuy;

    //DeptDetail
    public bool governmentDept;
    public bool privateDept;
    public int governmentDeptResult;
    public int privateDeptResult;

    //CheckBuyDept
    public GameObject[] blockBuyDept;
    public GameObject[] checkBuyDept;


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

    //////////////////////////////DeptDetail
    
    public void BuyGoVernMentDeptDetail()
    {
        if(governmentDept == false && status.money >= 1000 && status.energy != 0)
        {
            status.money -= 1000;
            governmentDept = true;

            checkBuyDept[0].SetActive(true);
            debtDetail.messageDept[0].SetActive(true);
            debtDetail.noneMessageDept[0].SetActive(false);


            status.OneAction();   //Use Energy
        }
        else
        {
            blockBuyDept[0].SetActive(true);
        }
    }

    public void BuyPrivateDeptDetail()
    {
        if (privateDept == false && status.money >= 1000 && status.energy != 0)
        {
            status.money -= 1000;
            privateDept = true;

            checkBuyDept[1].SetActive(true);
            debtDetail.messageDept[1].SetActive(true);
            debtDetail.noneMessageDept[1].SetActive(false);

            status.OneAction();   //Use Energy
        }
        else
        {
            blockBuyDept[1].SetActive(true);
        }
    }

    public void UnBlockDeptDetail()
    {
        for (int i = 0; i < blockBuyDept.Length; i++)
        {
            blockBuyDept[i].SetActive(false);
        }
    }

    public void DeptDetailResultPerRound()
    {
        if(governmentDept == true)
        {
            status.money += governmentDeptResult;
            governmentDeptResult = (1000 * 4) / 100;
            debtDetail.governmentResultText.text = governmentDeptResult.ToString() + " B";
        }
        if (privateDept == true)
        {
            status.money += privateDeptResult;
            privateDeptResult = (1000 * 8) / 100;
            debtDetail.privateResultText.text = privateDeptResult.ToString() + " B";
        }
    }

    public void DeptDetailEndRound()
    {
        if (governmentDept == true)
        {
            status.money += 1000;
            governmentDept = false;
        }
        if (privateDept == true)
        {
            status.money += 1000;
            privateDept = false;
        }
    }

}
