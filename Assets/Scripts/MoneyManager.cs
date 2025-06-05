using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float money;
    public UIManager uiManager;

    void Start()
    {
        uiManager.UpdateMoneyTxt(money.ToString());
    }

    public void UpdateMoney(float moneyToAdd)
    {
        if (money + moneyToAdd < 0)
        {
            Debug.Log("No te alcanza");
            return;
        }
        money += moneyToAdd;
    }
}
