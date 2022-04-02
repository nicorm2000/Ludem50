using UnityEngine;

public class ChangeFloor : MonoBehaviour
{
    [SerializeField] private GameObject floor1;
    [SerializeField] private GameObject floor2;

    private bool collide = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collide)
        {
            if (collision.CompareTag("Stairs") && floor1.activeSelf)
            {
                floor1.SetActive(false);
                floor2.SetActive(true);

                collide = true;
            }
            else if (collision.CompareTag("Stairs") && floor2.activeSelf)
            {
                floor1.SetActive(true);
                floor2.SetActive(false);

                collide = true;
            }
        }
        else
        {
            collide = false;
        }
    }
}
