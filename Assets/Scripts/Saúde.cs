using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saude : MonoBehaviour
{
    [Header("References")]
    /*[SerializeField] private Transform turretRotationPoint;*/

    [Header("Attribute")]
    [SerializeField] private int pontosDano = 2;

    public void recebeDano(int dano)
    {
        pontosDano -= dano;
        if (pontosDano <= 0) {
            SpawnDeInimigos.quandoInimigoMorrer.Invoke();
            Destroy(gameObject);
        }

    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
