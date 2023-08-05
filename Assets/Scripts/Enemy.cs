using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class a : MonoBehaviour
{
    public int Damage = 3;
    public float DamageTimeOut = 2;

    private float _damageTime;

    public int StartHp = 10;
    public int NowHp;

    public Image HP;

    private NavMeshAgent agent;
    private HeroHp player;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        player = FindObjectOfType<HeroHp>();
    }

    private void Start()
    {
        NowHp = StartHp;
    }

    private void Update()
    {
        agent.SetDestination(player.transform.position);

        if (Time.time - _damageTime >= DamageTimeOut)
        {
            if (Vector3.Distance(transform.position, player.transform.position) <= agent.stoppingDistance)
            {
                player.SetDamage(Damage);
                _damageTime = Time.time;
            }
        }

    }

    public void SetDamage(int damage)
    {
        NowHp -= damage;

        if(NowHp <= 0)
        {
            Destroy(gameObject);
        }

        HP.fillAmount = Mathf.Clamp01((float)NowHp / StartHp);
    }
}
