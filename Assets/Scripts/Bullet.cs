using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Rigidbody2D rb;

    [Header("Atributtes")]
    [SerializeField] private float velocidadeBala = 5f;
    [SerializeField] private int danoBala = 1;

    private Transform target;
    public void SetTarget(Transform _target) {
        target = _target;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (!target) return;
        Vector2 direction = (target.position - transform.position).normalized;
        rb.velocity = direction * velocidadeBala;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        // Diminui a vida do inimigo
        other.gameObject.GetComponent<Saude>().recebeDano(danoBala);
        Destroy(gameObject);
    }
}
