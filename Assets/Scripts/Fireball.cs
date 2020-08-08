using UnityEngine;

public class Fireball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 6f;

    void OnCollisionEnter2D(Collision2D  col)
    {
        if(col.collider.tag == "shield")
        {
            Debug.Log("shield");
        }

        if(col.collider.tag == "house")
        {
            Destroy(gameObject);
        }
    }


    void Update()
    {
        float x = Time.fixedDeltaTime * speed;

        Vector2 newPosition = rb.position + Vector2.right * x;

        rb.MovePosition(newPosition);
    }
}
