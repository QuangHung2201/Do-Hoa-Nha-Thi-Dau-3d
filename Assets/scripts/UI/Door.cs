using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    public bool status_Door;
    public Button btnOpen;
    void Start()
    {
        status_Door = false;
        btnOpen.onClick.AddListener(checkdoor);
    }

    public void checkdoor()
    {
        AniController.instance.openDoor(status_Door);
        if(!status_Door)
        {
            status_Door=true;
        }    
        else
        {
            status_Door=false;  
        }    
    }    
}
