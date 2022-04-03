using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Fuel : MonoBehaviour
{
    // Variable declaration
    private bool deactivate;
    [SerializeField] private GameObject[] fuel;
    [SerializeField] private TextMeshProUGUI textPick;

    void Start()
    {
        textPick.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (deactivate && Input.GetKeyDown(KeyCode.E))
        {
            gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            textPick.gameObject.SetActive(true);
        }

        deactivate = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            textPick.gameObject.SetActive(false);
        }

        deactivate = false;
    }
}
