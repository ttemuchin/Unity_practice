using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    Button but1;
    Button but2;
    Button but3;

    void OnEnable()
    {
        var uiDocument = GetComponent<UIDocument>();
        but1 = uiDocument.rootVisualElement.Q<Button>("but1");
        but1.RegisterCallback<ClickEvent>(ClickMessage1);
        but2 = uiDocument.rootVisualElement.Q<Button>("but2");
        but2.RegisterCallback<ClickEvent>(ClickMessage2);
        but3 = uiDocument.rootVisualElement.Q<Button>("but3");
        but3.RegisterCallback<ClickEvent>(ClickMessage3);
    }

    // Update is called once per frame
    void ClickMessage1(ClickEvent e)
    {
        Debug.Log("start");
        SceneManager.LoadScene(1);
    }

    void ClickMessage2(ClickEvent e)
    {
        Debug.Log("cont");
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            Destroy(gameObject);
        }
    }

    void ClickMessage3(ClickEvent e)
    {
        Debug.Log("info");
    }
}
