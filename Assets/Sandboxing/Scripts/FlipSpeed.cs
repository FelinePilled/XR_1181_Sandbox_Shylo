using UnityEngine;

public class FlipSpeed : MonoBehaviour
{
    private Animator Capsule;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Capsule = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Capsule.SetFloat("Speed", 0f);
    }

    private void OnTriggerExit(Collider other)
    {
        Capsule.SetFloat("Speed", 1f);
    }
}
