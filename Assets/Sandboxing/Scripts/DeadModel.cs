using UnityEngine;

public class DeadModel : MonoBehaviour
{
    private Animator Model;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Model = GetComponent<Animator>();

    }

    private void OnTriggerEnter(Collider other)
    {
        Model.SetTrigger("Dead");
    }

    private void OnTriggerExit(Collider other)
    {
        Model.SetTrigger("Float");
    }
}
