using UnityEngine;

public class AnimalMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float startY;
    [SerializeField] private float offset;
    private float finalPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startY = transform.position.y;
        finalPosition = startY + offset;
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.position.y < finalPosition)
        {
            Vector2 position = transform.position;
            position.x -= Time.deltaTime;
            transform.position = position;
        }
    }
}
