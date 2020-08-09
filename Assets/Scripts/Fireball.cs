using UnityEngine;

public class Fireball : MonoBehaviour
{
    public GameObject houseHitEffect;
    public Rigidbody2D rb;
    public float speed = 6f;

    void OnCollisionEnter2D(Collision2D  col)
    {
        if(col.collider.tag == "shield")
        {
            Destroy(gameObject);
        }

        if(col.collider.tag == "house")
        {
            HouseHitParticleEffect();
        }
    }

    void Update()
    {
        float x = Time.fixedDeltaTime * speed;

        Vector2 newPosition = rb.position + Vector2.right * x;

        rb.MovePosition(newPosition);
    }

    void HouseHitParticleEffect()
    {
        Instantiate(houseHitEffect, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }
}
