using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipAnimation : MonoBehaviour
{
    Animator animator;
    public GameObject Tornado;
    public float time = 2;
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("IsTornadoCome", false);
    }

    void Update()
    {
        if (Tornado.activeSelf)
        {
            StartCoroutine(waitAnimation(time));
        }
    }
    IEnumerator waitAnimation(float time)
    {
        yield return new WaitForSeconds(time);
        animator.SetBool("IsTornadoCome", true);

    }
}
