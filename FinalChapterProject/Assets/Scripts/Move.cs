using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    public Transform[] waypoins;
 
    public GameObject homePanel, investoryPanel, workplacePanel, hospitalPanel,
        shopPanel, bankPanel, restaurrantPanel;

    [SerializeField]
    private float speed;

    private bool moveToHome, moveToInvestory, moveToWorkPlace, moveToHospital,
        moveToShop, moveToBank, moveToRestaurrant = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        MoveTo();
    }

    // Move
    private void MoveTo()
    {
        if (moveToHome == true)
        {

            transform.position = Vector2.MoveTowards(transform.position, waypoins[0].transform.position, speed * Time.deltaTime);
            if (transform.position == waypoins[0].transform.position)
            {
                StartCoroutine(WaitHomePanel());
                moveToHome = false;
            }
        }

        else if (moveToInvestory == true)
        {

            transform.position = Vector2.MoveTowards(transform.position, waypoins[1].transform.position, speed * Time.deltaTime);
            if (transform.position == waypoins[1].transform.position)
            {
                StartCoroutine(WaitInvestoryPanel());
                moveToInvestory = false;
            }
        }

        else if (moveToWorkPlace == true)
        {

            transform.position = Vector2.MoveTowards(transform.position, waypoins[2].transform.position, speed * Time.deltaTime);
            if (transform.position == waypoins[2].transform.position)
            {
                StartCoroutine(WaitWorkplacePanel());
                moveToWorkPlace = false;
            }
        }

        else if (moveToHospital == true)
        {

            transform.position = Vector2.MoveTowards(transform.position, waypoins[3].transform.position, speed * Time.deltaTime);
            if (transform.position == waypoins[3].transform.position)
            {
                StartCoroutine(WaithospitalPanel());
                moveToHospital = false;
            }


        }

        else if (moveToShop == true)
        {

            transform.position = Vector2.MoveTowards(transform.position, waypoins[4].transform.position, speed * Time.deltaTime);
            if (transform.position == waypoins[4].transform.position)
            {
                StartCoroutine(WaitShopPanel());
                moveToShop = false;
            }
        }

        else if (moveToBank == true)
        {

            transform.position = Vector2.MoveTowards(transform.position, waypoins[5].transform.position, speed * Time.deltaTime);
            if (transform.position == waypoins[5].transform.position)
            {
                StartCoroutine(WaitBankPanel());
                moveToBank = false;
            }
        }

        else if (moveToRestaurrant == true)
        {

            transform.position = Vector2.MoveTowards(transform.position, waypoins[6].transform.position, speed * Time.deltaTime);
            if (transform.position == waypoins[6].transform.position)
            {
                StartCoroutine(WaitRestaurrantPanel());
                moveToRestaurrant = false;
            }
        }
    }

    //WaitPanel
    IEnumerator WaitHomePanel()
    {
        yield return new WaitForSeconds(0.4f);
        homePanel.SetActive(true);
    }
    IEnumerator WaitInvestoryPanel()
    {
        yield return new WaitForSeconds(0.4f);
        investoryPanel.SetActive(true);
    }
    IEnumerator WaitWorkplacePanel()
    {
        yield return new WaitForSeconds(0.4f);
        workplacePanel.SetActive(true);
    }
    IEnumerator WaithospitalPanel()
    {
        yield return new WaitForSeconds(0.4f);
        hospitalPanel.SetActive(true);
    }
    IEnumerator WaitShopPanel()
    {
        yield return new WaitForSeconds(0.4f);
        shopPanel.SetActive(true);
    }
    IEnumerator WaitBankPanel()
    {
       yield return new WaitForSeconds(0.4f);
       bankPanel.SetActive(true);
    }
    IEnumerator WaitRestaurrantPanel()
    {
        yield return new WaitForSeconds(0.4f);
        restaurrantPanel.SetActive(true);
    }

    // OpenAllPanel
    public void Home()
    {
        moveToHome = true;
        moveToInvestory = false;
        moveToWorkPlace = false;
        moveToHospital = false;
        moveToShop = false;
        moveToBank = false;
        moveToRestaurrant = false;
        //StartCoroutine(WaitHomePanel());
    }
    public void INVESTORY()
    {
        moveToInvestory = true;
        moveToHome = false;
        moveToWorkPlace = false;
        moveToHospital = false;
        moveToShop = false;
        moveToBank = false;
        moveToRestaurrant = false;
        //StartCoroutine(WaitInvestoryPanel());
    }
    public void WorkPlace()
    {
        moveToWorkPlace = true;
        moveToHome = false;
        moveToInvestory = false;
        moveToHospital = false;
        moveToShop = false;
        moveToBank = false;
        moveToRestaurrant = false;
        //StartCoroutine(WaitWorkplacePanel());
    }
    public void Hospital()
    {
        moveToHospital = true;
        moveToHome = false;
        moveToInvestory = false;
        moveToWorkPlace = false;
        moveToShop = false;
        moveToBank = false;
        moveToRestaurrant = false;
        //StartCoroutine(WaithospitalPanel());
    }
    public void Shop()
    {
        moveToShop = true;
        moveToHome = false;
        moveToInvestory = false;
        moveToWorkPlace = false;
        moveToHospital = false;
        moveToBank = false;
        moveToRestaurrant = false;
        //StartCoroutine(WaitShopPanel());
    }
    public void Bank()
    {
        moveToBank = true;
        moveToHome = false;
        moveToInvestory = false;
        moveToWorkPlace = false;
        moveToHospital = false;
        moveToShop = false;
        moveToRestaurrant = false;
        //StartCoroutine(WaitBankPanel());
    }
    public void Restaurrant()
    {
        moveToRestaurrant = true;
        moveToHome = false;
        moveToInvestory = false;
        moveToWorkPlace = false;
        moveToHospital = false;
        moveToShop = false;
        moveToBank = false;
        //StartCoroutine(WaitRestaurrantPanel());
    }

    //CloseAllPanel
    public void CloseHome()
    {
        homePanel.SetActive(false);
    }
    public void CloseINVESTORY()
    {
        investoryPanel.SetActive(false);
    }
    public void CloseWorkPlace()
    {
        workplacePanel.SetActive(false);
    }
    public void CloseHospital()
    {
        hospitalPanel.SetActive(false);
    }
    public void CloseShop()
    {
        shopPanel.SetActive(false);
    }
    public void CloseBank()
    {
        bankPanel.SetActive(false);
    }
    public void CloseRestaurrant()
    {
        restaurrantPanel.SetActive(false);
    }
}
