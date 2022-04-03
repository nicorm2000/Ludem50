using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelController : MonoBehaviour
{
    private int random;
    [SerializeField] private GameObject[] fuel;

    // Update is called once per frame
    void Update()
    {
        int i = 0;
        while(fuel[i].gameObject.activeSelf == false && i < 6)
        {
            print("Hay");
            i++;
        }

        if (i >= 6)
        {
            print("No hay");

            random = Random.Range(0, 6);
            fuel[random].gameObject.SetActive(true);
        }
    }
}
