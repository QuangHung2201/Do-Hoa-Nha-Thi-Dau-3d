using UnityEngine;
using DG.Tweening;
public class AniController : MonoBehaviour
{
    public static AniController instance;
    [SerializeField] private Transform tranfDoor;
    void Start()
    {
        instance = this;
    }

    public void openDoor(bool status)
    {
        if (!status)
        {
            tranfDoor.DOLocalMoveX(-4.5f, 0.5f)
                .SetEase(Ease.OutQuad);        
        }
        else
        {
            tranfDoor.DOLocalMoveX(0f, 0.5f)
               .SetEase(Ease.OutQuad);
        }    
        UIcontroller.instance.panelDoorUI.SetActive(false);
    }   
    
}
