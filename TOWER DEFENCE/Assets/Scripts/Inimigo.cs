﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Inimigo : MonoBehaviour
{
    [SerializeField] private int vida;
    Jogador jogador;


    void Start()
    {
        NavMeshAgent agente = GetComponent<NavMeshAgent>();
        GameObject FimDoCaminho = GameObject.Find("FimDoCaminho");
        Vector3 posicaoFimDoCaminho = FimDoCaminho.transform.position;
        agente.SetDestination(posicaoFimDoCaminho);
        jogador = GameObject.FindObjectOfType(typeof(Jogador)) as Jogador;
    }

    public void RecebeDano(int pontosDeDano)
    {
        vida -= pontosDeDano;
        if(vida <+0)
        {
            
            Destroy(this.gameObject);
            jogador.BonusUp();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
