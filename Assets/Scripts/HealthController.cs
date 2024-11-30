using System;
using System.Collections;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public AudioSource deadSound;
    private float health = 1;
    public Action Dead;
    private Rigidbody2D _rigidbody;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    public void TakeDamage(float damage)
    {
        Debug.Log("Dead");
        health -= damage;
        _rigidbody.constraints = RigidbodyConstraints2D.FreezeAll;
        deadSound.Play();
        StartCoroutine(waitForSound(deadSound));
    }

    IEnumerator waitForSound(AudioSource source)
    {
        //Wait Until Sound has finished playing
        while (source.isPlaying)
        {
            yield return null;
        }

        Dead.Invoke();
        _rigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }
}
