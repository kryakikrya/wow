using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelButtonView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI levelIDLabel;
    [SerializeField] private List<GameObject> stars; 
    void Start()
    {
        
    }


    void Update()
    {
        
    }
    public void SetupLevelButton(int  levelID, int StarsCount)
    {
        levelIDLabel.text = $"{levelID}";
        SetupStars(StarsCount);
    }
    private void SetupStars(int StarsCount) 
    {
        for (int i = 0; i < StarsCount; i++)
        {
            stars[i].SetActive(i < StarsCount);
        }
    }
}
