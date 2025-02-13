using UnityEngine;

public class BoolCube : MonoBehaviour
{
    private Animator Cube;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cube = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Cube.SetBool("IsSpinning", true);
    }

    private void OnTriggerExit(Collider other)
    {
        Cube.SetBool("IsSpinning", false);
    }

}
