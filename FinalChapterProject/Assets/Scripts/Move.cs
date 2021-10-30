using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    public Work work;
    public Restaurrant restaurrant;
    public HomePro homepro;
    public Hospital hospital;
    public Investory investory;

    public Transform[] waypoins;
 
    public GameObject homePanel, investoryPanel, workplacePanel, hospitalPanel,
        shopPanel, bankPanel, restaurrantPanel;

    [SerializeField]
    public float speed;

    public bool moveToHome, moveToInvestory, moveToWorkPlace, moveToHospital,
        moveToHomePro, moveToBank, moveToRestaurrant = false;
    public bool atHome, atInvestory, atWork, atHopital, atHomePro, atBank, atRestaurrant;

    public int markPositionNumber; // 1=Home 3=Investory 5=work 6=Hopital 8=HomePro 11=Bank 12=Restaurrant
    public float timeDeley;


    // Start is called before the first frame update
    void Start()
    {
        markPositionNumber = 1;
        atHome = true;


        homePanel.transform.localScale = Vector2.zero;
        investoryPanel.transform.localScale = Vector2.zero;
        workplacePanel.transform.localScale = Vector2.zero;
        hospitalPanel.transform.localScale = Vector2.zero;
        shopPanel.transform.localScale = Vector2.zero;
        bankPanel.transform.localScale = Vector2.zero;
        restaurrantPanel.transform.localScale = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {

        MoveTo();
    }

    // Move
    public void MoveTo()
    {
        if (atHome == true)
        {
            if (moveToHome == true)
            {

                StartCoroutine(GoToWayPointOne());

                if (transform.position == waypoins[0].transform.position)
                {
                    StartCoroutine(WaitHomePanel());

                    moveToHome = false;
                }
            }

            else if (moveToInvestory == true)
            {

                if (markPositionNumber == 1)
                {
                    StartCoroutine(GoToWayPointTwo());

                }
                else if (markPositionNumber == 2)
                {
                    StartCoroutine(GoToWayPointThree());

                }
                else if (transform.position == waypoins[2].transform.position)
                {
                    investory.UnBlockCourse();
                    investory.UnBlockDeptDetail();

                    StartCoroutine(WaitInvestoryPanel());
                    atInvestory = true;
                    atHome = false;
                    moveToInvestory = false;
                }
            }

            else if (moveToWorkPlace == true)
            {
                if (markPositionNumber == 1)
                {
                    StartCoroutine(GoToWayPointTwo());

                }
                else if (markPositionNumber == 2)
                {
                    StartCoroutine(GoToWayPointThree());

                }
                else if (markPositionNumber == 3)
                {
                    StartCoroutine(GoToWayPointFour());

                }
                else if (markPositionNumber == 4)
                {
                    StartCoroutine(GoToWayPointFive());

                }
                else if (transform.position == waypoins[4].transform.position)
                {
                    work.UnLockWork(); //CheckUnlockWork 2 and 3   (Foem Work scripts)

                    StartCoroutine(WaitWorkplacePanel());
                    atWork = true;
                    atHome = false;
                    moveToWorkPlace = false;
                }
            }

            else if (moveToHospital == true)
            {
                if (markPositionNumber == 1)
                {
                    StartCoroutine(GoToWayPointTwo());

                }
                else if (markPositionNumber == 2)
                {
                    StartCoroutine(GoToWayPointSeven());

                }
                else if (markPositionNumber == 7)
                {
                    StartCoroutine(GoToWayPointSix());

                }
                else if (transform.position == waypoins[5].transform.position)
                {
                    hospital.UnBlockHeal();

                    StartCoroutine(WaithospitalPanel());
                    atHopital = true;
                    atHome = false;
                    moveToHospital = false;
                }


            }

            else if (moveToHomePro == true)
            {
                if (markPositionNumber == 1)
                {
                    StartCoroutine(GoToWayPointTwo());

                }
                else if (markPositionNumber == 2)
                {
                    StartCoroutine(GoToWayPointSeven());

                }
                else if (markPositionNumber == 7)
                {
                    StartCoroutine(GoToWayPointEight());

                }
                else if (transform.position == waypoins[7].transform.position)
                {
                    homepro.UnBlockBuy();

                    StartCoroutine(WaitShopPanel());
                    atHomePro = true;
                    atHome = false;
                    moveToHomePro = false;
                }
            }

            else if (moveToBank == true)
            {
                if (markPositionNumber == 1)
                {
                    StartCoroutine(GoToWayPointTwo());

                }
                else if (markPositionNumber == 2)
                {
                    StartCoroutine(GoToWayPointThree());

                }
                else if (markPositionNumber == 3)
                {
                    StartCoroutine(GoToWayPointFour());

                }
                else if (markPositionNumber == 4)
                {
                    StartCoroutine(GoToWayPointTen());

                }
                else if (markPositionNumber == 10)
                {
                    StartCoroutine(GoToWayPointEleven());

                }
                else if (transform.position == waypoins[10].transform.position)
                {
                    StartCoroutine(WaitBankPanel());
                    atBank = true;
                    atHome = false;
                    moveToBank = false;
                }
            }

            else if (moveToRestaurrant == true)
            {
                if (markPositionNumber == 1)
                {
                    StartCoroutine(GoToWayPointTwo());

                }
                else if (markPositionNumber == 2)
                {
                    StartCoroutine(GoToWayPointSeven());

                }
                else if (markPositionNumber == 7)
                {
                    StartCoroutine(GoToWayPointEight());

                }
                else if (markPositionNumber == 8)
                {
                    StartCoroutine(GoToWayPointNine());

                }
                else if (markPositionNumber == 9)
                {
                    StartCoroutine(GoToWayPointTwelve());

                }
                else if (transform.position == waypoins[11].transform.position)
                {
                    restaurrant.UnBlockBuy();

                    StartCoroutine(WaitRestaurrantPanel());
                    atRestaurrant = true;
                    atHome = false;
                    moveToRestaurrant = false;
                }
            }
        }
        else if (atInvestory == true)
        {
            if (moveToHome == true)
            {
                if (markPositionNumber == 3)
                {
                    StartCoroutine(GoToWayPointTwo());

                }
                else if (markPositionNumber == 2)
                {
                    StartCoroutine(GoToWayPointOne());
                }
                else if (transform.position == waypoins[0].transform.position)
                {
                    StartCoroutine(WaitHomePanel());
                    atHome = true;
                    atInvestory = false;
                    moveToHome = false;
                }
            }

            else if (moveToInvestory == true)
            {

                StartCoroutine(GoToWayPointThree());

                if (transform.position == waypoins[2].transform.position)
                {
                    investory.UnBlockCourse();
                    investory.UnBlockDeptDetail();

                    StartCoroutine(WaitInvestoryPanel());

                    moveToInvestory = false;
                }
            }

            else if (moveToWorkPlace == true)
            {
                if (markPositionNumber == 3)
                {
                    StartCoroutine(GoToWayPointFour());

                }
                else if (markPositionNumber == 4)
                {
                    StartCoroutine(GoToWayPointFive());

                }
                else if (transform.position == waypoins[4].transform.position)
                {
                    work.UnLockWork(); //CheckUnlockWork 2 and 3   (Foem Work scripts)

                    StartCoroutine(WaitWorkplacePanel());
                    atWork = true;
                    atInvestory = false;
                    moveToWorkPlace = false;
                }
            }

            else if (moveToHospital == true)
            {
                if (markPositionNumber == 3)
                {
                    StartCoroutine(GoToWayPointTwo());

                }
                else if (markPositionNumber == 2)
                {
                    StartCoroutine(GoToWayPointSeven());

                }
                else if (markPositionNumber == 7)
                {
                    StartCoroutine(GoToWayPointSix());

                }
                else if (transform.position == waypoins[5].transform.position)
                {
                    hospital.UnBlockHeal();

                    StartCoroutine(WaithospitalPanel());
                    atHopital = true;
                    atInvestory = false;
                    moveToHospital = false;
                }
            }

            else if (moveToHomePro == true)
            {
                if (markPositionNumber == 3)
                {
                    StartCoroutine(GoToWayPointTwo());

                }
                else if (markPositionNumber == 2)
                {
                    StartCoroutine(GoToWayPointSeven());

                }
                else if (markPositionNumber == 7)
                {
                    StartCoroutine(GoToWayPointEight());

                }
                else if (transform.position == waypoins[7].transform.position)
                {
                    homepro.UnBlockBuy();

                    StartCoroutine(WaitShopPanel());
                    atHomePro = true;
                    atInvestory = false;
                    moveToHomePro = false;
                }
            }

            else if (moveToBank == true)
            {
                if (markPositionNumber == 3)
                {
                    StartCoroutine(GoToWayPointFour());

                }
                else if (markPositionNumber == 4)
                {
                    StartCoroutine(GoToWayPointTen());

                }
                else if (markPositionNumber == 10)
                {
                    StartCoroutine(GoToWayPointEleven());

                }
                else if (transform.position == waypoins[10].transform.position)
                {
                    StartCoroutine(WaitBankPanel());
                    atBank = true;
                    atInvestory = false;
                    moveToBank = false;
                }
            }

            else if (moveToRestaurrant == true)
            {
                if (markPositionNumber == 3)
                {
                    StartCoroutine(GoToWayPointFour());

                }
                else if (markPositionNumber == 4)
                {
                    StartCoroutine(GoToWayPointTen());

                }
                else if (markPositionNumber == 10)
                {
                    StartCoroutine(GoToWayPointNine());

                }
                else if (markPositionNumber == 9)
                {
                    StartCoroutine(GoToWayPointTwelve());

                }
                else if (transform.position == waypoins[11].transform.position)
                {
                    restaurrant.UnBlockBuy();

                    StartCoroutine(WaitRestaurrantPanel());
                    atRestaurrant = true;
                    atInvestory = false;
                    moveToRestaurrant = false;
                }
            }
        }
        else if (atWork == true)
        {
            if (moveToHome == true)
            {
                if (markPositionNumber == 5)
                {
                    StartCoroutine(GoToWayPointFour());

                }
                else if (markPositionNumber == 4)
                {
                    StartCoroutine(GoToWayPointThree());
                }
                else if (markPositionNumber == 3)
                {
                    StartCoroutine(GoToWayPointTwo());
                }
                else if (markPositionNumber == 2)
                {
                    StartCoroutine(GoToWayPointOne());
                }
                else if (transform.position == waypoins[0].transform.position)
                {
                    StartCoroutine(WaitHomePanel());
                    atHome = true;
                    atWork = false;
                    moveToHome = false;
                }
            }

            else if (moveToInvestory == true)
            {
                if (markPositionNumber == 5)
                {
                    StartCoroutine(GoToWayPointFour());

                }
                else if (markPositionNumber == 4)
                {
                    StartCoroutine(GoToWayPointThree());
                }
                else if (transform.position == waypoins[2].transform.position)
                {
                    investory.UnBlockCourse();
                    investory.UnBlockDeptDetail();

                    StartCoroutine(WaitInvestoryPanel());
                    atInvestory = true;
                    atWork = false;
                    moveToInvestory = false;
                }
            }

            else if (moveToWorkPlace == true)
            {

                StartCoroutine(GoToWayPointFive());

                if (transform.position == waypoins[4].transform.position)
                {
                    work.UnLockWork(); //CheckUnlockWork 2 and 3   (Foem Work scripts)

                    StartCoroutine(WaitWorkplacePanel());

                    moveToWorkPlace = false;
                }
            }

            else if (moveToHospital == true)
            {
                if (markPositionNumber == 5)
                {
                    StartCoroutine(GoToWayPointFour());

                }
                else if (markPositionNumber == 4)
                {
                    StartCoroutine(GoToWayPointThree());
                }
                else if (markPositionNumber == 3)
                {
                    StartCoroutine(GoToWayPointTwo());
                }
                else if (markPositionNumber == 2)
                {
                    StartCoroutine(GoToWayPointSeven());

                }
                else if (markPositionNumber == 7)
                {
                    StartCoroutine(GoToWayPointSix());

                }
                else if (transform.position == waypoins[5].transform.position)
                {
                    hospital.UnBlockHeal();

                    StartCoroutine(WaithospitalPanel());
                    atHopital = true;
                    atWork = false;
                    moveToHospital = false;
                }
            }

            else if (moveToHomePro == true)
            {
                if (markPositionNumber == 5)
                {
                    StartCoroutine(GoToWayPointFour());

                }
                else if (markPositionNumber == 4)
                {
                    StartCoroutine(GoToWayPointTen());
                }
                else if (markPositionNumber == 10)
                {
                    StartCoroutine(GoToWayPointNine());
                }
                else if (markPositionNumber == 9)
                {
                    StartCoroutine(GoToWayPointEight());

                }
                else if (transform.position == waypoins[7].transform.position)
                {
                    homepro.UnBlockBuy();

                    StartCoroutine(WaitShopPanel());
                    atHomePro = true;
                    atWork = false;
                    moveToHomePro = false;
                }
            }

            else if (moveToBank == true)
            {
                if (markPositionNumber == 5)
                {
                    StartCoroutine(GoToWayPointFour());

                }
                else if (markPositionNumber == 4)
                {
                    StartCoroutine(GoToWayPointTen());

                }
                else if (markPositionNumber == 10)
                {
                    StartCoroutine(GoToWayPointEleven());

                }
                else if (transform.position == waypoins[10].transform.position)
                {
                    StartCoroutine(WaitBankPanel());
                    atBank = true;
                    atWork = false;
                    moveToBank = false;
                }
            }

            else if (moveToRestaurrant == true)
            {
                if (markPositionNumber == 5)
                {
                    StartCoroutine(GoToWayPointFour());

                }
                else if (markPositionNumber == 4)
                {
                    StartCoroutine(GoToWayPointTen());
                }
                else if (markPositionNumber == 10)
                {
                    StartCoroutine(GoToWayPointNine());
                }
                else if (markPositionNumber == 9)
                {
                    StartCoroutine(GoToWayPointTwelve());

                }
                else if (transform.position == waypoins[11].transform.position)
                {
                    restaurrant.UnBlockBuy();

                    StartCoroutine(WaitRestaurrantPanel());
                    atRestaurrant = true;
                    atWork = false;
                    moveToRestaurrant = false;
                }
            }
        }
        else if (atHopital == true)
        {
            if (moveToHome == true)
            {
                if (markPositionNumber == 6)
                {
                    StartCoroutine(GoToWayPointSeven());

                }
                else if (markPositionNumber == 7)
                {
                    StartCoroutine(GoToWayPointTwo());
                }
                else if (markPositionNumber == 2)
                {
                    StartCoroutine(GoToWayPointOne());
                }
                else if (transform.position == waypoins[0].transform.position)
                {
                    StartCoroutine(WaitHomePanel());
                    atHome = true;
                    atHopital = false;
                    moveToHome = false;
                }
            }

            else if (moveToInvestory == true)
            {
                if (markPositionNumber == 6)
                {
                    StartCoroutine(GoToWayPointSeven());

                }
                else if (markPositionNumber == 7)
                {
                    StartCoroutine(GoToWayPointTwo());
                }
                else if (markPositionNumber == 2)
                {
                    StartCoroutine(GoToWayPointThree());
                }
                if (transform.position == waypoins[2].transform.position)
                {
                    investory.UnBlockCourse();
                    investory.UnBlockDeptDetail();

                    StartCoroutine(WaitInvestoryPanel());
                    atInvestory = true;
                    atHopital = false;
                    moveToInvestory = false;
                }
            }

            else if (moveToWorkPlace == true)
            {
                if (markPositionNumber == 6)
                {
                    StartCoroutine(GoToWayPointSeven());

                }
                else if (markPositionNumber == 7)
                {
                    StartCoroutine(GoToWayPointTwo());
                }
                else if (markPositionNumber == 2)
                {
                    StartCoroutine(GoToWayPointThree());
                }
                else if (markPositionNumber == 3)
                {
                    StartCoroutine(GoToWayPointFour());
                }
                else if (markPositionNumber == 4)
                {
                    StartCoroutine(GoToWayPointFive());
                }
                else if (transform.position == waypoins[4].transform.position)
                {
                    work.UnLockWork(); //CheckUnlockWork 2 and 3   (Foem Work scripts)

                    StartCoroutine(WaitWorkplacePanel());
                    atWork = true;
                    atHopital = false;
                    moveToWorkPlace = false;
                }
            }

            else if (moveToHospital == true)
            {

                StartCoroutine(GoToWayPointSix());

                if (transform.position == waypoins[5].transform.position)
                {
                    hospital.UnBlockHeal();

                    StartCoroutine(WaithospitalPanel());

                    moveToHospital = false;
                }
            }

            else if (moveToHomePro == true)
            {
                if (markPositionNumber == 6)
                {
                    StartCoroutine(GoToWayPointSeven());

                }
                else if (markPositionNumber == 7)
                {
                    StartCoroutine(GoToWayPointEight());
                }
                else if (transform.position == waypoins[7].transform.position)
                {
                    homepro.UnBlockBuy();

                    StartCoroutine(WaitShopPanel());
                    atHomePro = true;
                    atHopital = false;
                    moveToHomePro = false;
                }
            }

            else if (moveToBank == true)
            {
                if (markPositionNumber == 6)
                {
                    StartCoroutine(GoToWayPointSeven());

                }
                else if (markPositionNumber == 7)
                {
                    StartCoroutine(GoToWayPointEight());
                }
                else if (markPositionNumber == 8)
                {
                    StartCoroutine(GoToWayPointNine());

                }
                else if (markPositionNumber == 9)
                {
                    StartCoroutine(GoToWayPointTen());

                }
                else if (markPositionNumber == 10)
                {
                    StartCoroutine(GoToWayPointEleven());

                }
                else if (transform.position == waypoins[10].transform.position)
                {
                    StartCoroutine(WaitBankPanel());
                    atBank = true;
                    atHopital = false;
                    moveToBank = false;
                }
            }

            else if (moveToRestaurrant == true)
            {
                if (markPositionNumber == 6)
                {
                    StartCoroutine(GoToWayPointSeven());

                }
                else if (markPositionNumber == 7)
                {
                    StartCoroutine(GoToWayPointEight());
                }
                else if (markPositionNumber == 8)
                {
                    StartCoroutine(GoToWayPointNine());

                }
                else if (markPositionNumber == 9)
                {
                    StartCoroutine(GoToWayPointTwelve());

                }
                else if (transform.position == waypoins[11].transform.position)
                {
                    restaurrant.UnBlockBuy();

                    StartCoroutine(WaitRestaurrantPanel());
                    atRestaurrant = true;
                    atHopital = false;
                    moveToRestaurrant = false;
                }
            }
        }
        else if (atHomePro == true)
        {
            if (moveToHome == true)
            {
                if (markPositionNumber == 8)
                {
                    StartCoroutine(GoToWayPointSeven());

                }
                else if (markPositionNumber == 7)
                {
                    StartCoroutine(GoToWayPointTwo());
                }
                else if (markPositionNumber == 2)
                {
                    StartCoroutine(GoToWayPointOne());
                }
                else if (transform.position == waypoins[0].transform.position)
                {
                    StartCoroutine(WaitHomePanel());
                    atHome = true;
                    atHomePro = false;
                    moveToHome = false;
                }
            }

            else if (moveToInvestory == true)
            {
                if (markPositionNumber == 8)
                {
                    StartCoroutine(GoToWayPointSeven());

                }
                else if (markPositionNumber == 7)
                {
                    StartCoroutine(GoToWayPointTwo());
                }
                else if (markPositionNumber == 2)
                {
                    StartCoroutine(GoToWayPointThree());
                }
                if (transform.position == waypoins[2].transform.position)
                {
                    investory.UnBlockCourse();
                    investory.UnBlockDeptDetail();

                    StartCoroutine(WaitInvestoryPanel());
                    atInvestory = true;
                    atHomePro = false;
                    moveToInvestory = false;
                }
            }

            else if (moveToWorkPlace == true)
            {
                if (markPositionNumber == 8)
                {
                    StartCoroutine(GoToWayPointNine());

                }
                else if (markPositionNumber == 9)
                {
                    StartCoroutine(GoToWayPointTen());
                }
                else if (markPositionNumber == 10)
                {
                    StartCoroutine(GoToWayPointFour());
                }
                else if (markPositionNumber == 4)
                {
                    StartCoroutine(GoToWayPointFive());
                }
                else if (transform.position == waypoins[4].transform.position)
                {
                    work.UnLockWork(); //CheckUnlockWork 2 and 3   (Foem Work scripts)

                    StartCoroutine(WaitWorkplacePanel());
                    atWork = true;
                    atHomePro = false;
                    moveToWorkPlace = false;
                }
            }

            else if (moveToHospital == true)
            {

                if (markPositionNumber == 8)
                {
                    StartCoroutine(GoToWayPointSeven());

                }
                else if (markPositionNumber == 7)
                {
                    StartCoroutine(GoToWayPointSix());
                }
                else if (transform.position == waypoins[5].transform.position)
                {
                    hospital.UnBlockHeal();

                    StartCoroutine(WaithospitalPanel());
                    atHopital = true;
                    atHomePro = false;
                    moveToHospital = false;
                }
            }

            else if (moveToHomePro == true)
            {

                StartCoroutine(GoToWayPointEight());

                if (transform.position == waypoins[7].transform.position)
                {
                    homepro.UnBlockBuy();

                    StartCoroutine(WaitShopPanel());

                    moveToHomePro = false;
                }
            }

            else if (moveToBank == true)
            {
                if (markPositionNumber == 8)
                {
                    StartCoroutine(GoToWayPointNine());

                }
                else if (markPositionNumber == 9)
                {
                    StartCoroutine(GoToWayPointTen());
                }
                else if (markPositionNumber == 10)
                {
                    StartCoroutine(GoToWayPointEleven());

                }
                else if (transform.position == waypoins[10].transform.position)
                {
                    StartCoroutine(WaitBankPanel());
                    atBank = true;
                    atHomePro = false;
                    moveToBank = false;
                }
            }

            else if (moveToRestaurrant == true)
            {
                if (markPositionNumber == 8)
                {
                    StartCoroutine(GoToWayPointNine());

                }
                else if (markPositionNumber == 9)
                {
                    StartCoroutine(GoToWayPointTwelve());

                }
                else if (transform.position == waypoins[11].transform.position)
                {
                    restaurrant.UnBlockBuy();

                    StartCoroutine(WaitRestaurrantPanel());
                    atRestaurrant = true;
                    atHomePro = false;
                    moveToRestaurrant = false;
                }
            }
        }
        else if (atBank == true)
        {
            if (moveToHome == true)
            {
                if (markPositionNumber == 11)
                {
                    StartCoroutine(GoToWayPointTen());

                }
                else if (markPositionNumber == 10)
                {
                    StartCoroutine(GoToWayPointFour());
                }
                else if (markPositionNumber == 4)
                {
                    StartCoroutine(GoToWayPointThree());
                }
                else if (markPositionNumber == 3)
                {
                    StartCoroutine(GoToWayPointTwo());
                }
                else if (markPositionNumber == 2)
                {
                    StartCoroutine(GoToWayPointOne());
                }
                else if (transform.position == waypoins[0].transform.position)
                {
                    StartCoroutine(WaitHomePanel());
                    atHome = true;
                    atBank = false;
                    moveToHome = false;
                }
            }

            else if (moveToInvestory == true)
            {
                if (markPositionNumber == 11)
                {
                    StartCoroutine(GoToWayPointTen());

                }
                else if (markPositionNumber == 10)
                {
                    StartCoroutine(GoToWayPointFour());
                }
                else if (markPositionNumber == 4)
                {
                    StartCoroutine(GoToWayPointThree());
                }
                if (transform.position == waypoins[2].transform.position)
                {
                    investory.UnBlockCourse();
                    investory.UnBlockDeptDetail();

                    StartCoroutine(WaitInvestoryPanel());
                    atInvestory = true;
                    atBank = false;
                    moveToInvestory = false;
                }
            }

            else if (moveToWorkPlace == true)
            {
                if (markPositionNumber == 11)
                {
                    StartCoroutine(GoToWayPointTen());

                }
                else if (markPositionNumber == 10)
                {
                    StartCoroutine(GoToWayPointFour());
                }
                else if (markPositionNumber == 4)
                {
                    StartCoroutine(GoToWayPointFive());
                }
                else if (transform.position == waypoins[4].transform.position)
                {
                    work.UnLockWork(); //CheckUnlockWork 2 and 3   (Foem Work scripts)

                    StartCoroutine(WaitWorkplacePanel());
                    atWork = true;
                    atBank = false;
                    moveToWorkPlace = false;
                }
            }

            else if (moveToHospital == true)
            {

                if (markPositionNumber == 11)
                {
                    StartCoroutine(GoToWayPointTen());

                }
                else if (markPositionNumber == 10)
                {
                    StartCoroutine(GoToWayPointNine());
                }
                else if (markPositionNumber == 9)
                {
                    StartCoroutine(GoToWayPointEight());
                }
                else if (markPositionNumber == 8)
                {
                    StartCoroutine(GoToWayPointSeven());
                }
                else if (markPositionNumber == 7)
                {
                    StartCoroutine(GoToWayPointSix());
                }
                else if (transform.position == waypoins[5].transform.position)
                {
                    hospital.UnBlockHeal();

                    StartCoroutine(WaithospitalPanel());
                    atHopital = true;
                    atBank = false;
                    moveToHospital = false;
                }
            }

            else if (moveToHomePro == true)
            {

                if (markPositionNumber == 11)
                {
                    StartCoroutine(GoToWayPointTen());

                }
                else if (markPositionNumber == 10)
                {
                    StartCoroutine(GoToWayPointNine());
                }
                else if (markPositionNumber == 9)
                {
                    StartCoroutine(GoToWayPointEight());
                }
                else if (transform.position == waypoins[7].transform.position)
                {
                    homepro.UnBlockBuy();

                    StartCoroutine(WaitShopPanel());
                    atHomePro = true;
                    atBank = false;
                    moveToHomePro = false;
                }
            }

            else if (moveToBank == true)
            {

                StartCoroutine(GoToWayPointEleven());

                if (transform.position == waypoins[10].transform.position)
                {
                    StartCoroutine(WaitBankPanel());

                    moveToBank = false;
                }
            }

            else if (moveToRestaurrant == true)
            {
                if (markPositionNumber == 11)
                {
                    StartCoroutine(GoToWayPointTen());

                }
                else if (markPositionNumber == 10)
                {
                    StartCoroutine(GoToWayPointNine());
                }
                else if (markPositionNumber == 9)
                {
                    StartCoroutine(GoToWayPointTwelve());

                }
                else if (transform.position == waypoins[11].transform.position)
                {
                    restaurrant.UnBlockBuy();

                    StartCoroutine(WaitRestaurrantPanel());
                    atRestaurrant = true;
                    atBank = false;
                    moveToRestaurrant = false;
                }
            }
        }
        else if (atRestaurrant == true)
        {
            if (moveToHome == true)
            {
                if (markPositionNumber == 12)
                {
                    StartCoroutine(GoToWayPointNine());

                }
                else if (markPositionNumber == 9)
                {
                    StartCoroutine(GoToWayPointEight());
                }
                else if (markPositionNumber == 8)
                {
                    StartCoroutine(GoToWayPointSeven());
                }
                else if (markPositionNumber == 7)
                {
                    StartCoroutine(GoToWayPointTwo());
                }
                else if (markPositionNumber == 2)
                {
                    StartCoroutine(GoToWayPointOne());
                }
                else if (transform.position == waypoins[0].transform.position)
                {
                    StartCoroutine(WaitHomePanel());
                    atHome = true;
                    atRestaurrant = false;
                    moveToHome = false;
                }
            }

            else if (moveToInvestory == true)
            {
                if (markPositionNumber == 12)
                {
                    StartCoroutine(GoToWayPointNine());

                }
                else if (markPositionNumber == 9)
                {
                    StartCoroutine(GoToWayPointTen());
                }
                else if (markPositionNumber == 10)
                {
                    StartCoroutine(GoToWayPointFour());
                }
                else if (markPositionNumber == 4)
                {
                    StartCoroutine(GoToWayPointThree());
                }
                if (transform.position == waypoins[2].transform.position)
                {
                    investory.UnBlockCourse();
                    investory.UnBlockDeptDetail();

                    StartCoroutine(WaitInvestoryPanel());
                    atInvestory = true;
                    atRestaurrant = false;
                    moveToInvestory = false;
                }
            }

            else if (moveToWorkPlace == true)
            {
                if (markPositionNumber == 12)
                {
                    StartCoroutine(GoToWayPointNine());

                }
                else if (markPositionNumber == 9)
                {
                    StartCoroutine(GoToWayPointTen());
                }
                else if (markPositionNumber == 10)
                {
                    StartCoroutine(GoToWayPointFour());
                }
                else if (markPositionNumber == 4)
                {
                    StartCoroutine(GoToWayPointFive());
                }
                else if (transform.position == waypoins[4].transform.position)
                {
                    work.UnLockWork(); //CheckUnlockWork 2 and 3   (Foem Work scripts)

                    StartCoroutine(WaitWorkplacePanel());
                    atWork = true;
                    atRestaurrant = false;
                    moveToWorkPlace = false;
                }
            }

            else if (moveToHospital == true)
            {

                if (markPositionNumber == 12)
                {
                    StartCoroutine(GoToWayPointNine());

                }
                else if (markPositionNumber == 9)
                {
                    StartCoroutine(GoToWayPointEight());
                }
                else if (markPositionNumber == 8)
                {
                    StartCoroutine(GoToWayPointSeven());
                }
                else if (markPositionNumber == 7)
                {
                    StartCoroutine(GoToWayPointSix());
                }
                else if (transform.position == waypoins[5].transform.position)
                {
                    hospital.UnBlockHeal();

                    StartCoroutine(WaithospitalPanel());
                    atHopital = true;
                    atRestaurrant = false;
                    moveToHospital = false;
                }
            }

            else if (moveToHomePro == true)
            {

                if (markPositionNumber == 12)
                {
                    StartCoroutine(GoToWayPointNine());

                }
                else if (markPositionNumber == 9)
                {
                    StartCoroutine(GoToWayPointEight());
                }
                else if (transform.position == waypoins[7].transform.position)
                {
                    homepro.UnBlockBuy();

                    StartCoroutine(WaitShopPanel());
                    atHomePro = true;
                    atRestaurrant = false;
                    moveToHomePro = false;
                }
            }

            else if (moveToBank == true)
            {

                if (markPositionNumber == 12)
                {
                    StartCoroutine(GoToWayPointNine());

                }
                else if (markPositionNumber == 9)
                {
                    StartCoroutine(GoToWayPointTen());
                }
                else if (markPositionNumber == 10)
                {
                    StartCoroutine(GoToWayPointEleven());
                }
                else if (transform.position == waypoins[10].transform.position)
                {
                    StartCoroutine(WaitBankPanel());
                    atBank = true;
                    atRestaurrant = false;
                    moveToBank = false;
                }
            }

            else if (moveToRestaurrant == true)
            {

                StartCoroutine(GoToWayPointTwelve());

                if (transform.position == waypoins[11].transform.position)
                {
                    restaurrant.UnBlockBuy();

                    StartCoroutine(WaitRestaurrantPanel());

                    moveToRestaurrant = false;
                }
            }
        }
    }

    //Deley Move To WayPoint
    IEnumerator GoToWayPointOne()
    {

        transform.position = Vector2.MoveTowards(transform.position, waypoins[0].transform.position, speed * Time.deltaTime);
        yield return new WaitForSeconds(timeDeley);
        markPositionNumber = 1;
    }
    IEnumerator GoToWayPointTwo()
    {

        transform.position = Vector2.MoveTowards(transform.position, waypoins[1].transform.position, speed * Time.deltaTime);
        yield return new WaitForSeconds(timeDeley);
        markPositionNumber = 2;
    }
    IEnumerator GoToWayPointThree()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoins[2].transform.position, speed * Time.deltaTime);
        yield return new WaitForSeconds(timeDeley);
        markPositionNumber = 3;
    }
    IEnumerator GoToWayPointFour()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoins[3].transform.position, speed * Time.deltaTime);
        yield return new WaitForSeconds(timeDeley);
        markPositionNumber = 4;
    }
    IEnumerator GoToWayPointFive()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoins[4].transform.position, speed * Time.deltaTime);
        yield return new WaitForSeconds(timeDeley);
        markPositionNumber = 5;
    }
    IEnumerator GoToWayPointSix()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoins[5].transform.position, speed * Time.deltaTime);
        yield return new WaitForSeconds(timeDeley);
        markPositionNumber = 6;
    }
    IEnumerator GoToWayPointSeven()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoins[6].transform.position, speed * Time.deltaTime);
        yield return new WaitForSeconds(timeDeley);
        markPositionNumber = 7;
    }
    IEnumerator GoToWayPointEight()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoins[7].transform.position, speed * Time.deltaTime);
        yield return new WaitForSeconds(timeDeley);
        markPositionNumber = 8;
    }
    IEnumerator GoToWayPointNine()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoins[8].transform.position, speed * Time.deltaTime);
        yield return new WaitForSeconds(timeDeley);
        markPositionNumber = 9;
    }
    IEnumerator GoToWayPointTen()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoins[9].transform.position, speed * Time.deltaTime);
        yield return new WaitForSeconds(timeDeley);
        markPositionNumber = 10;
    }
    IEnumerator GoToWayPointEleven()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoins[10].transform.position, speed * Time.deltaTime);
        yield return new WaitForSeconds(timeDeley);
        markPositionNumber = 11;
    }
    IEnumerator GoToWayPointTwelve()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoins[11].transform.position, speed * Time.deltaTime);
        yield return new WaitForSeconds(timeDeley);
        markPositionNumber = 12;
    }

    //WaitPanel
    IEnumerator WaitHomePanel()
    {
        yield return new WaitForSeconds(0.4f);
        homePanel.SetActive(true);
        homePanel.transform.LeanScale(Vector2.one, 0.3f);
    }
    IEnumerator WaitInvestoryPanel()
    {
        yield return new WaitForSeconds(0.4f);
        investoryPanel.SetActive(true);
        investoryPanel.transform.LeanScale(Vector2.one, 0.3f);
    }
    IEnumerator WaitWorkplacePanel()
    {
        yield return new WaitForSeconds(0.4f);
        workplacePanel.SetActive(true);
        workplacePanel.transform.LeanScale(Vector2.one, 0.3f);
    }
    IEnumerator WaithospitalPanel()
    {
        yield return new WaitForSeconds(0.4f);
        hospitalPanel.SetActive(true);
        hospitalPanel.transform.LeanScale(Vector2.one, 0.3f);
    }
    IEnumerator WaitShopPanel()
    {
        yield return new WaitForSeconds(0.4f);
        shopPanel.SetActive(true);
        shopPanel.transform.LeanScale(Vector2.one, 0.3f);
    }
    IEnumerator WaitBankPanel()
    {
       yield return new WaitForSeconds(0.4f);
       bankPanel.SetActive(true);
        bankPanel.transform.LeanScale(Vector2.one, 0.3f);
    }
    IEnumerator WaitRestaurrantPanel()
    {
        yield return new WaitForSeconds(0.4f);
        restaurrantPanel.SetActive(true);
        restaurrantPanel.transform.LeanScale(Vector2.one, 0.3f);
    }

    // OpenAllPanel
    public void Home()
    {
        moveToHome = true;
        moveToInvestory = false;
        moveToWorkPlace = false;
        moveToHospital = false;
        moveToHomePro = false;
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
        moveToHomePro = false;
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
        moveToHomePro = false;
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
        moveToHomePro = false;
        moveToBank = false;
        moveToRestaurrant = false;
        //StartCoroutine(WaithospitalPanel());
    }
    public void Shop()
    {
        moveToHomePro = true;
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
        moveToHomePro = false;
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
        moveToHomePro = false;
        moveToBank = false;
        //StartCoroutine(WaitRestaurrantPanel());
    }

    //CloseAllPanel
    public void CloseHome()
    {
        homePanel.transform.LeanScale(Vector2.zero, 0.6f).setEaseInBack();
        StartCoroutine(WaitCloseHome());
    }
    public void CloseINVESTORY()
    {
        investoryPanel.transform.LeanScale(Vector2.zero, 0.6f).setEaseInBack();
        StartCoroutine(WaitCloseINVESTORY());
    }
    public void CloseWorkPlace()
    {
        workplacePanel.transform.LeanScale(Vector2.zero, 0.6f).setEaseInBack();
        StartCoroutine(WaitCloseWorkPlace());
    }
    public void CloseHospital()
    {
        hospitalPanel.transform.LeanScale(Vector2.zero, 0.6f).setEaseInBack();
        StartCoroutine(WaitCloseHospital());
    }
    public void CloseShop()
    {
        shopPanel.transform.LeanScale(Vector2.zero, 0.6f).setEaseInBack();
        StartCoroutine(WaitCloseShop());
    }
    public void CloseBank()
    {
        bankPanel.transform.LeanScale(Vector2.zero, 0.6f).setEaseInBack();
        StartCoroutine(WaitCloseBank());
    }
    public void CloseRestaurrant()
    {
        restaurrantPanel.transform.LeanScale(Vector2.zero, 0.6f).setEaseInBack();
        StartCoroutine(WaitCloseRestaurrant());
    }

    IEnumerator WaitCloseHome()
    {
        yield return new WaitForSeconds(0.7f);
        homePanel.SetActive(false);
    }
    IEnumerator WaitCloseINVESTORY()
    {
        yield return new WaitForSeconds(0.7f);
        investoryPanel.SetActive(false);
    }
    IEnumerator WaitCloseWorkPlace()
    {
        yield return new WaitForSeconds(0.7f);
        workplacePanel.SetActive(false);
    }
    IEnumerator WaitCloseHospital()
    {
        yield return new WaitForSeconds(0.7f);
        hospitalPanel.SetActive(false);
    }
    IEnumerator WaitCloseShop()
    {
        yield return new WaitForSeconds(0.7f);
        shopPanel.SetActive(false);
    }
    IEnumerator WaitCloseBank()
    {
        yield return new WaitForSeconds(0.7f);
        bankPanel.SetActive(false);
    }
    IEnumerator WaitCloseRestaurrant()
    {
        yield return new WaitForSeconds(0.7f);
        restaurrantPanel.SetActive(false);
    }

    public void ResetRound()
    {
        atHome = true;
        atInvestory = false;
        atWork = false;
        atHopital = false;
        atHomePro = false;
        atBank = false;
        atRestaurrant = false;

        moveToHome = false;
        moveToInvestory = false;
        moveToWorkPlace = false;
        moveToHospital = false;
        moveToHomePro = false;
        moveToBank = false;
        moveToRestaurrant = false;

        markPositionNumber = 1;
    }

}
