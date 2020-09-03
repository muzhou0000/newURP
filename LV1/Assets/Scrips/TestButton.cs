using UnityEngine;
using UnityEngine.UI;
public class TestButton : MonoBehaviour
{
    Button[] Buttons;
    public Animator ani1, ani2, ani3, ani4;
    public GameObject Text;
    void Start()
    {
        Buttons = FindObjectsOfType<Button>();
        foreach (var item in Buttons)
        {
            item.onClick.AddListener(() => OnButtonClicked(item));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (ani1.GetBool("bC1") == true && ani2.GetBool("bC2") == true && ani3.GetBool("bC3") == true && ani4.GetBool("bC4") == true)
        {
            Text.SetActive(true);
            
        }
    }
    private void OnButtonClicked(Button item)
    {
        Debug.Log("你按下了：" + item.name);
        switch (item.name)
        {
            case "Button1":
                print("按下按鈕1");
                ani2.SetBool("bC2", !(ani2.GetBool("bC2")));
                ani3.SetBool("bC3", !(ani3.GetBool("bC3")));
                ani4.SetBool("bC4", !(ani4.GetBool("bC4")));
                break;
            case "Button2":
                print("按下按鈕2");
                ani1.SetBool("bC1", !(ani1.GetBool("bC1")));
                ani3.SetBool("bC3", !(ani3.GetBool("bC3")));
                ani4.SetBool("bC4", !(ani4.GetBool("bC4")));
                break;
            case "Button3":
                print("按下按鈕3");
                ani2.SetBool("bC2", !(ani2.GetBool("bC2")));
                ani1.SetBool("bC1", !(ani1.GetBool("bC1")));
                ani4.SetBool("bC4", !(ani4.GetBool("bC4")));
                break;
            case "Button4":
                print("按下按鈕4");
                ani2.SetBool("bC2", !(ani2.GetBool("bC2")));
                ani3.SetBool("bC3", !(ani3.GetBool("bC3")));
                ani1.SetBool("bC1", !(ani1.GetBool("bC1")));
                break;


        }
    }
}
