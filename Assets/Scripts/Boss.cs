using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    public winWindow winPrefab;
    public Image HP;

    private void Update()
    {
        if (HP.fillAmount <= 0)
        {
            Instantiate(winPrefab);
        }
    }
}