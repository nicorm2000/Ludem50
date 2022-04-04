using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject[] monsters;
    [SerializeField] private GameObject[] eyes;
    [SerializeField] private AudioClip[] audioClip;
    [SerializeField] private AudioSource audioS;
    [SerializeField] private float velocity;
    [SerializeField] private float rotationSpeed;
    private float horizontal;
    private float vertical;
    private Rigidbody2D rb;
    private float monsterdistance;
    private float eyesdistance;
    [SerializeField] private SpriteRenderer[] monsColor;
    private Color alphaMod;
    [SerializeField] private Animator Anim;


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

        // Set Animations
        if (Input.GetKeyDown(KeyCode.D))
        {
            Anim.SetInteger("Anim", 2);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            Anim.SetInteger("Anim", -2);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            Anim.SetInteger("Anim", 1);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Anim.SetInteger("Anim", -1);
        }

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
        //Vector2 movementDirection = new Vector2(horizontal, vertical);
        //if (movementDirection != Vector2.zero)
        //{
        //    Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movementDirection);
        //    transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        //}
    }


    void MonsterActivate()
    {
        for (int i = 0; i < 6; i++)
        {
            monsterdistance = Vector3.Distance(transform.position, monsters[i].transform.position);

            alphaMod = monsColor[i].color;
            alphaMod.a = 0.28f * monsterdistance - 1.3f;

            monsColor[i].color = alphaMod;

            eyesdistance = Vector3.Distance(transform.position, eyes[i].transform.position);
            if (eyesdistance > 5f)
            {
                eyes[i].SetActive(false);
            }
        }
    }

    void MonsterDeactivate()
    {
        for (int i = 0; i < 6; i++)
        {
            //monsterdistance = Vector3.Distance(transform.position, monsters[i].transform.position);
            //if (monsterdistance < 5f)
            //{
            //    monsters[i].SetActive(false);
            //}
        
            eyesdistance = Vector3.Distance(transform.position, eyes[i].transform.position);
            if (eyesdistance < 5f)
            {
                eyes[i].SetActive(true);
            }
        }
    }
}