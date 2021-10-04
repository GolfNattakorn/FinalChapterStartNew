using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomePro : MonoBehaviour
{
    public Status status;
    public Condo condo;

    //Price
    private int sofapriceold;
    private int tablepriceold;
    private int houseplantpriceold;
    private int fridgepriceold;
    private int televisionpriceold;
    private int videogamepriceold;

    public int sofaPrice;
    public int tablePrice;
    public int houseplantPrice;
    public int fridgePrice;
    public int televisionPrice;
    public int videogamePrice;

    public Text sofaPriceText;
    public Text tablePriceText;
    public Text houseplantPriceText;
    public Text fridgePriceText;
    public Text televisionPriceText;
    public Text videogamePriceText;

    //Furniture Amount
    public string[] furnitureAmount;

    //Tag Sell
    public Image[] sellFurnitureImage;
    public Sprite[] sellSprite;

    //Check Money
    public GameObject[] checkMoney;

    //Check Buy Furniture
    public GameObject[] checkBuyFurniture;

    private bool sofabuy;
    private bool tablebuy;
    private bool houseplantbuy;
    private bool fridgebuy;
    private bool televisionbuy;
    private bool videogamebuy;

    
    

    // Start is called before the first frame update
    void Start()
    {
        sofapriceold = 299;
        tablepriceold = 199;
        houseplantpriceold = 99;
        fridgepriceold = 399;
        televisionpriceold = 499;
        videogamepriceold = 699;

        sofaPrice = sofapriceold;
        tablePrice = tablepriceold;
        houseplantPrice = houseplantpriceold;
        fridgePrice = fridgepriceold;
        televisionPrice = televisionpriceold;
        videogamePrice = videogamepriceold;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Sofa()
    {
        if(status.money >= sofaPrice && status.energy != 0)
        {
            status.money -= sofaPrice;
            status.happy += 10;

            sofabuy = true;
            checkBuyFurniture[0].SetActive(true);
            condo.furnitureInCondo[0].enabled = true; // Add Show Furniture at Condo

            status.OneAction(); //Use Energy
        }
        else
        {
            checkMoney[0].SetActive(true);
        }
    }

    public void Table()
    {
        if (status.money >= tablePrice && status.energy != 0)
        {
            status.money -= tablePrice;
            status.happy += 7;

            tablebuy = true;
            checkBuyFurniture[1].SetActive(true);
            condo.furnitureInCondo[1].enabled = true; // Add Show Furniture at Condo

            status.OneAction(); //Use Energy
        }
        else
        {
            checkMoney[1].SetActive(true);
        }
    }

    public void HousePlant()
    {
        if (status.money >= houseplantPrice && status.energy != 0)
        {
            status.money -= houseplantPrice;
            status.happy += 5;

            houseplantbuy = true;
            checkBuyFurniture[2].SetActive(true);
            condo.furnitureInCondo[2].enabled = true; // Add Show Furniture at Condo

            status.OneAction(); //Use Energy
        }
        else
        {
            checkMoney[2].SetActive(true);
        }
    }

    public void Fridge()
    {
        if (status.money >= fridgePrice && status.energy != 0)
        {
            status.money -= fridgePrice;
            status.happy += 13;

            fridgebuy = true;
            checkBuyFurniture[3].SetActive(true);
            condo.furnitureInCondo[3].enabled = true; // Add Show Furniture at Condo

            status.OneAction(); //Use Energy
        }
        else
        {
            checkMoney[3].SetActive(true);
        }
    }

    public void Television()
    {
        if (status.money >= televisionPrice && status.energy != 0)
        {
            status.money -= televisionPrice;
            status.happy += 15;

            televisionbuy = true;
            checkBuyFurniture[4].SetActive(true);
            condo.furnitureInCondo[4].enabled = true; // Add Show Furniture at Condo

            status.OneAction(); //Use Energy
        }
        else
        {
            checkMoney[4].SetActive(true);
        }
    }

    public void VideoGame()
    {
        if (status.money >= videogamePrice && status.energy != 0)
        {
            status.money -= videogamePrice;
            status.happy += 20;

            videogamebuy = true;
            checkBuyFurniture[5].SetActive(true);
            condo.furnitureInCondo[5].enabled = true; // Add Show Furniture at Condo

            status.OneAction(); //Use Energy
        }
        else
        {
            checkMoney[5].SetActive(true);
        }
    }

    public void CheckFurnitureSell()
    {
        for(int i = 0; i < furnitureAmount.Length; i++)
        {
            int random = Random.Range(0, 7);
            switch (furnitureAmount[i])
            {
                case "Sofa":
                    if(sofabuy == false)
                    {
                        switch (random)
                        {
                            case 0:
                                sofaPrice = sofapriceold;
                                sofaPriceText.text = " - " + sofaPrice;
                                sellFurnitureImage[0].enabled = false;
                                break;
                            case 1:
                                sofaPrice = sofapriceold - (sofapriceold * 10 / 100);
                                sofaPriceText.text = " - " + sofaPrice;
                                sellFurnitureImage[0].enabled = true;
                                sellFurnitureImage[0].sprite = sellSprite[0];
                                break;
                            case 2:
                                sofaPrice = sofapriceold - (sofapriceold * 20 / 100);
                                sofaPriceText.text = " - " + sofaPrice;
                                sellFurnitureImage[0].enabled = true;
                                sellFurnitureImage[0].sprite = sellSprite[1];
                                break;
                            case 3:
                                sofaPrice = sofapriceold - (sofapriceold * 30 / 100);
                                sofaPriceText.text = " - " + sofaPrice;
                                sellFurnitureImage[0].enabled = true;
                                sellFurnitureImage[0].sprite = sellSprite[2];
                                break;
                            case 4:
                                sofaPrice = sofapriceold - (sofapriceold * 40 / 100);
                                sofaPriceText.text = " - " + sofaPrice;
                                sellFurnitureImage[0].enabled = true;
                                sellFurnitureImage[0].sprite = sellSprite[3];
                                break;
                            case 5:
                                sofaPrice = sofapriceold - (sofapriceold * 50 / 100);
                                sofaPriceText.text = " - " + sofaPrice;
                                sellFurnitureImage[0].enabled = true;
                                sellFurnitureImage[0].sprite = sellSprite[4];
                                break;
                            case 6:
                                sofaPrice = sofapriceold - (sofapriceold * 60 / 100);
                                sofaPriceText.text = " - " + sofaPrice;
                                sellFurnitureImage[0].enabled = true;
                                sellFurnitureImage[0].sprite = sellSprite[5];
                                break;
                        }
                    }
                    else
                    {
                        checkBuyFurniture[0].SetActive(true);
                        
                        
                    }
                    break;
                case "Table":
                    if(tablebuy == false)
                    {
                        switch (random)
                        {
                            case 0:
                                tablePrice = tablepriceold;
                                tablePriceText.text = " - " + tablePrice;
                                sellFurnitureImage[1].enabled = false;
                                
                                break;
                            case 1:
                                tablePrice = tablepriceold - (tablepriceold * 10 / 100);
                                tablePriceText.text = " - " + tablePrice;
                                sellFurnitureImage[1].enabled = true;
                                sellFurnitureImage[1].sprite = sellSprite[0];
                                break;
                            case 2:
                                tablePrice = tablepriceold - (tablepriceold * 20 / 100);
                                tablePriceText.text = " - " + tablePrice;
                                sellFurnitureImage[1].enabled = true;
                                sellFurnitureImage[1].sprite = sellSprite[1];
                                break;
                            case 3:
                                tablePrice = tablepriceold - (tablepriceold * 30 / 100);
                                tablePriceText.text = " - " + tablePrice;
                                sellFurnitureImage[1].enabled = true;
                                sellFurnitureImage[1].sprite = sellSprite[2];
                                break;
                            case 4:
                                tablePrice = tablepriceold - (tablepriceold * 40 / 100);
                                tablePriceText.text = " - " + tablePrice;
                                sellFurnitureImage[1].enabled = true;
                                sellFurnitureImage[1].sprite = sellSprite[3];
                                break;
                            case 5:
                                tablePrice = tablepriceold - (tablepriceold * 50 / 100);
                                tablePriceText.text = " - " + tablePrice;
                                sellFurnitureImage[1].enabled = true;
                                sellFurnitureImage[1].sprite = sellSprite[4];
                                break;
                            case 6:
                                tablePrice = tablepriceold - (tablepriceold * 60 / 100);
                                tablePriceText.text = " - " + tablePrice;
                                sellFurnitureImage[1].enabled = true;
                                sellFurnitureImage[1].sprite = sellSprite[5];
                                break;
                        }
                    }
                    else
                    {
                        checkBuyFurniture[1].SetActive(true);
                        
                        
                    }
                    break;
                case "HousePlant":
                    if(houseplantbuy == false)
                    {
                        switch (random)
                        {
                            case 0:
                                houseplantPrice = houseplantpriceold;
                                houseplantPriceText.text = " - " + houseplantPrice;
                                sellFurnitureImage[2].enabled = false;
                                
                                break;
                            case 1:
                                houseplantPrice = houseplantpriceold - (houseplantpriceold * 10 / 100);
                                houseplantPriceText.text = " - " + houseplantPrice;
                                sellFurnitureImage[2].enabled = true;
                                sellFurnitureImage[2].sprite = sellSprite[0];
                                break;
                            case 2:
                                houseplantPrice = houseplantpriceold - (houseplantpriceold * 20 / 100);
                                houseplantPriceText.text = " - " + houseplantPrice;
                                sellFurnitureImage[2].enabled = true;
                                sellFurnitureImage[2].sprite = sellSprite[1];
                                break;
                            case 3:
                                houseplantPrice = houseplantpriceold - (houseplantpriceold * 30 / 100);
                                houseplantPriceText.text = " - " + houseplantPrice;
                                sellFurnitureImage[2].enabled = true;
                                sellFurnitureImage[2].sprite = sellSprite[2];
                                break;
                            case 4:
                                houseplantPrice = houseplantpriceold - (houseplantpriceold * 40 / 100);
                                houseplantPriceText.text = " - " + houseplantPrice;
                                sellFurnitureImage[2].enabled = true;
                                sellFurnitureImage[2].sprite = sellSprite[3];
                                break;
                            case 5:
                                houseplantPrice = houseplantpriceold - (houseplantpriceold * 50 / 100);
                                houseplantPriceText.text = " - " + houseplantPrice;
                                sellFurnitureImage[2].enabled = true;
                                sellFurnitureImage[2].sprite = sellSprite[4];
                                break;
                            case 6:
                                houseplantPrice = houseplantpriceold - (houseplantpriceold * 60 / 100);
                                houseplantPriceText.text = " - " + houseplantPrice;
                                sellFurnitureImage[2].enabled = true;
                                sellFurnitureImage[2].sprite = sellSprite[5];
                                break;
                        }
                    }
                    else
                    {
                        checkBuyFurniture[2].SetActive(true);
                        
                        
                    }
                    break;
                case "Fridge":
                    if(fridgebuy == false)
                    {
                        switch (random)
                        {
                            case 0:
                                fridgePrice = fridgepriceold;
                                fridgePriceText.text = " - " + fridgePrice;
                                sellFurnitureImage[3].enabled = false;
                                
                                break;
                            case 1:
                                fridgePrice = fridgepriceold - (fridgepriceold * 10 / 100);
                                fridgePriceText.text = " - " + fridgePrice;
                                sellFurnitureImage[3].enabled = true;
                                sellFurnitureImage[3].sprite = sellSprite[0];
                                break;
                            case 2:
                                fridgePrice = fridgepriceold - (fridgepriceold * 20 / 100);
                                fridgePriceText.text = " - " + fridgePrice;
                                sellFurnitureImage[3].enabled = true;
                                sellFurnitureImage[3].sprite = sellSprite[1];
                                break;
                            case 3:
                                fridgePrice = fridgepriceold - (fridgepriceold * 30 / 100);
                                fridgePriceText.text = " - " + fridgePrice;
                                sellFurnitureImage[3].enabled = true;
                                sellFurnitureImage[3].sprite = sellSprite[2];
                                break;
                            case 4:
                                fridgePrice = fridgepriceold - (fridgepriceold * 40 / 100);
                                fridgePriceText.text = " - " + fridgePrice;
                                sellFurnitureImage[3].enabled = true;
                                sellFurnitureImage[3].sprite = sellSprite[3];
                                break;
                            case 5:
                                fridgePrice = fridgepriceold - (fridgepriceold * 50 / 100);
                                fridgePriceText.text = " - " + fridgePrice;
                                sellFurnitureImage[3].enabled = true;
                                sellFurnitureImage[3].sprite = sellSprite[4];
                                break;
                            case 6:
                                fridgePrice = fridgepriceold - (fridgepriceold * 60 / 100);
                                fridgePriceText.text = " - " + fridgePrice;
                                sellFurnitureImage[3].enabled = true;
                                sellFurnitureImage[3].sprite = sellSprite[5];
                                break;
                        }
                    }
                    else
                    {
                        checkBuyFurniture[3].SetActive(true);
                    }
                    break;
                case "Television":
                    if(televisionbuy == false)
                    {
                        switch (random)
                        {
                            case 0:
                                televisionPrice = televisionpriceold;
                                televisionPriceText.text = " - " + televisionPrice;
                                sellFurnitureImage[4].enabled = false;
                                
                                break;
                            case 1:
                                televisionPrice = televisionpriceold - (televisionpriceold * 10 / 100);
                                televisionPriceText.text = " - " + televisionPrice;
                                sellFurnitureImage[4].enabled = true;
                                sellFurnitureImage[4].sprite = sellSprite[0];
                                break;
                            case 2:
                                televisionPrice = televisionpriceold - (televisionpriceold * 20 / 100);
                                televisionPriceText.text = " - " + televisionPrice;
                                sellFurnitureImage[4].enabled = true;
                                sellFurnitureImage[4].sprite = sellSprite[1];
                                break;
                            case 3:
                                televisionPrice = televisionpriceold - (televisionpriceold * 30 / 100);
                                televisionPriceText.text = " - " + televisionPrice;
                                sellFurnitureImage[4].enabled = true;
                                sellFurnitureImage[4].sprite = sellSprite[2];
                                break;
                            case 4:
                                televisionPrice = televisionpriceold - (televisionpriceold * 40 / 100);
                                televisionPriceText.text = " - " + televisionPrice;
                                sellFurnitureImage[4].enabled = true;
                                sellFurnitureImage[4].sprite = sellSprite[3];
                                break;
                            case 5:
                                televisionPrice = televisionpriceold - (televisionpriceold * 50 / 100);
                                televisionPriceText.text = " - " + televisionPrice;
                                sellFurnitureImage[4].enabled = true;
                                sellFurnitureImage[4].sprite = sellSprite[4];
                                break;
                            case 6:
                                televisionPrice = televisionpriceold - (televisionpriceold * 60 / 100);
                                televisionPriceText.text = " - " + televisionPrice;
                                sellFurnitureImage[4].enabled = true;
                                sellFurnitureImage[4].sprite = sellSprite[5];
                                break;
                        }
                    }
                    else
                    {
                        checkBuyFurniture[4].SetActive(true);
                    }
                    break;
                case "VideoGame":
                    if(videogamebuy == false)
                    {
                        switch (random)
                        {
                            case 0:
                                videogamePrice = videogamepriceold;
                                videogamePriceText.text = " - " + videogamePrice;
                                sellFurnitureImage[5].enabled = false;
                                
                                break;
                            case 1:
                                videogamePrice = videogamepriceold - (videogamepriceold * 10 / 100);
                                videogamePriceText.text = " - " + videogamePrice;
                                sellFurnitureImage[5].enabled = true;
                                sellFurnitureImage[5].sprite = sellSprite[0];
                                break;
                            case 2:
                                videogamePrice = videogamepriceold - (videogamepriceold * 20 / 100);
                                videogamePriceText.text = " - " + videogamePrice;
                                sellFurnitureImage[5].enabled = true;
                                sellFurnitureImage[5].sprite = sellSprite[1];
                                break;
                            case 3:
                                videogamePrice = videogamepriceold - (videogamepriceold * 30 / 100);
                                videogamePriceText.text = " - " + videogamePrice;
                                sellFurnitureImage[5].enabled = true;
                                sellFurnitureImage[5].sprite = sellSprite[2];
                                break;
                            case 4:
                                videogamePrice = videogamepriceold - (videogamepriceold * 40 / 100);
                                videogamePriceText.text = " - " + videogamePrice;
                                sellFurnitureImage[5].enabled = true;
                                sellFurnitureImage[5].sprite = sellSprite[3];
                                break;
                            case 5:
                                videogamePrice = videogamepriceold - (videogamepriceold * 50 / 100);
                                videogamePriceText.text = " - " + videogamePrice;
                                sellFurnitureImage[5].enabled = true;
                                sellFurnitureImage[5].sprite = sellSprite[4];
                                break;
                            case 6:
                                videogamePrice = videogamepriceold - (videogamepriceold * 60 / 100);
                                videogamePriceText.text = " - " + videogamePrice;
                                sellFurnitureImage[5].enabled = true;
                                sellFurnitureImage[5].sprite = sellSprite[5];
                                break;
                        }
                    }
                    else
                    {
                        checkBuyFurniture[5].SetActive(true);
                    }
                    break;

            }
        }
    }

    public void UnBlockBuy()
    {
        if(status.money >= sofaPrice)
        {
            checkMoney[0].SetActive(false);
        }
        if (status.money >= tablePrice)
        {
            checkMoney[1].SetActive(false);
        }
        if (status.money >= houseplantPrice)
        {
            checkMoney[2].SetActive(false);
        }
        if (status.money >= fridgePrice)
        {
            checkMoney[3].SetActive(false);
        }
        if (status.money >= televisionPrice)
        {
            checkMoney[4].SetActive(false);
        }
        if (status.money >= videogamePrice)
        {
            checkMoney[5].SetActive(false);
        }
    }

}
