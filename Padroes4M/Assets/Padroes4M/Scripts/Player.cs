using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Action<float> OnCoinsValueChanged;
    
    // permite que o criador do conteudo do valor do slider manda
    // os dados

    public static void ChangedVolumesSliderValue(int coins)
    {
        // tem algum inscrito? se tiver mande as notificções
        OnCoinsValueChanged?.Invoke(coins);
}
