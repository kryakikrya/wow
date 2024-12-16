using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffPanel : MonoBehaviour
{
    [SerializeField] private GameObject _PanelSwtch;
    [SerializeField] private GameObject _PanelExitMenu;
    [SerializeField] private GameObject _buttonExit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play()
    {
        _PanelSwtch.SetActive(false);
        _PanelExitMenu.SetActive(true);
        _buttonExit.SetActive(true);
    }
    public void ExitMenu()
    {
        _PanelSwtch.SetActive(true);
        _PanelExitMenu.SetActive(false);
        _buttonExit.SetActive(false);
    }
}
