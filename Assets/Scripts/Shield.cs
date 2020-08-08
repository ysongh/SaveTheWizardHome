using UnityEngine;

public class Shield : MonoBehaviour
{
    public float speed = 15f;
    public float mapHeight = 5f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Move the shield
    void FixedUpdate()
    {
        float y = Input.GetAxis("Vertical") * Time.fixedDeltaTime * speed;

        Vector2 newPosition = rb.position + Vector2.up * y;
        newPosition.y = Mathf.Clamp(newPosition.y, -mapHeight, mapHeight);

        rb.MovePosition(newPosition);
    }
}