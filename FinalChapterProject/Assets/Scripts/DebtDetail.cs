using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DebtDetail : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject debtInstruments;

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
