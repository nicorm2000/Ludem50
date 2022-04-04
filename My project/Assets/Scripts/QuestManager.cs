using UnityEngine;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{
    [SerializeField] private GameObject[] teddy;

    [SerializeField] private GameObject quest;

    [SerializeField] private bool questMenuOpen = false;

    [SerializeField] private Image[] questTexts;
    [SerializeField] private Image[] questCompleted;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (!questMenuOpen)
            {
                quest.SetActive(true);
                questMenuOpen = true;
            }
            else
            {
                quest.SetActive(false);
                questMenuOpen = false;
            }
        }

        StartQuest();
    }

    public void StartQuest()
    {
        for (int i = 0; i < questTexts.Length; i++)
        {
            if (questTexts[i].gameObject.activeInHierarchy)
            {
                if (!teddy[i].gameObject.activeInHierarchy)
                {
                    teddy[i + 1].SetActive(true);

                    questTexts[i].gameObject.SetActive(false);
                    questCompleted[i].gameObject.SetActive(true);
                }
            }

            if (questCompleted[i].gameObject.activeInHierarchy && Input.GetKeyDown(KeyCode.P))
            {
                questCompleted[i].gameObject.SetActive(false);
                questTexts[i + 1].gameObject.SetActive(true);
            }
        }
    }
}