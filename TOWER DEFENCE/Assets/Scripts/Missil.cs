using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missil : MonoBehaviour
{
    private float velocidade = 3f;
    public Inimigo alvo;
    [SerializeField] private int pontosDeDano;

    // Update is called once per frame
    void Update()
    {
        Anda();
        AlteraDirecao();
    }

    private void Start()
    {
        AutoDestroiDeposDeSegundos(5f);
    }

    public void DefineAlvo(Inimigo inimigo)
    {
        alvo = inimigo;
    }

    private void AlteraDirecao()
    {
        Vector3 posicaoAtual = transform.position;
        Vector3 posicaoDoAlvo = alvo.transform.position;
        Vector3 direcaoDoAlvo = posicaoDoAlvo - posicaoAtual;
        transform.rotation = Quaternion.LookRotation(direcaoDoAlvo);
    }

    private void Anda()
    {
        Vector3 posicaoAtual = transform.position;
        Vector3 deslocamento = transform.forward * Time.deltaTime *velocidade;
        transform.position = posicaoAtual + deslocamento;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Inimigo"))
        {
            Destroy(this.gameObject);
            //Destroy(other.gameObject);
            Inimigo inimigo = other.GetComponent<Inimigo>();
            inimigo.RecebeDano(pontosDeDano);
        }
        
    }

    private void AutoDestroiDeposDeSegundos(float segundos)
    {
        Destroy(this.gameObject, segundos);

    }
}
