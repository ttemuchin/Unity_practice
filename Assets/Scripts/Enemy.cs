using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class a : MonoBehaviour
{
    public int Damage = 3;
    public float DamageTimeOut = 2;

    private float _damageTime;

    public int StartHp = 10;
    public int NowHp;

    public Image HP;
    public winWindow winPrefab;

    private NavMeshAgent agent;
    private HeroHp player;

   // public Camera cam;
    public ParticleSystem partsPrefab;
    public ParticleSystem bosspartsPrefab;

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
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                var quat = Quaternion.LookRotation(gameObject.transform.up);
                Instantiate(partsPrefab, transform.position, quat);
                Destroy(gameObject);
            }

            //Destroy(gameObject);
            if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                ////wait here
                ///NavMeshAgent.ResetPath
                agent.Stop();
                var quat = Quaternion.LookRotation(gameObject.transform.up);
                Instantiate(bosspartsPrefab, transform.position, quat);
                StartCoroutine(waiter());
                //Destroy(gameObject);
                /*Instantiate(winPrefab);*/
            }    

        }

        HP.fillAmount = Mathf.Clamp01((float)NowHp / StartHp);
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(4);
        //Debug.Log("waited");
        Destroy(gameObject);
        Instantiate(winPrefab);
        yield break;
    }

}
