using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollRectPosDebugger : MonoBehaviour {

    private float MaximumScreenHeight = 1920;
    private float ScreenProportion = 1;

    void Start () {
        RectTransform rt = this.GetComponent(typeof(RectTransform)) as RectTransform;
        //this.rectTransform.rect.size = new Vector2(Screen.width * 0.3f, Screen.width * 0.3f);

        ScreenProportion = Screen.height / MaximumScreenHeight;

        rt.anchoredPosition = new Vector2(rt.anchoredPosition.x, rt.anchoredPosition.y*ScreenProportion);
        //print(ScreenProportion + " " + rt.anchoredPosition.y);
    }
	
	
	void Update () {
		
	}
}
