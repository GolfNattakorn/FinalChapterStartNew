using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Registration : MonoBehaviour
{
    //Registration
    public InputField yourName;
    public Text checkName;
    public Image yourImage;
    public Image leftYourImage;
    public Image rightYourImage;
    public Sprite[] yourImages;
    

    public string yourname;
    public int yourimage;

    //toRules
    public GameObject registartionPanel;
    public GameObject rulesPanel;

    
    // Start is called before the first frame update
    void Start()
    {
        yourname = "";
        yourimage = 0;
        checkName.text = "";
        
        registartionPanel.SetActive(true);
        rulesPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        CheckImage();
        
    }

    public void Next()
    {
        if(yourName.text != "")
        {
            checkName.text = "*Next";
            checkName.color = Color.green;
            yourname = yourName.text;
            Debug.Log("O");

            registartionPanel.SetActive(false);
            rulesPanel.SetActive(true);
        }
        else
        {
            checkName.text = "*Please enter your name";
            checkName.color = Color.red;
            yourname = "";
            Debug.Log("X");
        }
    }

    public void PreviousImage()
    {
        if(yourimage == 0)
        {
            yourimage = 7;
        }
        else
        {
            yourimage = yourimage - 1;
        }
    }

    public void NextImage()
    {
        if (yourimage == 7)
        {
            yourimage = 0;
        }
        else
        {
            yourimage = yourimage + 1;
        }
    }

    private void CheckImage()
    {
        switch (yourimage)
        {
            case 0:
                leftYourImage.sprite = yourImages[7];
                yourImage.sprite = yourImages[0];
                rightYourImage.sprite = yourImages[1];
                break;
            case 1:
                leftYourImage.sprite = yourImages[0];
                yourImage.sprite = yourImages[1];
                rightYourImage.sprite = yourImages[2];
                break;
            case 2:
                leftYourImage.sprite = yourImages[1];
                yourImage.sprite = yourImages[2];
                rightYourImage.sprite = yourImages[3];
                break;
            case 3:
                leftYourImage.sprite = yourImages[2];
                yourImage.sprite = yourImages[3];
                rightYourImage.sprite = yourImages[4];
                break;
            case 4:
                leftYourImage.sprite = yourImages[3];
                yourImage.sprite = yourImages[4];
                rightYourImage.sprite = yourImages[5];
                break;
            case 5:
                leftYourImage.sprite = yourImages[4];
                yourImage.sprite = yourImages[5];
                rightYourImage.sprite = yourImages[6];
                break;
            case 6:
                leftYourImage.sprite = yourImages[5];
                yourImage.sprite = yourImages[6];
                rightYourImage.sprite = yourImages[7];
                break;
            case 7:
                leftYourImage.sprite = yourImages[6];
                yourImage.sprite = yourImages[7];
                rightYourImage.sprite = yourImages[0];
                break;
        }

    }
    
}
