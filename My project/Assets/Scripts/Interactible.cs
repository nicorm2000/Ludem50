using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Interactible : MonoBehaviour
{
    bool isDestroyable = false;

    [SerializeField] private TextMeshProUGUI textPick;

    // Start is called before the first frame update
    void Start()
    {
        textPick.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isDestroyable && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            textPick.gameObject.SetActive(true);
        }

        isDestroyable = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            textPick.gameObject.SetActive(false);
        }

        isDestroyable = false;
    }
}
