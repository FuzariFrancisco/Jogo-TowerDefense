using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorDeCruzamento : MonoBehaviour
{
    [SerializeField] private Jogador jogador;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Inimigo"))
        {
            //Debug.Log("foooi");
            Destroy(other.gameObject);
            jogador.PerdeVida();
        }
    }

}
