﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI TXTMoney;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void UpdateMoneyTxt(string moneyAmount)
     {
        TXTMoney.text = moneyAmount;

     }
}
