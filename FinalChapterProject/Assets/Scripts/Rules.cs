using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rules : MonoBehaviour
{
    public GameObject panelRegister;
    public GameObject panelMap;
    public GameObject[] rulePanel;
    public GameObject[] pointOut;
    public GameObject pButton;
    public GameObject nButton;
    public GameObject sButton;
    


    private int rule;
    // Start is called before the first frame update
    void Start()
    {
        rule = 1;

        //panelRegister.SetActive(true);
        //panelMap.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ChangeRulePanel();
    }

    private void ChangeRulePanel()
    {
        switch (rule)
        {
            case 1:
                rulePanel[0].SetActive(true);
                rulePanel[1].SetActive(false);
                rulePanel[2].SetActive(false);

                pointOut[0].SetActive(true);
                pointOut[1].SetActive(false);
                pointOut[2].SetActive(false);

                pButton.SetActive(false);
                nButton.SetActive(true);
                sButton.SetActive(false);
                break;
            case 2:
                rulePanel[0].SetActive(false);
                rulePanel[1].SetActive(true);
                rulePanel[2].SetActive(false);

                pointOut[0].SetActive(false);
                pointOut[1].SetActive(true);
                pointOut[2].SetActive(false);

                pButton.SetActive(true);
                nButton.SetActive(true);
                sButton.SetActive(false);
                break;
            case 3:
                rulePanel[0].SetActive(false);
                rulePanel[1].SetActive(false);
                rulePanel[2].SetActive(true);

                pointOut[0].SetActive(false);
                pointOut[1].SetActive(false);
                pointOut[2].SetActive(true);

                pButton.SetActive(true);
                nButton.SetActive(false);
                sButton.SetActive(true);
                break;
        }
    }

    public void PreviousRule()
    {
        rule--;
    }

    public void NextRule()
    {
        rule++;
    }

    public void ToMap()
    {
        panelRegister.SetActive(false);
        panelMap.SetActive(true);
    }
}
