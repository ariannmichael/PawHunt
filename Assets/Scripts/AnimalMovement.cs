using UnityEngine;
using Random = UnityEngine.Random;

public class AnimalMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float startY;
    [SerializeField] private float offset;
    private float finalPosition;
    [SerializeField] private int direction = 1;
    private bool clicked = false;
    [SerializeField] private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startY = transform.position.y;
        finalPosition = startY + offset;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        if (!clicked && rb.position.y < finalPosition)
        {
            Vector2 position = transform.position;
            position.y += Time.deltaTime * direction;
            transform.position = position;
        }

        if (clicked && rb.position.y > startY) {
            Vector2 position = transform.position;
            position.y -= Time.deltaTime * direction;
            transform.position = position;
        } 
        else if (rb.position.y == startY)
        {
            GameManager.instance.HideAnimal();
            clicked = false;
        }
    }

    public void HandleClick()
    {
        animator.Play("Animal");
        int randomIndex = Random.Range(0, AudioManager.instance.meows.Length);
        AudioManager.instance.PlaySFX(AudioManager.instance.meows[randomIndex]);
        clicked = true;
    }
}
