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
    [SerializeField] private Light candle;
    [SerializeField] private float attenuationSpeed;
    private int candleTime;
    [SerializeField] private GameObject candleBar;

    void Start()
    {
        textPick.gameObject.SetActive(false);
        gameObject.SetActive(false);
        GetRandomFuel();
    }

    // Update is called once per frame
    void Update()
    {
        if (deactivate && Input.GetKeyDown(KeyCode.E))
        {
            gameObject.SetActive(false);
            GetRandomFuel();
            candle.intensity = 1;
        }

        candle.intensity -= attenuationSpeed * Time.deltaTime;
        candleTime = (int) (candle.intensity * 120);
        candleBar.transform.position = new Vector3((7.5f)*(candleTime) - 450, 560, 0);

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

    private void GetRandomFuel()
    {
        int rand = Random.Range(0, 4);

        for (int i = 0; i < 4; i++)
        {
            if (i == rand)
            {
                fuel[i].SetActive(true);
            }
            else
            {
                fuel[i].SetActive(false);
            }
        }

    }
}
