using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class ShopPanel : BasePanel {

    private CanvasGroup canvasGroup;
    private void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public override void OnPause()
    {
        canvasGroup.blocksRaycasts = false;
    }

    public override void OnEnter()
    {
        if (canvasGroup == null) canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha = 1;
        canvasGroup.blocksRaycasts = true;

        Vector3 temp = transform.localPosition;
        temp.x = 600;
        transform.localPosition = temp;
        transform.DOLocalMoveX(0, .5f);
    }
    public override void OnExit()
    {
        canvasGroup.blocksRaycasts = false;
        transform.DOLocalMoveX(600, .5f).OnComplete(() => canvasGroup.alpha = 0);
    }
    public override void OnResume()
    {
        canvasGroup.blocksRaycasts = true;
    }
    public void ClosePanel()
    {
        UIManager.Instance.PopPanel();
    }
}
