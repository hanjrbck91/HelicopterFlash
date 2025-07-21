using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float liftForce = 8f;
    public float tapForce = 2f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Input for both mouse and touch
        bool isPressing = Input.GetMouseButton(0) || Input.touchCount > 0;
        bool isTap = Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began);

        if (isTap)
        {
            rb.linearVelocity = new Vector2(0, tapForce);
        }
        else if (isPressing)
        {
            rb.linearVelocity = new Vector2(0, liftForce);
        }
    }
}
