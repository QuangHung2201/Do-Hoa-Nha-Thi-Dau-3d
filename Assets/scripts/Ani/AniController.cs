using UnityEngine;
using DG.Tweening;

public class AniController : MonoBehaviour
{
    public static AniController instance;

    private bool statusFan;

    [SerializeField] private Transform tranfDoor;
    [SerializeField] private Transform target;
    [SerializeField] private Transform FanOb;

    private Vector3 naturalFanPosition;
    private Quaternion naturalFanRotation;

    void Start()
    {
        instance = this;
        statusFan = false;

        // Lưu trạng thái ban đầu
        naturalFanPosition = FanOb.position;
        naturalFanRotation = FanOb.rotation;
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

    public void moveFan()
    {
        // Dừng animation cũ nếu người dùng bấm liên tục
        FanOb.DOKill();

        if (!statusFan)
        {
            statusFan = true;

            Vector3 targetPos = target.position;
            targetPos.x -= 5f;

            Sequence sequence = DOTween.Sequence();

            // Di chuyển
            sequence.Append(
                FanOb.DOMove(targetPos, 0.5f)
                    .SetEase(Ease.OutQuad)
            );

            // Xoay -90 độ
            sequence.Append(
                FanOb.DORotate(
                    FanOb.eulerAngles + new Vector3(0f, 0f, -90f),
                    0.5f
                )
                .SetEase(Ease.OutQuad)
            );
        }
        else
        {
            statusFan = false;

            Sequence sequence = DOTween.Sequence();

            // Về vị trí ban đầu
            sequence.Append(
                FanOb.DOMove(naturalFanPosition, 0.5f)
                    .SetEase(Ease.OutQuad)
            );

            // Về rotation ban đầu
            sequence.Append(
                FanOb.DORotateQuaternion(
                    naturalFanRotation,
                    0.5f
                )
                .SetEase(Ease.OutQuad)
            );
        }
    }
}