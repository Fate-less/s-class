using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball_S : MonoBehaviour
{
    public float fireballSpeed;
    public float damage;
    public float graceDuration;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        graceDuration -= Time.deltaTime;
        if(graceDuration <= 0)
        {
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        rb.velocity = Vector3.forward * fireballSpeed;
    }

   void OnTriggerEnter(Collider other)
    {
        /* kalo musu kena
         * if(other.CompareTag("Enemy"){
         * other.GetComponent<IDamageable>().TakeDamage(damage);
         * Destroy(gameObject);
         * }
         * if(other.CompareTag("Wall){
         * Destroy(gameObject);
         * }
        */
    }
}
