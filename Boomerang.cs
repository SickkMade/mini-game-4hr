using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Boomerang : Weapon
{
    bool _swingState = false;
    [SerializeField, Range(0,5)] private float cooldownSeconds = .25f;
    private Vector3 initOffset;
    private Quaternion initRotation;

    Animator animator;

    Collider objCollider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        objCollider = GetComponentInChildren<Collider>();
        initOffset = transform.localPosition;
        initRotation = transform.localRotation;
    }

    private void Update()
    {

    }


    public override void SwingBat()
    {
        if (IsSwinging)
            return;
        IsSwinging = true;
    }

    public void AnimationFinished()
    {
        StartCoroutine(Cooldown());
        transform.localPosition = initOffset;
        transform.localRotation = initRotation;
    }

    private IEnumerator Cooldown(){
        yield return new WaitForSeconds(cooldownSeconds);
        IsSwinging = false;
    }


}
