using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeInimigo : MonoBehaviour
{
    [SerializeField] private GameObject inimigo;

    private float momentoDaUltimaGeracao;

    [Range(0, 3)]

    [SerializeField] private float tempoDeCriacao = 2f;

    private void GeraInimigo()
    {
        float tempoAtual = Time.time;
        if (tempoAtual > momentoDaUltimaGeracao + tempoDeCriacao)
        {
            momentoDaUltimaGeracao = tempoAtual;
            Vector3 posicaDoGerador = this.transform.position;
            Instantiate(inimigo, posicaDoGerador, Quaternion.identity);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GeraInimigo();
    }
}
