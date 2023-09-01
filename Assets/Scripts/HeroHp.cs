using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using TMPro;

public class HeroHp : MonoBehaviour
{
    [Range(1, 10)]
    public int StartHp = 10;
    public int NowHp;

    public looser looserPrefab;

    public Image HP;
    public TextMeshProUGUI countHPtxt;

    public void Start()
    {
        NowHp = StartHp;
        countHPtxt.text = NowHp + "/" + StartHp;
        HP.color = Color.green;
    }
    public void SetDamage(int Damage)
    {
        NowHp -= Damage;
        countHPtxt.text = NowHp + "/" + StartHp;

        if (NowHp <= 0)
        {
            Debug.Log("Dead");
            //Destroy(gameObject);
            Time.timeScale = 0f;
            Instantiate(looserPrefab);
        }

        HP.fillAmount = Mathf.Clamp01((float)NowHp / StartHp);
        if (Mathf.Clamp01((float)NowHp / StartHp) < 0.3f)
        {
            HP.color = Color.red;
        }
    }
    public void Healing(int countHp)
    {
        NowHp += countHp;
        NowHp = Mathf.Clamp(NowHp, 0, StartHp);
        countHPtxt.text = NowHp + "/" + StartHp;
        HP.fillAmount = Mathf.Clamp01((float)NowHp / StartHp);
    }
}
