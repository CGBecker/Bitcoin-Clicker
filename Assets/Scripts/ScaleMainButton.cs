using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleMainButton : MonoBehaviour {

    private float MaximumScreenWidth = 1080;
    private float ScreenProportion = 1;
   


    void Start () {
        RectTransform rt = this.GetComponent(typeof(RectTransform)) as RectTransform;
        //this.rectTransform.rect.size = new Vector2(Screen.width * 0.3f, Screen.width * 0.3f);

        ScreenProportion = Screen.width / MaximumScreenWidth;

        rt.localScale = new Vector2(ScreenProportion, ScreenProportion);
        rt.anchoredPosition = new Vector2(rt.anchoredPosition.x*ScreenProportion, rt.anchoredPosition.y);
        //print(Screen.width+" "+ScreenProportion);
    }
	
	
	void Update () {
		
	}
}
