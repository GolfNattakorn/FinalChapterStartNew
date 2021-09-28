using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Investory : MonoBehaviour
{
    [Header("Investory Panel")]
    public GameObject trainPanel, invesPanel;
   
    [Header("Inves Panel")]
    public GameObject bondPanel, tradePanel;

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
}
