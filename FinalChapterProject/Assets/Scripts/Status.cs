using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Status : MonoBehaviour
{
    public Registration registration;
    public Bank bank;
    public Move move;
   
    public Text textYourname;
    public Image statusImage;
    public Image playerImage;

    //status
    public int money;
    public int happy;
    public int health;
    public int knowledge;
    public int energy;

    public Text moneyText;

    //Scrollbar
    public Scrollbar happyScrollbar;
    public Scrollbar healthScrollbar;
    public Scrollbar knowledgeScrollbar;
    public Scrollbar energyScrollbar;
    public Text happyPointText;
    public Text healthPointText;
    public Text knowledgePointText;
    public Text energyPointText;

    //GamePlay
    public Text roundGameText;
    public Text timeText;

    public GameObject player;
    public GameObject[] allMapPanel;

    public int roundgame;
    private float time;
    private int timer;

    //FadeRound
    public GameObject fadePanel;
    public Image fadeImage;
    public Text fadeRoundText;

    //GameOver
    public GameObject gameOverPanel;



    // Start is called before the first frame update
    void Start()
    {
        NameStatus();
        
        PlayerImage();
    }

    // Update is called once per frame
    void Update()
    {

        StatusLimit();
        StatusScrollbar();
        
        RoundOfGame();
        UpdateMoney();
    }

    private void NameStatus()
    {
        if (registration.yourname == registration.yourName.text)
        {
            textYourname.text = registration.yourname;
            Debug.Log("NameCorrect");
        }
    }

    
    private void PlayerImage()
    {
        switch (registration.yourimage)
        {
            case 0:
                playerImage.sprite = registration.yourImages[0];
                statusImage.sprite = registration.yourImages[0];
                break;
            case 1:
                playerImage.sprite = registration.yourImages[1];
                statusImage.sprite = registration.yourImages[1];
                break;
            case 2:
                playerImage.sprite = registration.yourImages[2];
                statusImage.sprite = registration.yourImages[2];
                break;
            case 3:
                playerImage.sprite = registration.yourImages[3];
                statusImage.sprite = registration.yourImages[3];
                break;
            case 4:
                playerImage.sprite = registration.yourImages[4];
                statusImage.sprite = registration.yourImages[4];
                break;
            case 5:
                playerImage.sprite = registration.yourImages[5];
                statusImage.sprite = registration.yourImages[5];
                break;
            case 6:
                playerImage.sprite = registration.yourImages[6];
                statusImage.sprite = registration.yourImages[6];
                break;
            case 7:
                playerImage.sprite = registration.yourImages[7];
                statusImage.sprite = registration.yourImages[7];
                break;
        }
    }

    private void StatusLimit()
    {
        if(happy > 100)
        {
            happy = 100;
        }
        if(health > 100)
        {
            health = 100;
        }
        if(knowledge > 50)
        {
            knowledge = 50;
        }
        if(energy > 100)
        {
            energy = 100;
        }
    }

    

    private void CheckHappy()
    {
        if (happy <= 0)
        {
            happy = 0;
            health -= 10;
        }
    }

    private void UpdateMoney()
    {
        moneyText.text = money + " B( " + bank.bankdeposit + " B) ";
    }

    private void StatusScrollbar()
    {
        happyPointText.text = happy + "/100";
        healthPointText.text = health + "/100";
        knowledgePointText.text = knowledge + "/50";
        energyPointText.text = energy + "/100";

        happyScrollbar.size = (float)happy / 100;
        healthScrollbar.size = (float)health / 100;
        knowledgeScrollbar.size = (float)knowledge / 50;
        energyScrollbar.size = (float)energy / 100;

        happyScrollbar.value = 0;
        healthScrollbar.value = 0;
        knowledgeScrollbar.value = 0;
        energyScrollbar.value = 0;
    }

    public void OneAction()
    {
        if(energy != 0)
        {
            energy = energy - 10;
        }
    }

    private void RoundOfGame()
    {
        if (health <= 0)
        {
            gameOverPanel.SetActive(true);
        }
        else if (roundgame == 5)
        {
            TimeofGame();

            if (time == 0f || energy == 0)
            {
                ///On Result Playing Player

                bank.BankInterest();
            }
        }
        else if(roundgame >=1 && roundgame <= 4)
        {
            TimeofGame();

            if (time == 0f || energy == 0)
            {
                roundgame = roundgame + 1;
                fadePanel.SetActive(true);
                fadeRoundText.text = "รอบที่ " + roundgame;
                FadeIn();

                Debug.Log("Round " + roundgame);

                time = 60f;
                energy = 100;

                
                CheckHappy();
                bank.BankInterest();

                player.transform.position =  move.waypoins[0].transform.position;

                for (int i = 0; i < allMapPanel.Length; i++) //Open StartPointPanel When Start Next Round 
                {
                    if(i == 0)
                    {
                        allMapPanel[0].SetActive(true);
                    }
                    else
                    {
                        allMapPanel[i].SetActive(false);
                    }
                }
            }
        }
        else
        {
            roundgame = roundgame + 1;
            fadePanel.SetActive(true);
            fadeRoundText.text = "รอบที่ " + roundgame;
            FadeIn();

            Debug.Log("Round " + roundgame);
            time = 60f;
            energy = 100;

           
        }
        roundGameText.text = roundgame + "/5";
        

    }

    private void TimeofGame()
    {
        if(time >= 1)
        {
            time = time - 1*Time.deltaTime;
            timer = System.Convert.ToInt32(time);
            
            
            
        }
        else
        {
            time = 0f;
            timer = System.Convert.ToInt32(time);
            
            
        }
        timeText.text = timer.ToString();
    }

    private void FadeIn()
    {
        
        fadeImage.CrossFadeAlpha(1, 1.0f, false);
        //StartCoroutine(CloseFadePanel());
        StartCoroutine(FadeOut());

    }

    IEnumerator FadeOut()
    {
        yield return new WaitForSeconds(1.0f);
        fadeImage.CrossFadeAlpha(0, 1.0f, false);
        yield return new WaitForSeconds(1.0f);
        fadePanel.SetActive(false);
    }
}
