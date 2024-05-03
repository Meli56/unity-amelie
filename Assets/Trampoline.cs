using System.Collections;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class TRampoline : MonoBehaviour
{
    public Animator Animator;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(jumpTrampo());
        }
    }
    IEnumerator jumpTrampo()
    {
        Animator.SetBool("touch", true);
        yield return new WaitForSeconds(0.5f);
        Animator.SetBool("touch", false);
    }
}