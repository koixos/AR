using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    [SerializeField]
    private float walkSpeed = 10f;
    [SerializeField]
    private float runSpeed = 20f;
    [SerializeField]
    private float runThreshold = 1f;

    private FixedJoystick fixedJoystick;
    private Rigidbody rb;
    private Animator animator;

    private void OnEnable()
    {
        fixedJoystick = FindObjectOfType<FixedJoystick>();
        rb = gameObject.GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        float xVal = fixedJoystick.Horizontal;
        float yVal = fixedJoystick.Vertical;

        float joystickMagnitude = new Vector2(xVal, yVal).magnitude;

        float currSpeed = joystickMagnitude > runThreshold ? runSpeed : walkSpeed;

        Vector3 movement = new Vector3(xVal, 0, yVal);

        rb.velocity = movement * currSpeed;

        animator.SetFloat("Speed", rb.velocity.magnitude);

        if (xVal != 0 && yVal != 0)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(xVal, yVal) * Mathf.Rad2Deg, transform.eulerAngles.z);
        }
    }
}
