using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenupanel : BasePanel {

    private CanvasGroup canvasGroup;
    private void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public override void OnPause()
    {
        canvasGroup.blocksRaycasts = false;
    }
    public override void OnResume()
    {
        canvasGroup.blocksRaycasts = true;
    }
    public void OnPushPanel(string panelTypestring)
    {
        UIPanelType panelType = (UIPanelType)System.Enum.Parse(typeof(UIPanelType), panelTypestring);
        UIManager.Instance.PushPanel(panelType);
<<<<<<< HEAD
=======
        print("我修改的第一个地方");
        print("这是我最后一次修改得地方");
        print("这是我修改得第二次");
>>>>>>> 39e17d6e54b1fee1e816f5249b3650a611502893
    }
}
