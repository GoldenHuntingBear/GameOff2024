using System;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    private float health = 1;
    public Action Dead;
    public void TakeDamage(float damage)
    {
        Debug.Log("Dead");
        health -= damage;
        Dead.Invoke();
    }
}
