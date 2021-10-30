using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Hospital : MonoBehaviour
{
    public Status status;
    public Registration registration;

    //Unwell
    public bool unwell;
    public int unWellTime;
    public int randomMax;

    //CheckHeal
    public GameObject[] blockHeal;
    public GameObject[] checkMoney;

    //Player Image
    public Sprite[] unwellPlayer;

    //Unwell Event
    public Transform unwellPanel;
    public CanvasGroup background;
    public GameObject bg;

    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NoExpensiveHeal()
    {
        if (unwell == true && status.money >= 100 && status.energy != 0)
        {
            status.health += 5;
            status.happy += 1;
            unwell = false;

            status.PlayerImage(); //change Image No Unwell
            status.OneAction(); //Use Energy
        }
        else if (unwell == false)
        {
            blockHeal[0].SetActive(true);
        }
        else
        {
            checkMoney[0].SetActive(true);
        }
    }

    public void ExpensiveHeal()
    {
        if (unwell == true && status.money >= 300 && status.energy != 0)
        {
            status.health += 20;
            status.happy += 5;
            unwell = false;

            status.PlayerImage(); //change Image No Unwell
            status.OneAction(); //Use Energy
        }
        else if(unwell == false)
        {
            blockHeal[1].SetActive(true);
        }
        else
        {
            checkMoney[1].SetActive(true);
        }
    }

    public void RandomUnwell()
    {
        if(unWellTime == 0)
        {
            int random = Random.Range(1, randomMax);
            if(random == 1)
            {
                status.statusImage.sprite = unwellPlayer[registration.yourimage];
                status.playerImage.sprite = unwellPlayer[registration.yourimage];

                unwell = true;
                unWellTime = 1;

                status.eventCount += 1;

                background.alpha = 0;
                background.LeanAlpha(1, 0.5f);
                bg.SetActive(true);
                unwellPanel.localPosition = new Vector2(0, -Screen.height);
                unwellPanel.LeanMoveLocalY(0, 0.5f).setEaseOutExpo().delay = 0.1f;
            }
            else
            {
                randomMax -= 1;
            }
        }
    }

    public void CloseUnwellPanel()
    {
        //unwellPanel.SetActive(false);
        status.eventCount -= 1;

        background.LeanAlpha(0, 0.5f);
        StartCoroutine(WaitCloseBG());
        unwellPanel.LeanMoveLocalY(-Screen.height, 0.5f).setEaseInExpo();
    }

    IEnumerator WaitCloseBG()
    {
        yield return new WaitForSeconds(0.5f);
        bg.SetActive(false);
    }

    public void UnWell()
    {
        if(unwell == true)
        {

            status.health -= 20;
            status.happy -= 40;
        }
    }

    public void UnBlockHeal()
    {
        for(int i = 0; i < blockHeal.Length; i++)
        {
            blockHeal[i].SetActive(false);
            checkMoney[i].SetActive(false);
        }
    }
}
