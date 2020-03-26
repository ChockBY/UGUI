using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMessagePanel : BasePanel {

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
        this.transform.position = new Vector3(400f, transform.position.y, transform.position.z);
        canvasGroup.blocksRaycasts = true;

    }
    public override void OnExit()
    {
        canvasGroup.blocksRaycasts = false;
        canvasGroup.alpha = 0;
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
