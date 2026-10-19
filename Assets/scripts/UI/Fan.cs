using UnityEngine;
using UnityEngine.UI;

public class Fan : MonoBehaviour
{
    [SerializeField] private Button btnopen;
    void Start()
    {

    }

    private void OnEnable()
    {
        btnopen.onClick.AddListener(AniController.instance.moveFan);
    }

}
