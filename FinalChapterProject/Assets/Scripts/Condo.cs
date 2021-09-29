using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Condo : MonoBehaviour
{
    //Furniture in Condo
    public Image[] furnitureInCondo;


    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < furnitureInCondo.Length; i++)
        {
            furnitureInCondo[i].enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
