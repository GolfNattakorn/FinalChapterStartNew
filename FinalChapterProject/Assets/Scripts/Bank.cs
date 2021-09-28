using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bank : MonoBehaviour
{
    public Status status;

    public Text bankDepositText;
    public Text checkMoney;
    public InputField amountMoneyText;
    public int amountMoney;
    //public int moneyTest; //Ex Money in status

    public int bankdeposit;

    // Start is called before the first frame update
    void Start()
    {
        bankdeposit = 0;
        bankDepositText.text = bankdeposit + " B ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Deposit()
    {
        if(amountMoneyText.text != "")
        {
            amountMoney = System.Convert.ToInt32(amountMoneyText.text);
            if (amountMoney != 0)
            {
                if (amountMoney <= status.money)
                {
                    status.money = status.money - amountMoney;
                    bankdeposit = bankdeposit + amountMoney;
                    UpdateBankDepositText();
                    checkMoney.text = " Completed. ";
                    checkMoney.color = Color.green;
                    amountMoneyText.text = "";  

                    status.OneAction(); //Use Energy
                }
                else
                {
                    checkMoney.text = " you don't have enough money. ";
                    checkMoney.color = Color.red;
                }
            }
            else
            {
                checkMoney.text = " Please enter the correct deposit amount. ";
                checkMoney.color = Color.red;
            }
        }
        else
        {
            checkMoney.text = " Please enter deposit amount. ";
            checkMoney.color = Color.red;
        }
    }

    public void AllDeposit()
    {
        if(status.money != 0)
        {
            bankdeposit = bankdeposit + status.money;
            status.money = 0;
            UpdateBankDepositText();
            checkMoney.text = " Completed. ";
            checkMoney.color = Color.green;   

            status.OneAction(); //Use Energy
        }
        else
        {
            checkMoney.text = " you have no money. ";
            checkMoney.color = Color.red;
        }
    }

    public void WithDraw()
    {
        if (amountMoneyText.text != "")
        {
            amountMoney = System.Convert.ToInt32(amountMoneyText.text);
            if (amountMoney != 0)
            {
                if (amountMoney <= bankdeposit)
                {
                    status.money = status.money + amountMoney;
                    bankdeposit = bankdeposit - amountMoney;
                    UpdateBankDepositText();
                    checkMoney.text = " Completed. ";
                    checkMoney.color = Color.green;
                    amountMoneyText.text = "";

                    status.OneAction(); //Use Energy
                }
                else
                {
                    checkMoney.text = " You do not have enough deposit to withdraw this amount. ";
                    checkMoney.color = Color.red;
                }
            }
            else
            {
                checkMoney.text = " Please enter the correct withdrawal amount. ";
                checkMoney.color = Color.red;
            }
        }
        else
        {
            checkMoney.text = " Please enter withdrawal amount. ";
            checkMoney.color = Color.red;
        }
    }

    public void AllWithDraw()
    {
        if (bankdeposit != 0)
        {
            status.money = status.money + bankdeposit;
            bankdeposit = 0;
            UpdateBankDepositText();
            checkMoney.text = " Completed. ";
            checkMoney.color = Color.green;

            status.OneAction(); //Use Energy
        }
        else
        {
            checkMoney.text = " you have no deposit. ";
            checkMoney.color = Color.red;
        }
    }

    public void BankInterest()
    {
        bankdeposit += (bankdeposit * 1 ) / 100;
        UpdateBankDepositText();
    }

    private void UpdateBankDepositText()
    {
        bankDepositText.text = bankdeposit + " B ";
    }
}
