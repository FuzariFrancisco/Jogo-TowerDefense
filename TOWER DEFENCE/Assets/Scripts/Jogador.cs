using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    [SerializeField] private int vida;
    int bonus;

    public int GetVida()
    {
        return vida;
    }

    public void PerdeVida()
    {
        vida--;
    }

    public int Bonus()
    {
        return bonus;
    }

    public void BonusUp()
    {
        bonus++;
    }

    private void Update()
    {
        if (bonus >= 3)
        {
            bonus = 0;
            vida++;
        }
    }
}
