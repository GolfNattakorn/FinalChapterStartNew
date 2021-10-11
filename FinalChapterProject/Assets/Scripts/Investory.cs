using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    //Trade
    public Image tradeImage;
    public Sprite[] tradeImageSprite;
    public int tradePrice;
    public int ticketAmount;

    //CheckTrade
    public GameObject[] checkTrade;

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

    //////////////////////////////Trade
    public void RandomTradeOne()
    {
        int random = Random.Range(0, 5);
        switch (random)
        {
            case 0:
                tradeImage.sprite = tradeImageSprite[0];
                tradePrice = 105;
                break;
            case 1:
                tradeImage.sprite = tradeImageSprite[1];
                tradePrice = 139;
                break;
            case 2:
                tradeImage.sprite = tradeImageSprite[2];
                tradePrice = 182;
                break;
            case 3:
                tradeImage.sprite = tradeImageSprite[3];
                tradePrice = 201;
                break;
            case 4:
                tradeImage.sprite = tradeImageSprite[4];
                tradePrice = 372;
                break;
        }
    }

    public void RandomTradeTwo()
    {
        int random = Random.Range(5, 10);
        switch (random)
        {
            case 5:
                tradeImage.sprite = tradeImageSprite[5];
                tradePrice = 511;
                break;
            case 6:
                tradeImage.sprite = tradeImageSprite[6];
                tradePrice = 478;
                break;
            case 7:
                tradeImage.sprite = tradeImageSprite[7];
                tradePrice = 28;
                break;
            case 8:
                tradeImage.sprite = tradeImageSprite[8];
                tradePrice = 849;
                break;
            case 9:
                tradeImage.sprite = tradeImageSprite[9];
                tradePrice = 53;
                break;
        }
    }

    public void TicketRefund()
    {
        status.money += tradePrice * ticketAmount;
        ticketAmount = 0;
    }

    public void BuyTicket()
    {
        if(status.money >= tradePrice && status.energy != 0)
        {
            ticketAmount += 1;
            status.money -= tradePrice;
            status.ticketAmountText.text = "X " + ticketAmount;

            status.OneAction(); ///Use Energy
        }
        else
        {
            checkTrade[0].SetActive(true);
            StartCoroutine(CheckBuy());
        }
    }

    public void SellTicket()
    {
        if (ticketAmount > 0 && status.energy != 0)
        {
            ticketAmount -= 1;
            status.money += tradePrice;
            status.ticketAmountText.text = "X " + ticketAmount;

            status.OneAction(); ///Use Energy
        }
        else
        {
            checkTrade[1].SetActive(true);
            StartCoroutine(CheckSell());
        }
    }

    IEnumerator CheckBuy()
    {
        yield return new WaitForSeconds(1.0f);
        checkTrade[0].SetActive(false);
        
        
    }

    IEnumerator CheckSell()
    {
        yield return new WaitForSeconds(1.0f);
        checkTrade[1].SetActive(false);
    }
}
