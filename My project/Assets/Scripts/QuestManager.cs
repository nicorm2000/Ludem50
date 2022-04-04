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

<<<<<<< HEAD
    public void StartQuest()
    {
        if (current >= 8 && !teddy[8].activeSelf)
        {
            Time.timeScale = 0f;
            goodEnding.SetActive(true);
        }

=======
    }

    public void StartQuest()
    {
        if (current > 7)
        {
            Time.timeScale = 0f;
            goodEnding.SetActive(true);
        }
>>>>>>> cd9ef27c0643c38719b508cea0fe45a0946bc8bd
        // Swap quests and toy appear
        if (current <= 8)
        {
            if (!teddy[current].activeSelf)
            {
                current++;
            }
            teddy[current].SetActive(true);
        }
<<<<<<< HEAD

=======
>>>>>>> cd9ef27c0643c38719b508cea0fe45a0946bc8bd
        // Print quest completed true or false
        for (int i = 0; i < current; i++)
        {
            questTexts[i].gameObject.SetActive(false);
            questCompleted[i].gameObject.SetActive(true);
        }
        teddy[current].SetActive(true);
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