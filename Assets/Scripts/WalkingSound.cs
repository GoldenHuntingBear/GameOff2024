using System.Collections;
using System.Collections.Generic;
using SupanthaPaul;
using UnityEngine;

public class WalkingSound : MonoBehaviour
{
    public Animator animator;
    public List<AudioClip> walkingSounds;
    public float secondsBetween = 1f;
    private AudioSource source;
    private bool isCoroutineRunning = false;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        bool is_running = animator.GetCurrentAnimatorStateInfo(0).IsName("Run");
        if (is_running && !isCoroutineRunning)
        {
            StartCoroutine(PlayWalkingSound());
        }
    }
    IEnumerator PlayWalkingSound()
    {
        isCoroutineRunning = true;
        int clip_index = Random.Range(0, walkingSounds.Count);
        source.clip = walkingSounds[clip_index];
        source.Play();
        yield return new WaitForSeconds(secondsBetween);
        isCoroutineRunning = false;
    }
}
