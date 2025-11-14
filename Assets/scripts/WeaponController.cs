using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WeaponController : MonoBehaviour
{
    public Transform blade;          // Assign the blade (long rectangle) in Inspector
    public float rotationSpeed = 180f; // Degrees per second
    public bool clockwise;
    private int rotationDirection = -1; // -1 = clockwise, 1 = counter-clockwise

    private void Start()
    {
        if (clockwise)
        {
            rotationDirection = -1;
        }
        else
        {
            rotationDirection = 1;
        }
    }

    void Update()
    {
        if (blade != null)
        {
            blade.RotateAround(transform.position, Vector3.forward, rotationSpeed * rotationDirection * Time.deltaTime);
        }
    }

    public void hitBall(Transform ball)
    {
        // 不打自己
        if (ball == this.transform)
        {
            return;
        }

        // 触发慢动作
        SlowMotionManager.Instance.doSlowMotion();
    }

    public void hitWeapon()
    {
        rotationDirection *= -1;
    }


}
