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
    Button but4;

    public information infoPrefab;

    void OnEnable()
    {
        var uiDocument = GetComponent<UIDocument>();
        but1 = uiDocument.rootVisualElement.Q<Button>("but1");
        but1.RegisterCallback<ClickEvent>(ClickMessage1);
        but2 = uiDocument.rootVisualElement.Q<Button>("but2");
        but2.RegisterCallback<ClickEvent>(ClickMessage2);
        but3 = uiDocument.rootVisualElement.Q<Button>("but3");
        but3.RegisterCallback<ClickEvent>(ClickMessage3);
        but4 = uiDocument.rootVisualElement.Q<Button>("but4");
        but4.RegisterCallback<ClickEvent>(ClickMessage4);
    }

    void ClickMessage1(ClickEvent e)
    {
        Debug.Log("start");
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
        UnityEngine.Cursor.visible = false;
    }

    void ClickMessage2(ClickEvent e)
    {
        Debug.Log("cont");
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            Destroy(gameObject);
            Time.timeScale = 1f;
            UnityEngine.Cursor.lockState = CursorLockMode.Locked;
            UnityEngine.Cursor.visible = false;
        }
    }

    void ClickMessage3(ClickEvent e)
    {
        Debug.Log("info");
        Instantiate(infoPrefab);
        Destroy(gameObject);
    }

    void ClickMessage4(ClickEvent e)
    {
        Debug.Log("quit");
        Application.Quit();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (SceneManager.GetActiveScene().buildIndex != 0)
            {
                Destroy(gameObject);
            }
        }
    }
/*    public void Unshow()
    {
        DestroyImmediate(gameObject);
    }*/
}
