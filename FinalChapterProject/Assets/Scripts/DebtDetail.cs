using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DebtDetail : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject debtInstruments;

    ///Message
    public GameObject[] messageDept;
    public GameObject[] noneMessageDept;

    ///Result
    public Text governmentResultText;
    public Text privateResultText;

    // Start is called before the first frame update
    void Start()
    {
        debtInstruments.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  

    public void OnPointerEnter(PointerEventData eventData)
    {
        debtInstruments.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        debtInstruments.SetActive(false);
    }


}
