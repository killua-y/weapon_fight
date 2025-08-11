using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBehavior : MonoBehaviour
{
    private WeaponController ownerWeaponCtrl;

    private void Awake()
    {
        ownerWeaponCtrl = this.gameObject.transform.parent.GetComponent<WeaponController>();
        if (ownerWeaponCtrl == null)
        {
            Debug.Log("cannot find Weapon Controller");
        }    
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // 武器击中球
        if (other.CompareTag("Ball"))
        {
            ownerWeaponCtrl.hitBall(other.transform);
            return;
        }

        // 武器击中武器
        if (other.CompareTag("Weapon"))
        {
            ownerWeaponCtrl.hitWeapon();
        }
    }
}
