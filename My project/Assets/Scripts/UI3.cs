using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI3 : MonoBehaviour
{
    

    [SerializeField] private GameObject _prefabsLevels;
    [SerializeField] private RectTransform root;
    [SerializeField] private int _minStarsCount;
    [SerializeField] private int _maxStarsCount;
    [SerializeField] private int levelCount;

    void Start()
    {
        FillLevelmenu();
    }

    void Update()
    {
        
    }
    private void FillLevelmenu()
    {
        for (int i = 0; i < levelCount; i++)
        {
            GameObject levelButton = Instantiate(_prefabsLevels, root);
            if(levelButton.TryGetComponent(out LevelButtonView levelButtonView))
            {
                levelButtonView.SetupLevelButton(i + 1, Random.Range(_minStarsCount, _maxStarsCount));
            }

        }
    }
    private void ClearLevelMenu()
    {
        for(int i = 0;i < levelCount; i++)
        {
            Destroy(root.GetChild(i).gameObject);
        }
    }
    
}
