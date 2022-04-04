using UnityEngine;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{
    [SerializeField] private GameObject goodEnding;
    [SerializeField] private GameObject[] teddy;

    [SerializeField] private GameObject quest;
    [SerializeField] private GameObject[] page;
    private int pagesMan = 0;
    [SerializeField] private int current = 0;

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
        if (current >= 8 && !teddy[8].activeSelf)
        {
            Time.timeScale = 0f;
            goodEnding.SetActive(true);
        }

        // Swap quests and toy appear
        if (current <= 8)
        {
            if (!teddy[current].activeSelf)
            {
                current++;
            }
            teddy[current].SetActive(true);
        }

        // Print quest completed true or false
        for (int i = 0; i < current; i++)
        {
            questTexts[i].gameObject.SetActive(false);
            questCompleted[i].gameObject.SetActive(true);
        }
    }

    public void PageIncrease()
    {
        page[pagesMan].gameObject.SetActive(false);

        if (pagesMan < 2)
        {
            pagesMan++;
        }
        else { pagesMan = 0; }
        page[pagesMan].gameObject.SetActive(true);
    }
}