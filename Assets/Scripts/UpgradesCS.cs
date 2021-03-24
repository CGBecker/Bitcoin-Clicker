using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UpgradesCS : MonoBehaviour {


	public Transform[] Ups;
    public bool[] UpsBool;
    public int[] UpsSave;
    private decimal[] UpsCost;     
    

	void Awake () {
		Ups = new Transform[this.transform.childCount];
        UpsSave = new int[Ups.Length];
        UpsBool = new bool[9];
        UpsCost = new decimal[Ups.Length];
        UpsCost[0] = 0.0075m;
        UpsCost[1] = 0.0375m;
        UpsCost[2] = 0.075m;
        UpsCost[3] = 0.1875m;
        UpsCost[4] = 0.375m;
        UpsCost[5] = 0.75m;
        UpsCost[6] = 0.9375m;
        UpsCost[7] = 1.875m;
        UpsCost[8] = 3.75m;
        UpsCost[9] = 4.6875m;
        UpsCost[10] = 7.5m;
        UpsCost[11] = 9.375m;
        UpsCost[12] = 18.75m;
        UpsCost[13] = 23m;
        UpsCost[14] = 37.5m;
        UpsCost[15] = 50m;
        UpsCost[16] = 75m;
        UpsCost[17] = 90m;
        UpsCost[18] = 110m;
        UpsCost[19] = 200m;
        UpsCost[20] = 230m;
        UpsCost[21] = 375m;
        UpsCost[22] = 500m;
        UpsCost[23] = 600m;
        UpsCost[24] = 750m;
        UpsCost[25] = 900m;
        UpsCost[26] = 1100m;
        UpsCost[27] = 1875m;
        UpsCost[28] = 2300m;
        UpsCost[29] = 3000m;
        UpsCost[30] = 3750m;
        UpsCost[31] = 5000m;
        UpsCost[32] = 6000m;
        UpsCost[33] = 7500m;
        UpsCost[34] = 9375m;
        UpsCost[35] = 11000m;
        UpsCost[36] = 14000m;
        UpsCost[37] = 18750m;
        UpsCost[38] = 23000m;
        UpsCost[39] = 30000m;
        UpsCost[40] = 37500m;
        UpsCost[41] = 50000m;
        UpsCost[42] = 60000m;
        UpsCost[43] = 70000m;
        UpsCost[44] = 75000m;
        UpsCost[45] = 93750m;
        UpsCost[46] = 110000m;
        UpsCost[47] = 140000m;
        UpsCost[48] = 187500m;
        UpsCost[49] = 230000m;
        UpsCost[50] = 300000m;
        UpsCost[51] = 375000m;
        UpsCost[52] = 400000m;
        UpsCost[53] = 468750m;
        UpsCost[54] = 600000m;
        UpsCost[55] = 700000m;
        UpsCost[56] = 750000m;
        UpsCost[57] = 937500m;
        UpsCost[58] = 1100000m;
        UpsCost[59] = 1400000m;
        UpsCost[60] = 1875000m;
        UpsCost[61] = 2000000m;
        UpsCost[62] = 2300000m;
        UpsCost[63] = 3000000m;
        UpsCost[64] = 3750000m;
        UpsCost[65] = 4000000m;
        UpsCost[66] = 4687500m;
        UpsCost[67] = 6000000m;
        UpsCost[68] = 7000000m;
        UpsCost[69] = 7500000m;
        UpsCost[70] = 9375000m;
        UpsCost[71] = 11000000m;
        UpsCost[72] = 14000000m;
        UpsCost[73] = 18750000m;
        UpsCost[74] = 20000000m;
        UpsCost[75] = 25000000m;
        UpsCost[76] = 30000000m;
        UpsCost[77] = 37500000m;
        UpsCost[78] = 40000000m;
        UpsCost[79] = 50000000m;
        UpsCost[80] = 60000000m;
        UpsCost[81] = 70000000m;
        UpsCost[82] = 100000000m;
        UpsCost[83] = 110000000m;
        UpsCost[84] = 140000000m;
        UpsCost[85] = 187500000m;
        UpsCost[86] = 200000000m;
        UpsCost[87] = 230000000m;
        UpsCost[88] = 300000000m;
        UpsCost[89] = 400000000m;
        UpsCost[90] = 500000000m;
        UpsCost[91] = 600000000m;
        UpsCost[92] = 700000000m;
        UpsCost[93] = 900000000m;
        UpsCost[94] = 1100000000m;
        UpsCost[95] = 1400000000m;
        UpsCost[96] = 2000000000m;
        UpsCost[97] = 2300000000m;
        UpsCost[98] = 3000000000m;
        UpsCost[99] = 4000000000m;
        UpsCost[100] = 5000000000m;
        UpsCost[101] = 6000000000m;
        UpsCost[102] = 7000000000m;
        UpsCost[103] = 11000000000m;
        UpsCost[104] = 14000000000m;
        UpsCost[105] = 20000000000m;
        UpsCost[106] = 23000000000m;
        UpsCost[107] = 30000000000m;
        UpsCost[108] = 40000000000m;
        UpsCost[109] = 60000000000m;
        UpsCost[110] = 70000000000m;
        UpsCost[111] = 110000000000m;
        UpsCost[112] = 140000000000m;
        UpsCost[113] = 200000000000m;
        UpsCost[114] = 300000000000m;
        UpsCost[115] = 400000000000m;
        UpsCost[116] = 600000000000m;
        UpsCost[117] = 700000000000m;
        UpsCost[118] = 1400000000000m;
        UpsCost[119] = 2000000000000m;
        UpsCost[120] = 3000000000000m;
        UpsCost[121] = 4000000000000m;
        UpsCost[122] = 7000000000000m;
        UpsCost[123] = 14000000000000m;
        UpsCost[124] = 20000000000000m;
        UpsCost[125] = 40000000000000m;
        UpsCost[126] = 70000000000000m;
        UpsCost[127] = 200000000000000m;
        UpsCost[128] = 400000000000000m;
        UpsCost[129] = 2000000000000000m;


        for (int u = 0; u < 9; u++) {
            UpsBool[u] = false;
        }

        PlayerPrefs.DeleteAll();
		for (int i = 0; i < Ups.Length; i++) {
			Ups [i] = this.transform.GetChild (i);
			Ups [i].gameObject.SetActive (true);            
            ColorBlock colorBlock = Ups[i].gameObject.GetComponent<Button>().colors;
            colorBlock.normalColor = Color.gray;
            colorBlock.highlightedColor = Color.gray;
            Ups[i].gameObject.GetComponent<Button>().colors = colorBlock;
            if (PlayerPrefs.HasKey("UpsSave" + i.ToString())){ UpsSave[i] = PlayerPrefs.GetInt("UpsSave" + i.ToString()); }
                      
		}



        ResetUpgrades();
	}

    void FixedUpdate() {
        for (int i = 0; i < Ups.Length; i++) {
            if (GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Bitcoins >= UpsCost[i]) {
                ColorBlock colorBlock = Ups[i].gameObject.GetComponent<Button>().colors;
                colorBlock.normalColor = Color.white;
                colorBlock.highlightedColor = Color.white;
                Ups[i].gameObject.GetComponent<Button>().colors = colorBlock;
            }
        }
    }

    public void ResetUpgrades(){
		float X = -400f;
		for (int i = 0; i < Ups.Length; i++) {
            for (int n1 = 2, m = 1; n1 < 86; n1 += m) {
                if (i == n1)
                {
                    if (UpsSave[i] == 1)
                    {
                        Ups[i].gameObject.SetActive(true);
                    }
                    if (UpsSave[i] == 0)
                    {
                        Ups[i].gameObject.SetActive(false);
                    }
                }
                m++;
            }

            for (int n2 = 5, m = 2; n2 < 95; n2 += m)
            {
                if (i == n2)
                {
                    if (UpsSave[i] == 1)
                    {
                        Ups[i].gameObject.SetActive(true);
                    }
                    if (UpsSave[i] == 0)
                    {
                        Ups[i].gameObject.SetActive(false);
                    }
                }
                m++;
            }

            for (int n3 = 9, m = 3; n3 < 103; n3 += m)
            {
                if (i == n3)
                {
                    if (UpsSave[i] == 1)
                    {
                        Ups[i].gameObject.SetActive(true);
                    }
                    if (UpsSave[i] == 0)
                    {
                        Ups[i].gameObject.SetActive(false);
                    }
                }
                m++;
            }

            for (int n4 = 14, m = 4; n4 < 110; n4 += m)
            {
                if (i == n4)
                {
                    if (UpsSave[i] == 1)
                    {
                        Ups[i].gameObject.SetActive(true);
                    }
                    if (UpsSave[i] == 0)
                    {
                        Ups[i].gameObject.SetActive(false);
                    }
                }
                m++;
            }

            for (int n5 = 20, m = 5; n5 < 116; n5 += m)
            {
                if (i == n5)
                {
                    if (UpsSave[i] == 1)
                    {
                        Ups[i].gameObject.SetActive(true);
                    }
                    if (UpsSave[i] == 0)
                    {
                        Ups[i].gameObject.SetActive(false);
                    }
                }
                m++;
            }

            for (int n6 = 27, m = 6; n6 < 121; n6 += m)
            {
                if (i == n6)
                {
                    if (UpsSave[i] == 1)
                    {
                        Ups[i].gameObject.SetActive(true);
                    }
                    if (UpsSave[i] == 0)
                    {
                        Ups[i].gameObject.SetActive(false);
                    }
                }
                m++;
            }

            for (int n7 = 35, m = 7; n7 < 125; n7 += m)
            {
                if (i == n7)
                {
                    if (UpsSave[i] == 1)
                    {
                        Ups[i].gameObject.SetActive(true);
                    }
                    if (UpsSave[i] == 0)
                    {
                        Ups[i].gameObject.SetActive(false);
                    }
                }
                m++;
            }

            for (int n8 = 44, m = 8; n8 < 128; n8 += m)
            {
                if (i == n8)
                {
                    if (UpsSave[i] == 1)
                    {
                        Ups[i].gameObject.SetActive(true);
                    }
                    if (UpsSave[i] == 0)
                    {
                        Ups[i].gameObject.SetActive(false);
                    }
                }
                m++;
            }

            for (int n9 = 54, m = 9; n9 < 130; n9 += m)
            {
                if (i == n9)
                {
                    if (UpsSave[i] == 1)
                    {
                        Ups[i].gameObject.SetActive(true);
                    }
                    if (UpsSave[i] == 0)
                    {
                        Ups[i].gameObject.SetActive(false);
                    }
                }
                m++;
            }

            if (Ups [i].gameObject.activeSelf == true) {
				Ups [i].localPosition = new Vector2 (X, 0);
				X += 200;
                PlayerPrefs.SetInt("UpsSave" + i.ToString(), 1);
			}
            if (Ups[i].gameObject.activeSelf == false) {                
                PlayerPrefs.SetInt("UpsSave" + i.ToString(), 0);
            }
        }
		
	}

	public void Up(){      

        for (int i = 0; i < 130; i++) {
            if (EventSystem.current.currentSelectedGameObject.transform == Ups[i] && UpsCost[i] <= GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Bitcoins) {

                if (EventSystem.current.currentSelectedGameObject.name == "0 - a")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button0Power = 1;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "0 - b")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button0Power = 2;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "0 - c")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button0Power = 3;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "0 - d")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button0Power = 4;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "0 - e")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button0Power = 5;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "0 - f")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button0Power = 6;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "0 - g")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button0Power = 7;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "0 - h")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button0Power = 8;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "0 - i")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button0Power = 9;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "0 - j")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button0Power = 10;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "0 - k")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button0Power = 11;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "0 - L")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button0Power = 12;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "0 - m")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button0Power = 13;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "1 - a")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button1Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button1Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "1 - b")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button1Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button1Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "1 - c")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button1Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button1Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "1 - d")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button1Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button1Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "1 - e")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button1Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button1Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "1 - f")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button1Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button1Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "1 - g")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button1Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button1Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "1 - h")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button1Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button1Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "1 - i")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button1Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button1Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "1 - j")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button1Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button1Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "1 - k")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button1Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button1Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "1 - L")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button1Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button1Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "1 - m")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button1Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button1Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "2 - a")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button2Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button2Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "2 - b")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button2Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button2Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "2 - c")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button2Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button2Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "2 - d")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button2Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button2Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "2 - e")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button2Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button2Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "2 - f")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button2Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button2Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "2 - g")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button2Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button2Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "2 - h")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button2Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button2Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "2 - i")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button2Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button2Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "2 - j")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button2Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button2Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "2 - k")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button2Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button2Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "2 - L")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button2Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button2Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "2 - m")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button2Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button2Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "3 - a")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button3Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button3Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "3 - b")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button3Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button3Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "3 - c")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button3Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button3Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "3 - d")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button3Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button3Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "3 - e")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button3Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button3Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "3 - f")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button3Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button3Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "3 - g")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button3Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button3Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "3 - h")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button3Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button3Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "3 - i")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button3Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button3Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "3 - j")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button3Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button3Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "3 - k")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button3Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button3Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "3 - L")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button3Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button3Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "3 - m")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button3Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button3Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "4 - a")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button4Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button4Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "4 - b")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button4Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button4Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "4 - c")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button4Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button4Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "4 - d")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button4Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button4Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "4 - e")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button4Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button4Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "4 - f")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button4Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button4Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "4 - g")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button4Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button4Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "4 - h")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button4Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button4Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "4 - i")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button4Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button4Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "4 - j")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button4Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button4Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "4 - k")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button4Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button4Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "4 - L")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button4Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button4Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "4 - m")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button4Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button4Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "5 - a")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button5Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button5Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "5 - b")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button5Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button5Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "5 - c")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button5Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button5Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "5 - d")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button5Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button5Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "5 - e")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button5Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button5Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "5 - f")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button5Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button5Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "5 - g")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button5Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button5Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "5 - h")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button5Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button5Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "5 - i")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button5Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button5Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "5 - j")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button5Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button5Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "5 - k")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button5Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button5Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "5 - L")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button5Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button5Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "5 - m")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button5Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button5Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "6 - a")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button6Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button6Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "6 - b")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button6Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button6Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "6 - c")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button6Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button6Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "6 - d")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button6Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button6Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "6 - e")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button6Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button6Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "6 - f")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button6Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button6Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "6 - g")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button6Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button6Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "6 - h")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button6Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button6Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "6 - i")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button6Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button6Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "6 - j")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button6Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button6Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "6 - k")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button6Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button6Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "6 - L")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button6Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button6Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "6 - m")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button6Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button6Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "7 - a")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button7Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button7Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "7 - b")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button7Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button7Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "7 - c")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button7Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button7Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "7 - d")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button7Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button7Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "7 - e")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button7Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button7Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "7 - f")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button7Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button7Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "7 - g")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button7Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button7Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "7 - h")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button7Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button7Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "7 - i")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button7Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button7Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "7 - j")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button7Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button7Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "7 - k")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button7Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button7Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "7 - L")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button7Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button7Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "7 - m")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button7Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button7Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "8 - a")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button8Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button8Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "8 - b")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button8Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button8Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "8 - c")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button8Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button8Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "8 - d")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button8Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button8Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "8 - e")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button8Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button8Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "8 - f")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button8Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button8Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "8 - g")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button8Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button8Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "8 - h")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button8Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button8Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "8 - i")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button8Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button8Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "8 - j")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button8Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button8Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "8 - k")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button8Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button8Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "8 - L")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button8Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button8Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "8 - m")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button8Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button8Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "9 - a")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button9Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button9Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "9 - b")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button9Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button9Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "9 - c")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button9Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button9Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "9 - d")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button9Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button9Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "9 - e")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button9Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button9Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "9 - f")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button9Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button9Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "9 - g")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button9Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button9Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "9 - h")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button9Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button9Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "9 - i")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button9Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button9Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "9 - j")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button9Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button9Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "9 - k")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button9Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button9Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "9 - L")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button9Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button9Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }
                if (EventSystem.current.currentSelectedGameObject.name == "9 - m")
                {
                    GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button9Upgrades += GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Button9Upgrades;
                    EventSystem.current.currentSelectedGameObject.SetActive(false);
                    ResetUpgrades();
                }

                GameObject.FindGameObjectWithTag("MainButton").GetComponent<MainButton>().Bitcoins -= UpsCost[i];
                UpsSave[i] = 0;                
            }
        }        
        
    }
	

}
