using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;
    private Joystick joystick;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void SetJoystick(Joystick j)
    {
        joystick = j;
    }

    void FixedUpdate()
    {
        float h, v;

        if (joystick != null)
        {
            h = joystick.Horizontal;
            v = joystick.Vertical;
        }
        else
        {
            h = Input.GetAxisRaw("Horizontal"); // A/D
            v = Input.GetAxisRaw("Vertical");   // W/S
        }

        Vector3 move = new Vector3(h, 0f, v).normalized * speed;
        rb.MovePosition(rb.position + move * Time.fixedDeltaTime);
    }
}
