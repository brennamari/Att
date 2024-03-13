using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsController : MonoBehaviour
{
    [SerializeField] public int Coins = 0;
    public static Action<int> CoinsChanged;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Coins++;
            Debug.Log("Numero de moedas" + Coins);
            CoinsChanged?.Invoke(Coins);
        }
    }

    private void ChangedCoins(float coinsValue)
    {
    }
        
    
}
