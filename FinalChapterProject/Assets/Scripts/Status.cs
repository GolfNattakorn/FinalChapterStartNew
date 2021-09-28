using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Status : MonoBehaviour
{
    public Registration registration;
   
    public Text textYourname;
    public Image statusImage;
    public Image playerImage;

    //status
    public int money;
    public int happy;
    public int health;
    public int knowledge;
    public int energy;

    //Scrollbar
    public Scrollbar happyScrollbar;
    public Scrollbar healthScrollbar;
    public Scrollbar knowledgeScrollbar;
    public Scrollbar energyScrollbar;

    //GamePlay
    public Text roundGameText;
    public Text timeText;

    private int roundgame = 0;
    private float time;
    private int timer;


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
        TimeofGame();
        RoundOfGame();
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

    private void StatusScrollbar()
    {
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
        energy = energy - 10;
    }

    private void RoundOfGame()
    {
        if(roundgame == 5)
        {
            if (time == 0f || energy == 0)
            {
                roundgame = roundgame + 1;
                
                time = 60f;
                energy = 100;
            }
        }
        else if(roundgame >=1 && roundgame <= 4)
        {
            if (time == 0f || energy == 0)
            {
                roundgame = roundgame + 1;
                
                time = 60f;
                energy = 100;
            }
        }
        else
        {
            roundgame = roundgame + 1;
            time = 60f;
            energy = 100;
        }
        roundGameText.text = roundgame + "/5";
        //// Round 1 must be set at the startButton of Rules

    }

    private void TimeofGame()
    {
        if(time >= 1)
        {
            time = time - 1*Time.deltaTime;
            timer = System.Convert.ToInt32(time);
            
            Debug.Log(timer);
            
        }
        else
        {
            time = 0f;
            timer = System.Convert.ToInt32(time);
            
            Debug.Log(timer);
        }
        timeText.text = timer.ToString();
    }
}
