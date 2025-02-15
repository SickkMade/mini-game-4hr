using System.Collections;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class PlayerHit : MonoBehaviour
{
    private CharacterController characterController;
    private Vector3 hitVelocity = Vector3.zero;
    private bool isHit = false;
    
    [SerializeField]
    private float hitRecoverySpeed = 2f;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (hitVelocity.magnitude > 0.01f)
        {
            characterController.Move(hitVelocity * Time.deltaTime);
            
            hitVelocity = Vector3.Lerp(hitVelocity, Vector3.zero, hitRecoverySpeed * Time.deltaTime);
        }
        else
        {
            isHit = false;
            hitVelocity = Vector3.zero;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            ApplyHit(10f, -other.transform.forward);
        }
    }

    private void ApplyHit(float force, Vector3 direction)
    {
        if (!isHit || force > hitVelocity.magnitude)
        {
            hitVelocity = direction * force;
            isHit = true;
        }
    }
}