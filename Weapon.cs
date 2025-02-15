using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    bool _swingState = false;
    [SerializeField, Range(0,5)] private float cooldownSeconds = .25f;

    public bool IsSwinging
    {
        get { return _swingState; }
        set
        {
            _swingState = value;
            objCollider.enabled = _swingState;
            animator.SetBool("IsSwinging", _swingState);
        }
    }

    Animator animator;

    Collider objCollider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        objCollider = GetComponentInChildren<Collider>();
    }

    public void EnableHitbox()
    {
        objCollider.enabled = true;
    }

    public void DisableHitbox()
    {
        objCollider.enabled = false;
    }


    public virtual void SwingBat()
    {
        if (IsSwinging)
            return;
        IsSwinging = true;
    }

    public void AnimationFinished()
    {
        StartCoroutine(Cooldown());
    }

    private IEnumerator Cooldown(){
        yield return new WaitForSeconds(cooldownSeconds);
        IsSwinging = false;
    }


}
