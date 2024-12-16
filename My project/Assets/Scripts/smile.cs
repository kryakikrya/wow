
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Smile : MonoBehaviour
{
    [SerializeField] private int CircleCount; 
    public TextMeshProUGUI count;
    [SerializeField] private string message;
    [SerializeField] private TextMeshPro messageText;
    [SerializeField] private float timer;
    public Image clock;
    private bool IsTimerOn;
    [SerializeField] private float startTimer;
    [SerializeField] TextMeshProUGUI textMeshPro;
    void Start()
    {
        messageText.text = $"message from inspector {message}";
    }
    public void Decode()
    {
       textMeshPro.text = textMeshPro.text.Replace('$', 'a');  
    }
    public void Correct()
    {
        textMeshPro.text = textMeshPro.text.Replace('%', '\n');
    }
    public void Peel()
    {
        int i = textMeshPro.text.Length - 1;
        while (textMeshPro.text[i] != '.')
        {
            print(i);
            textMeshPro.text = textMeshPro.text.Remove(i);
            i--;
           
        }
            
    }
    public void Encrypt()
    {
        textMeshPro.text = string.Concat(textMeshPro.text.Select(c => $@"\u{(int)c:x4}"));
        textMeshPro.text = textMeshPro.text.Replace('0', '#');
    }
    private void Update()
    {
        Timer();
        count.text = CircleCount.ToString();
        
    }
    public void Timer()
    {
        clock.fillAmount = timer / startTimer;
        if (IsTimerOn && timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else if(timer <= 0)
        {
            IsTimerOn = false;
            timer = startTimer;
        }

    }
   
    public void Click()
    {
        IsTimerOn = true;
        CircleCount++;
    }
}
