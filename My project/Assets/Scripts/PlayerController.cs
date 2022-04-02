using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float velocity;
    [SerializeField] private float rotationSpeed;
    private float horizontal;
    private float vertical;
    [SerializeField] private Light candle;
    [SerializeField] private float attenuationSpeed;
    private int candleTime;
    private Rigidbody2D rb;


    void Start()
    {

    }

    void Update()
    {
        PlayerMovement();
        transform.position += new Vector3(horizontal, vertical, 0) * Time.deltaTime * velocity;
        PlayerRotation();

        candle.intensity -= attenuationSpeed * Time.deltaTime;
        candleTime = (int) (candle.intensity * 120);
        print(candleTime);
    }

    void PlayerMovement()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    void PlayerRotation()
    {
        Vector2 movementDirection = new Vector2(horizontal, vertical);
        if (movementDirection != Vector2.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movementDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
