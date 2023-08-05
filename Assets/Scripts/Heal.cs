using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    public int countAddHp = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<HeroHp>(out HeroHp hp))
        {
            if (hp.NowHp == hp.StartHp)
            {
                return;
            }
            hp.Healing(countAddHp);
            Destroy(transform.parent.gameObject);
        }
    }
}
