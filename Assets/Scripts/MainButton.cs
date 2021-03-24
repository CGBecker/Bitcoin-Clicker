using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class MainButton : MonoBehaviour {

	//controle do Botaozao
	private float size = 1;
	private float scaleX, scaleY;   

	//Controle dos bitcoins
	private Text BitCount;
	public decimal Bitcoins;
    private Text BPScount;
    private decimal BitPerSec;
    private decimal AllTimeBitcoins;

    //controle dos upgrades
    public decimal Button0Power = 0;
	private decimal Button1Power = 0;
	private decimal Button1PowerPS = 0;
	private decimal Button2Power = 0;
	private decimal Button3Power = 0;
	private decimal Button4Power = 0;
    private decimal Button5Power = 0;
    private decimal Button6Power = 0;
    private decimal Button7Power = 0;
    private decimal Button8Power = 0;
    private decimal Button9Power = 0;
    public int Button1Upgrades = 1;
    public int Button2Upgrades = 1;
    public int Button3Upgrades = 1;
    public int Button4Upgrades = 1;
    public int Button5Upgrades = 1;
    public int Button6Upgrades = 1;
    public int Button7Upgrades = 1;
    public int Button8Upgrades = 1;
    public int Button9Upgrades = 1;

    //controle do tempo
    private float tempo;

	//controle do pixelRain
	private bool At1000 = false;
	private bool At1000000 = false;
	private bool At21000000 = false;
	private bool AtBillion = false;

    #region controle dos botoes
    //controle dos botoes
    private GameObject Button1On;
    private GameObject Button1Off;
    private GameObject Button2On;
    private GameObject Button2Off;
    private GameObject Button3On;
    private GameObject Button3Off;
    private GameObject Button3Cloaked;
    private GameObject Button4On;
    private GameObject Button4Off;
    private GameObject Button4Cloaked;
    private GameObject Button5On;
    private GameObject Button5Off;
    private GameObject Button5Cloaked;
    private GameObject Button6On;
    private GameObject Button6Off;
    private GameObject Button6Cloaked;
    private GameObject Button7On;
    private GameObject Button7Off;
    private GameObject Button7Cloaked;
    private GameObject Button8On;
    private GameObject Button8Off;
    private GameObject Button8Cloaked;
    private GameObject Button9On;
    private GameObject Button9Off;
    private GameObject Button9Cloaked;
    #endregion

    #region controle de precos
    //Controle de precos
    private decimal Button1;
    public int Button1LVL;
    private decimal Button1Upgrade;
    private decimal Button2;
    public int Button2LVL;
    private decimal Button2Upgrade;
    private decimal Button3;
    public int Button3LVL;
    private decimal Button3Upgrade;
    private decimal Button4;
    public int Button4LVL;
    private decimal Button4Upgrade;
    private decimal Button5;
    public int Button5LVL;
    private decimal Button5Upgrade;
    private decimal Button6;
    public int Button6LVL;
    private decimal Button6Upgrade;
    private decimal Button7;
    public int Button7LVL;
    private decimal Button7Upgrade;
    private decimal Button8;
    public int Button8LVL;
    private decimal Button8Upgrade;
    private decimal Button9;
    public int Button9LVL;
    private decimal Button9Upgrade;
    #endregion

    void Start () {

        #region identificando gameObjects
        //identificando gameObjects
        BitCount = GameObject.FindGameObjectWithTag("BitCount").GetComponent<Text>();
        BPScount = GameObject.FindGameObjectWithTag("BitPerSec").GetComponent<Text>();
        Button1On = GameObject.FindGameObjectWithTag("Button1On");
        Button1Off = GameObject.FindGameObjectWithTag("Button1Off");
        Button2On = GameObject.FindGameObjectWithTag("Button2On");
        Button2Off = GameObject.FindGameObjectWithTag("Button2Off");
        Button3On = GameObject.FindGameObjectWithTag("Button3On");
        Button3Off = GameObject.FindGameObjectWithTag("Button3Off");
        Button3Cloaked = GameObject.FindGameObjectWithTag("Button3Cloaked");
        Button4On = GameObject.FindGameObjectWithTag("Button4On");
        Button4Off = GameObject.FindGameObjectWithTag("Button4Off");
        Button4Cloaked = GameObject.FindGameObjectWithTag("Button4Cloaked");
        Button5On = GameObject.FindGameObjectWithTag("Button5On");
        Button5Off = GameObject.FindGameObjectWithTag("Button5Off");
        Button5Cloaked = GameObject.FindGameObjectWithTag("Button5Cloaked");
        Button6On = GameObject.FindGameObjectWithTag("Button6On");
        Button6Off = GameObject.FindGameObjectWithTag("Button6Off");
        Button6Cloaked = GameObject.FindGameObjectWithTag("Button6Cloaked");
        Button7On = GameObject.FindGameObjectWithTag("Button7On");
        Button7Off = GameObject.FindGameObjectWithTag("Button7Off");
        Button7Cloaked = GameObject.FindGameObjectWithTag("Button7Cloaked");
        Button8On = GameObject.FindGameObjectWithTag("Button8On");
        Button8Off = GameObject.FindGameObjectWithTag("Button8Off");
        Button8Cloaked = GameObject.FindGameObjectWithTag("Button8Cloaked");
        Button9On = GameObject.FindGameObjectWithTag("Button9On");
        Button9Off = GameObject.FindGameObjectWithTag("Button9Off");
        Button9Cloaked = GameObject.FindGameObjectWithTag("Button9Cloaked");
        #endregion


        //definindo variaveis   
        Button1LVL = 0;
        Button2LVL = 0;
        Button3LVL = 0;
        Button4LVL = 0;
        Button5LVL = 0;
        Button6LVL = 0;
        Button7LVL = 0;
        Button8LVL = 0;
        Button9LVL = 0;
        Button1Power = 0.0001m;
        Button1PowerPS = 0;
		Button2Power = 0;
		Button3Power = 0;
		Button4Power = 0;
        Button5Power = 0;
        Button6Power = 0;
        Button7Power = 0;
        Button8Power = 0;
        Button9Power = 0;

        BitPerSec = Button1PowerPS + Button2Power + Button3Power + Button4Power;        

        //definindo precos
        Button1 = 0.0010m;
        Button2 = 0.0100m;
        Button3 = 0.1000m;
        Button4 = 1.0000m;
        Button5 = 10.0000m;
        Button6 = 100.0000m;
        Button7 = 1000.0000m;
        Button8 = 10000.0000m;
        Button9 = 100000.0000m;

        //definindo regulador de Resizing de Click
        scaleX = this.transform.lossyScale.x;
		scaleY = this.transform.lossyScale.y;

        //definindo velocidade do PixelRain
		this.transform.parent.parent.GetComponentInChildren<PixelRain> ().speed = -5f;
		this.transform.parent.parent.GetComponentInChildren<PixelRain> ().Timing = 10;

        #region Load
        //Load   
        //PlayerPrefs.DeleteAll();
        if (PlayerPrefs.HasKey("AllTimeCoins")) { AllTimeBitcoins = System.Convert.ToDecimal(PlayerPrefs.GetString("AllTimeCoins")); }
        if (PlayerPrefs.HasKey("Coins")){ Bitcoins = System.Convert.ToDecimal(PlayerPrefs.GetString("Coins")); }
        if (PlayerPrefs.HasKey("Button1LVL")) { Button1LVL = PlayerPrefs.GetInt("Button1LVL"); }        
        if (PlayerPrefs.HasKey("Button2LVL")) { Button2LVL = PlayerPrefs.GetInt("Button2LVL"); }        
        if (PlayerPrefs.HasKey("Button3LVL")) { Button3LVL = PlayerPrefs.GetInt("Button3LVL"); }        
        if (PlayerPrefs.HasKey("Button4LVL")) { Button4LVL = PlayerPrefs.GetInt("Button4LVL"); }        
        if (PlayerPrefs.HasKey("Button5LVL")) { Button5LVL = PlayerPrefs.GetInt("Button5LVL"); }
        if (PlayerPrefs.HasKey("Button6LVL")) { Button6LVL = PlayerPrefs.GetInt("Button6LVL"); }
        if (PlayerPrefs.HasKey("Button7LVL")) { Button7LVL = PlayerPrefs.GetInt("Button7LVL"); }
        if (PlayerPrefs.HasKey("Button8LVL")) { Button7LVL = PlayerPrefs.GetInt("Button8LVL"); }
        if (PlayerPrefs.HasKey("Button9LVL")) { Button7LVL = PlayerPrefs.GetInt("Button9LVL"); }
        if (PlayerPrefs.HasKey("Button1")) { Button1 = System.Convert.ToDecimal(PlayerPrefs.GetString("Button1")); }
        if (PlayerPrefs.HasKey("Button2")) { Button2 = System.Convert.ToDecimal(PlayerPrefs.GetString("Button2")); }
        if (PlayerPrefs.HasKey("Button3")) { Button3 = System.Convert.ToDecimal(PlayerPrefs.GetString("Button3")); }
        if (PlayerPrefs.HasKey("Button4")) { Button4 = System.Convert.ToDecimal(PlayerPrefs.GetString("Button4")); }
        if (PlayerPrefs.HasKey("Button5")) { Button5 = System.Convert.ToDecimal(PlayerPrefs.GetString("Button5")); }
        if (PlayerPrefs.HasKey("Button6")) { Button6 = System.Convert.ToDecimal(PlayerPrefs.GetString("Button6")); }
        if (PlayerPrefs.HasKey("Button7")) { Button7 = System.Convert.ToDecimal(PlayerPrefs.GetString("Button7")); }
        if (PlayerPrefs.HasKey("Button8")) { Button7 = System.Convert.ToDecimal(PlayerPrefs.GetString("Button8")); }
        if (PlayerPrefs.HasKey("Button9")) { Button7 = System.Convert.ToDecimal(PlayerPrefs.GetString("Button9")); }
        if (PlayerPrefs.HasKey("Button1Power")) { Button1Power = System.Convert.ToDecimal(PlayerPrefs.GetString("Button1Power")); }
        if (PlayerPrefs.HasKey("Button1PowerPS")) { Button1PowerPS = System.Convert.ToDecimal(PlayerPrefs.GetString("Button1PowerPS")); }
        if (PlayerPrefs.HasKey("Button2Power")) { Button2Power = System.Convert.ToDecimal(PlayerPrefs.GetString("Button2Power")); }
        if (PlayerPrefs.HasKey("Button3Power")) { Button3Power = System.Convert.ToDecimal(PlayerPrefs.GetString("Button3Power")); }
        if (PlayerPrefs.HasKey("Button4Power")) { Button4Power = System.Convert.ToDecimal(PlayerPrefs.GetString("Button4Power")); }
        if (PlayerPrefs.HasKey("Button5Power")) { Button5Power = System.Convert.ToDecimal(PlayerPrefs.GetString("Button5Power")); }
        if (PlayerPrefs.HasKey("Button6Power")) { Button6Power = System.Convert.ToDecimal(PlayerPrefs.GetString("Button6Power")); }
        if (PlayerPrefs.HasKey("Button7Power")) { Button7Power = System.Convert.ToDecimal(PlayerPrefs.GetString("Button7Power")); }
        if (PlayerPrefs.HasKey("Button8Power")) { Button8Power = System.Convert.ToDecimal(PlayerPrefs.GetString("Button8Power")); }
        if (PlayerPrefs.HasKey("Button9Power")) { Button9Power = System.Convert.ToDecimal(PlayerPrefs.GetString("Button9Power")); }

        #endregion

        //Debug.Log(AllTimeBitcoins);
    }


    void FixedUpdate () {

        //Contagem de bitcoins e BPS
        AllTimeBitcoins += ((Button1PowerPS*Button1Upgrades) / 60 + (Button2Power*Button2Upgrades) / 60 + (Button3Power*Button3Upgrades) / 60 + (Button4Power*Button4Upgrades) / 60 + (Button5Power*Button5Upgrades) / 60 + (Button6Power*Button6Upgrades) / 60 + (Button7Power*Button7Upgrades) / 60 + (Button8Power*Button8Upgrades) / 60 + (Button9Power*Button9Upgrades) / 60);
        Bitcoins += ((Button1PowerPS * Button1Upgrades) / 60 + (Button2Power * Button2Upgrades) / 60 + (Button3Power * Button3Upgrades) / 60 + (Button4Power * Button4Upgrades) / 60 + (Button5Power * Button5Upgrades) / 60 + (Button6Power * Button6Upgrades) / 60 + (Button7Power * Button7Upgrades) / 60 + (Button8Power * Button8Upgrades) / 60 + (Button9Power * Button9Upgrades) / 60);
        BitPerSec = ((Button1PowerPS * Button1Upgrades) + (Button2Power * Button2Upgrades) + (Button3Power * Button3Upgrades) + (Button4Power * Button4Upgrades) + (Button5Power * Button5Upgrades) + (Button6Power * Button6Upgrades) + (Button7Power * Button7Upgrades) + (Button8Power * Button8Upgrades) + (Button9Power * Button9Upgrades));
        BitCount.text = Bitcoins.ToString ("F4");
        BPScount.text = BitPerSec.ToString("F4");

        #region MainButton Resizing
        //MainButton Resizing
        this.transform.localScale = new Vector2(scaleX * size, scaleY * size);

        if (size < 1) {
			size += 0.025f;		
		}
		if (size > 1) {
			size = 1;
		}
        #endregion

        #region PixelRain Control
        //PixelRain control
        if (Bitcoins > 1000 && At1000 == false) {			
			At1000 = true;
			this.transform.parent.parent.GetComponentInChildren<PixelRain> ().speed = -10f;
			this.transform.parent.parent.GetComponentInChildren<PixelRain> ().Timing = 8;
		}
		if (Bitcoins > 1000000 && At1000000 == false) {			
			At1000000 = true;
			this.transform.parent.parent.GetComponentInChildren<PixelRain> ().speed = -15f;
			this.transform.parent.parent.GetComponentInChildren<PixelRain> ().Timing = 6;
		}
		if (Bitcoins > 21000000 && At21000000 == false) {
			At21000000 = true;
			this.transform.parent.parent.GetComponentInChildren<PixelRain> ().speed = -20f;
			this.transform.parent.parent.GetComponentInChildren<PixelRain> ().Timing = 3;
		}
		if (Bitcoins > 1000000000 && AtBillion == false) {
			AtBillion = true;
			this.transform.parent.parent.GetComponentInChildren<PixelRain> ().speed = -30f;
			this.transform.parent.parent.GetComponentInChildren<PixelRain> ().Timing = 1;
		}
        #endregion

        #region Buttons Activation Control
        //Buttons Activation Control
        if (AllTimeBitcoins >= Button3) {
            Button3Cloaked.SetActive(false);
            Button3Off.SetActive(true);
        }else if (AllTimeBitcoins < Button3) {
            Button3Cloaked.SetActive(true);
            Button3On.SetActive(false);
            Button3Off.SetActive(false);
        }
        if (AllTimeBitcoins >= Button4)
        {
            Button4Cloaked.SetActive(false);
            Button4Off.SetActive(true);
        }
        else if (AllTimeBitcoins < Button4)
        {
            Button4Cloaked.SetActive(true);
            Button4On.SetActive(false);
            Button4Off.SetActive(false);
        }
        if (AllTimeBitcoins >= Button5)
        {
            Button5Cloaked.SetActive(false);
            Button5Off.SetActive(true);
        }
        else if (AllTimeBitcoins < Button5)
        {
            Button5Cloaked.SetActive(true);
            Button5On.SetActive(false);
            Button5Off.SetActive(false);
        }
        if (AllTimeBitcoins >= Button6)
        {
            Button6Cloaked.SetActive(false);
            Button6Off.SetActive(true);
        }
        else if (AllTimeBitcoins < Button6)
        {
            Button6Cloaked.SetActive(true);
            Button6On.SetActive(false);
            Button6Off.SetActive(false);
        }
        if (AllTimeBitcoins >= Button7)
        {
            Button7Cloaked.SetActive(false);
            Button7Off.SetActive(true);
        }
        else if (AllTimeBitcoins < Button7)
        {
            Button7Cloaked.SetActive(true);
            Button7On.SetActive(false);
            Button7Off.SetActive(false);
        }
        if (AllTimeBitcoins >= Button8)
        {
            Button8Cloaked.SetActive(false);
            Button8Off.SetActive(true);
        }
        else if (AllTimeBitcoins < Button8)
        {
            Button8Cloaked.SetActive(true);
            Button8On.SetActive(false);
            Button8Off.SetActive(false);
        }
        if (AllTimeBitcoins >= Button9)
        {
            Button9Cloaked.SetActive(false);
            Button9Off.SetActive(true);
        }
        else if (AllTimeBitcoins < Button9)
        {
            Button9Cloaked.SetActive(true);
            Button9On.SetActive(false);
            Button9Off.SetActive(false);
        }


        if (Bitcoins >= Button1) {
            Button1Off.SetActive(false);
            Button1On.SetActive(true);
        }else if(Bitcoins < Button1) {
            Button1Off.SetActive(true);
            Button1On.SetActive(false);
        }
        if (Bitcoins >= Button2)
        {
            Button2Off.SetActive(false);
            Button2On.SetActive(true);
        }
        else if (Bitcoins < Button2)
        {
            Button2Off.SetActive(true);
            Button2On.SetActive(false);
        }
        if (Bitcoins >= Button3)
        {
            Button3Off.SetActive(false);
            Button3On.SetActive(true);
        }
        else if (Bitcoins < Button3 && AllTimeBitcoins > Button3)
        {
            Button3Off.SetActive(true);
            Button3On.SetActive(false);
        }
        if (Bitcoins >= Button4)
        {
            Button4Off.SetActive(false);
            Button4On.SetActive(true);
        }
        else if (Bitcoins < Button4 && AllTimeBitcoins > Button4)
        {
            Button4Off.SetActive(true);
            Button4On.SetActive(false);
        }
        if (Bitcoins >= Button5)
        {
            Button5Off.SetActive(false);
            Button5On.SetActive(true);
        }
        else if (Bitcoins < Button5 && AllTimeBitcoins > Button5)
        {
            Button5Off.SetActive(true);
            Button5On.SetActive(false);
        }
        if (Bitcoins >= Button6)
        {
            Button6Off.SetActive(false);
            Button6On.SetActive(true);
        }
        else if (Bitcoins < Button6 && AllTimeBitcoins > Button6)
        {
            Button6Off.SetActive(true);
            Button6On.SetActive(false);
        }
        if (Bitcoins >= Button7)
        {
            Button7Off.SetActive(false);
            Button7On.SetActive(true);
        }
        else if (Bitcoins < Button7 && AllTimeBitcoins > Button7)
        {
            Button7Off.SetActive(true);
            Button7On.SetActive(false);
        }
        if (Bitcoins >= Button8)
        {
            Button8Off.SetActive(false);
            Button8On.SetActive(true);
        }
        else if (Bitcoins < Button8 && AllTimeBitcoins > Button8)
        {
            Button8Off.SetActive(true);
            Button8On.SetActive(false);
        }
        if (Bitcoins >= Button9)
        {
            Button9Off.SetActive(false);
            Button9On.SetActive(true);
        }
        else if (Bitcoins < Button9 && AllTimeBitcoins > Button9)
        {
            Button9Off.SetActive(true);
            Button9On.SetActive(false);
        }

        #endregion //        

        #region Save
        //Save
        tempo += Time.deltaTime;
        if (tempo > 10)
        {
            PlayerPrefs.SetString("Coins", Bitcoins.ToString());
            PlayerPrefs.SetString("AllTimeCoins", AllTimeBitcoins.ToString());
            PlayerPrefs.SetInt("Button1LVL", Button1LVL);
            PlayerPrefs.SetInt("Button2LVL", Button2LVL);
            PlayerPrefs.SetInt("Button3LVL", Button3LVL);
            PlayerPrefs.SetInt("Button4LVL", Button4LVL);
            PlayerPrefs.SetInt("Button5LVL", Button5LVL);
            PlayerPrefs.SetInt("Button6LVL", Button6LVL);
            PlayerPrefs.SetInt("Button7LVL", Button7LVL);
            PlayerPrefs.SetInt("Button8LVL", Button8LVL);
            PlayerPrefs.SetInt("Button9LVL", Button9LVL);
            PlayerPrefs.SetString("Button1", Button1.ToString());
            PlayerPrefs.SetString("Button2", Button2.ToString());
            PlayerPrefs.SetString("Button3", Button3.ToString());
            PlayerPrefs.SetString("Button4", Button4.ToString());
            PlayerPrefs.SetString("Button5", Button5.ToString());
            PlayerPrefs.SetString("Button6", Button6.ToString());
            PlayerPrefs.SetString("Button7", Button7.ToString());
            PlayerPrefs.SetString("Button8", Button8.ToString());
            PlayerPrefs.SetString("Button9", Button9.ToString());
            PlayerPrefs.SetString("Button1Power", Button1Power.ToString());
            PlayerPrefs.SetString("Button1PowerPS", Button1PowerPS.ToString());
            PlayerPrefs.SetString("Button2Power", Button2Power.ToString());
            PlayerPrefs.SetString("Button3Power", Button3Power.ToString());
            PlayerPrefs.SetString("Button4Power", Button4Power.ToString());
            PlayerPrefs.SetString("Button5Power", Button5Power.ToString());
            PlayerPrefs.SetString("Button6Power", Button6Power.ToString());
            PlayerPrefs.SetString("Button7Power", Button7Power.ToString());
            PlayerPrefs.SetString("Button8Power", Button8Power.ToString());
            PlayerPrefs.SetString("Button9Power", Button9Power.ToString());
            tempo = 0;
        }
        #endregion
    }

    #region Buttons
    public void MainButtonPush(){
		size = 0.8f;
		Bitcoins += Button1Power + (BitPerSec/100)*Button0Power;
	}

	public void Button1Button(){
        Button1LVL++;
        //Button1Power += 0.0001m;
        Button1PowerPS = 0.0001m * Button1LVL;
        Bitcoins -= Button1;
        Button1 = Button1 * 1.15m;
        if(Button1LVL == 1) {
            GameObject.FindGameObjectWithTag("UpgradesCS").GetComponent<UpgradesCS>().UpsBool[0] = true;
            for (int i = 13; i < 26; i++) {
                GameObject.FindGameObjectWithTag("UpgradesCS").GetComponent<UpgradesCS>().UpsSave[i] = 1;
            }
            GameObject.FindGameObjectWithTag("UpgradesCS").GetComponent<UpgradesCS>().ResetUpgrades();


        }

    }
	public void Button2Button(){
        Button2LVL++;
        Button2Power = 0.0004m * Button2LVL;        
        Bitcoins -= Button2;
        Button2 = Button2 * 1.15m;
        if (Button2LVL == 1)
        {
            GameObject.FindGameObjectWithTag("UpgradesCS").GetComponent<UpgradesCS>().UpsBool[1] = true;
            for (int i = 26; i < 39; i++)
            {
                GameObject.FindGameObjectWithTag("UpgradesCS").GetComponent<UpgradesCS>().UpsSave[i] = 1;
            }
            GameObject.FindGameObjectWithTag("UpgradesCS").GetComponent<UpgradesCS>().ResetUpgrades();

        }
    }
	public void Button3Button(){
        Button3LVL++;       
        Button3Power = 0.0016m * Button3LVL;        
        Bitcoins -= Button3;
        Button3 = Button3 * 1.15m;
        if (Button3LVL == 1)
        {
            GameObject.FindGameObjectWithTag("UpgradesCS").GetComponent<UpgradesCS>().UpsBool[2] = true;
            for (int i = 39; i < 52; i++)
            {
                GameObject.FindGameObjectWithTag("UpgradesCS").GetComponent<UpgradesCS>().UpsSave[i] = 1;
            }
            GameObject.FindGameObjectWithTag("UpgradesCS").GetComponent<UpgradesCS>().ResetUpgrades();

        }
    }
	public void Button4Button(){
        Button4LVL++;        
        Button4Power = 0.0064m * Button4LVL;
        Bitcoins -= Button4;
        Button4 = Button4 * 1.15m;
        if (Button4LVL == 1)
        {
            GameObject.FindGameObjectWithTag("UpgradesCS").GetComponent<UpgradesCS>().UpsBool[3] = true;
            for (int i = 52; i < 65; i++)
            {
                GameObject.FindGameObjectWithTag("UpgradesCS").GetComponent<UpgradesCS>().UpsSave[i] = 1;
            }
            GameObject.FindGameObjectWithTag("UpgradesCS").GetComponent<UpgradesCS>().ResetUpgrades();

        }
    }
    public void Button5Button()
    {
        Button5LVL++;
        Button5Power = 0.0128m * Button5LVL;
        Bitcoins -= Button5;
        Button5 = Button5 * 1.15m;
        if (Button5LVL == 1)
        {
            GameObject.FindGameObjectWithTag("UpgradesCS").GetComponent<UpgradesCS>().UpsBool[4] = true;
            for (int i = 65; i < 78; i++)
            {
                GameObject.FindGameObjectWithTag("UpgradesCS").GetComponent<UpgradesCS>().UpsSave[i] = 1;
            }
            GameObject.FindGameObjectWithTag("UpgradesCS").GetComponent<UpgradesCS>().ResetUpgrades();

        }
    }
    public void Button6Button()
    {
        Button6LVL++;
        Button6Power = 0.0512m * Button6LVL;
        Bitcoins -= Button6;
        Button6 = Button6 * 1.15m;
        if (Button6LVL == 1)
        {
            GameObject.FindGameObjectWithTag("UpgradesCS").GetComponent<UpgradesCS>().UpsBool[5] = true;
            for (int i = 78; i < 91; i++)
            {
                GameObject.FindGameObjectWithTag("UpgradesCS").GetComponent<UpgradesCS>().UpsSave[i] = 1;
            }
            GameObject.FindGameObjectWithTag("UpgradesCS").GetComponent<UpgradesCS>().ResetUpgrades();

        }
    }
    public void Button7Button()
    {
        Button7LVL++;
        Button7Power = 0.2048m * Button7LVL;
        Bitcoins -= Button7;
        Button7 = Button7 * 1.15m;
        if (Button7LVL == 1)
        {
            GameObject.FindGameObjectWithTag("UpgradesCS").GetComponent<UpgradesCS>().UpsBool[6] = true;
            for (int i = 91; i < 104; i++)
            {
                GameObject.FindGameObjectWithTag("UpgradesCS").GetComponent<UpgradesCS>().UpsSave[i] = 1;
            }
            GameObject.FindGameObjectWithTag("UpgradesCS").GetComponent<UpgradesCS>().ResetUpgrades();

        }
    }
    public void Button8Button()
    {
        Button8LVL++;
        Button8Power = 0.8192m * Button8LVL;
        Bitcoins -= Button8;
        Button8 = Button8 * 1.15m;
        if (Button8LVL == 1)
        {
            GameObject.FindGameObjectWithTag("UpgradesCS").GetComponent<UpgradesCS>().UpsBool[7] = true;
            for (int i = 104; i < 117; i++)
            {
                GameObject.FindGameObjectWithTag("UpgradesCS").GetComponent<UpgradesCS>().UpsSave[i] = 1;
            }
            GameObject.FindGameObjectWithTag("UpgradesCS").GetComponent<UpgradesCS>().ResetUpgrades();

        }
    }
    public void Button9Button()
    {
        Button9LVL++;
        Button9Power = 3.2768m * Button9LVL;
        Bitcoins -= Button9;
        Button9 = Button9 * 1.15m;
        if (Button9LVL == 1)
        {            
            GameObject.FindGameObjectWithTag("UpgradesCS").GetComponent<UpgradesCS>().UpsBool[8] = true;            
            for (int i = 117; i < 130; i++)
            {
                GameObject.FindGameObjectWithTag("UpgradesCS").GetComponent<UpgradesCS>().UpsSave[i] = 1;
            }
            GameObject.FindGameObjectWithTag("UpgradesCS").GetComponent<UpgradesCS>().ResetUpgrades();
        }
    }

    #endregion

    #region Ads
    public void RewardedAdsButton()
    {

        if (UnityEngine.Advertisements.Advertisement.IsReady("rewardedVideo")){
            UnityEngine.Advertisements.Advertisement.Show("rewardedVideo");
            
        }

    }
    #endregion
}
