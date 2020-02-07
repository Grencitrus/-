using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveMoney : MonoBehaviour
{
    public static float myMoney;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CostumerMoney()
    {
        float tempMoney;
        tempMoney = 25 + (75 * 0.01f);

        myMoney += tempMoney;

    }

}
