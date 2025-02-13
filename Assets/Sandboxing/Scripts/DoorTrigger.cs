using UnityEngine;

public class DoorTrigger : MonoBehaviour
{

    private Animator Door;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Door = GetComponent<Animator>();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Door.SetTrigger("Open");
    }

    private void OnTriggerExit(Collider other)
    {
        Door.SetTrigger("Closed");
    }

}
