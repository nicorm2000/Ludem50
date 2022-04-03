using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject[] monsters;
    [SerializeField] private AudioClip[] audioClip;
    [SerializeField] private AudioSource audioS;
    [SerializeField] private float velocity;
    [SerializeField] private float rotationSpeed;
    private float horizontal;
    private float vertical;
    private Rigidbody2D rb;
    private float monsterdistance;


    void Start()
    {

    }

    void Update()
    {
        PlayerMovement();
        transform.position += new Vector3(horizontal, vertical, 0) * Time.deltaTime * velocity;
        PlayerRotation();
        MonsterActivate();
        MonsterDeactivate();
        //if (Input.GetAxisRaw("Vertical") != 0)
        //{
        //    audioS.clip = audioClip[Random.Range(0, 3)];
        //    audioS.Play();

        //}
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


    void MonsterActivate()
    {
        for (int i = 0; i < 1; i++)
        {
            monsterdistance = Vector3.Distance(transform.position, monsters[i].transform.position);
            if (monsterdistance > 7f)
            {
                monsters[i].SetActive(true);
            }
        }
    }

    void MonsterDeactivate()
    {
        for (int i = 0; i < 1; i++)
        {
            monsterdistance = Vector3.Distance(transform.position, monsters[i].transform.position);
            if (monsterdistance < 7f)
            {
                monsters[i].SetActive(false);
            }
        }
    }
}