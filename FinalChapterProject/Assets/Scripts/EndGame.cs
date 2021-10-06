using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public Status status;
    public Registration registration;



    //Scrollbar
    public Scrollbar moneyScroll;
    public Scrollbar happyScroll;
    public Scrollbar healthScroll;
    public Scrollbar knowledgeScroll;

    public Text moneyScrollText;
    public Text happyScrollText;
    public Text healthScrollText;
    public Text knowledgeScrollText;

    //Summarize
    public Text moneySummarText;
    public int maxScrollMoney;
    public Text happySummarText;
    public int maxScrollHappy;
    public Text healthSummarText;
    public int maxScrollHealth;
    public Text knowledgeSummarText;
    //public int maxScrollKnowledge;

    public int allScore;
    public Image summarizeImage;
    public Sprite[] summarizeSprite;
    public Text summarizeText;
    public Text summarizeExplain;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CompareScroll();
    }

    private void CompareScroll()
    {
        moneyScrollText.text = status.money + " B";
        happyScrollText.text = status.happyPointText.text;
        healthScrollText.text = status.healthPointText.text;
        knowledgeScrollText.text = status.knowledgePointText.text;

        moneyScroll.size = status.moneyScrollbar.size;
        happyScroll.size = status.happyScrollbar.size;
        healthScroll.size = status.healthScrollbar.size;
        knowledgeScroll.size = status.knowledgeScrollbar.size;

        moneyScroll.value = 0;
        happyScroll.value = 0;
        healthScroll.value = 0;
        knowledgeScroll.value = 0;
    }

    public void MoneySummarize()
    {
        if(status.money >= maxScrollMoney * 71 / 100)
        {
            allScore += 2;
            moneySummarText.text = "���ҡ";
        }
        else if(status.money >= maxScrollMoney * 41 / 100)
        {
            allScore += 1;
            moneySummarText.text = "��";
        }
        else
        {
            allScore += 0;
            moneySummarText.text = "���";
        }
    }

    public void HappySummarize()
    {
        if (status.happy >= maxScrollHappy * 71 / 100)
        {
            allScore += 2;
            happySummarText.text = "���ҡ";
        }
        else if (status.money >= maxScrollHappy * 41 / 100)
        {
            allScore += 1;
            happySummarText.text = "��";
        }
        else
        {
            allScore += 0;
            happySummarText.text = "���";
        }
    }

    public void HealthSummarize()
    {
        if (status.health >= maxScrollHealth * 71 / 100)
        {
            allScore += 2;
            healthSummarText.text = "���ҡ";
        }
        else if (status.money >= maxScrollHealth * 41 / 100)
        {
            allScore += 1;
            healthSummarText.text = "��";
        }
        else
        {
            allScore += 0;
            healthSummarText.text = "���";
        }
    }

    public void KnowledgeSummarize()
    {
        if (status.knowledge == 50)
        {
            allScore += 2;
            knowledgeSummarText.text = "���ҡ";
        }
        else if (status.knowledge >= 30)
        {
            allScore += 1;
            knowledgeSummarText.text = "��";
        }
        else
        {
            allScore += 0;
            knowledgeSummarText.text = "���";
        }
    }

    public void AllScoreSummarize()
    {
        if(allScore >= 6)
        {
            summarizeText.text = "���ҡ";
            summarizeImage.sprite = summarizeSprite[0];
            summarizeExplain.text = "�س " + registration.yourName.text + " �س����Ե����ҡ"; /// you live very well

        }
        else if (allScore >= 3)
        {
            summarizeText.text = "��";
            summarizeImage.sprite = summarizeSprite[1];
            summarizeExplain.text = "�س " + registration.yourName.text + " �����Ҥس����Ե���"; /// You're living a very good life.
        }
        else
        {
            summarizeText.text = "���";
            summarizeImage.sprite = summarizeSprite[2];
            summarizeExplain.text = "�س " + registration.yourName.text + " �س����Ե��������¹�"; /// You're not living well.
        }
    }

}
