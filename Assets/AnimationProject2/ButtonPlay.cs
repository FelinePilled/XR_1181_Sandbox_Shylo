using UnityEngine;

public class ButtonPlay : MonoBehaviour
{
    private Animator Point;
    public GameObject buttonguy;
    public GameObject Replaybutton;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Point = GetComponent<Animator>();

    }

    public void PointActivate()
    {
        Point.SetTrigger("Button");
        buttonguy.SetActive(false);
    }


    public void ReplayActivate()
    {
        Point.SetTrigger("Restart");
        Replaybutton.SetActive(false);
    }

}
