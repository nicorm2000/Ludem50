using UnityEngine;

public class ChangeFloor : MonoBehaviour
{
    [SerializeField] private GameObject floor1;
    [SerializeField] private GameObject floor2;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Stairs") && Input.GetAxis("Horizontal") < 0)
        {
            floor1.SetActive(false);
            floor2.SetActive(true);
        }
        else if (collision.CompareTag("Stairs") && Input.GetAxis("Horizontal") > 0)
        {
            floor1.SetActive(true);
            floor2.SetActive(false);
        }
    }
}
