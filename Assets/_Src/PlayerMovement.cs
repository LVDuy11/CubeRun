using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    protected Rigidbody rb;
    protected float forwardForce = 2000f;
    protected float sidewaysForce = 80f;

    private void Awake()
    {
        this.rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame

    private void FixedUpdate()
    {
        this.Movement();
    }

    protected virtual void Movement()
    {
        this.rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("a"))
        {
            this.rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d"))
        {
            this.rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
