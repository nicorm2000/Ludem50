using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactible : MonoBehaviour
{
    bool isDestroyable = false;
    // Start is called before the first frame update
    void Start()
    {

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
        isDestroyable = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isDestroyable = false;
    }
}
