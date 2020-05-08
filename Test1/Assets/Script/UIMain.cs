using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
public class UIMain : MonoBehaviour
{
	//主介面中呼叫介面的按鈕
	private GameObject Btn1;
	private GameObject Btn2;
	private GameObject Btn3;
	private GameObject Btn4;
	private GameObject Btn5;
	private GameObject Btn6;
	private GameObject Btn7;
	private GameObject Btn8;
	private GameObject Btn9;
	private GameObject Btn10;
	private GameObject Btn11;
	private GameObject Btn12;
	private GameObject Btn13;
	private GameObject Btn14;

	//彈出介面的關閉按鈕
	private GameObject Btn1c;
	private GameObject Btn2c;
	private GameObject Btn3c;
	private GameObject Btn4c;
	private GameObject Btn5c;
	private GameObject Btn6c;
	private GameObject Btn7c;
	private GameObject Btn8c;
	private GameObject Btn9c;
	private GameObject Btn10c;
	private GameObject Btn11c;
	private GameObject Btn12c;
	private GameObject Btn13c;
	private GameObject Btn14c;

	
	void Start()
	{
		Btn1 = GameObject.Find("Canvas/PanelMain/Btn1");
		Btn2 = GameObject.Find("Canvas/PanelMain/Btn2");
		Btn3 = GameObject.Find("Canvas/PanelMain/Btn3");
		Btn4 = GameObject.Find("Canvas/PanelMain/Btn4");
		Btn5 = GameObject.Find("Canvas/PanelMain/Btn5");
		Btn6 = GameObject.Find("Canvas/PanelMain/Btn6");
		Btn7 = GameObject.Find("Canvas/PanelMain/Btn7");
		Btn8 = GameObject.Find("Canvas/PanelMain/Btn8");
		Btn9 = GameObject.Find("Canvas/PanelMain/Btn9");
		Btn10 = GameObject.Find("Canvas/PanelMain/Btn10");
		Btn11 = GameObject.Find("Canvas/PanelMain/Btn11");
		Btn12 = GameObject.Find("Canvas/PanelMain/Btn12");
		Btn13 = GameObject.Find("Canvas/PanelMain/Btn13");
		Btn14 = GameObject.Find("Canvas/PanelMain/Btn14");

		EventTriggerListener.Get(Btn1).onUp += OnUp;
		EventTriggerListener.Get(Btn2).onUp += OnUp;
		EventTriggerListener.Get(Btn3).onUp += OnUp;
		EventTriggerListener.Get(Btn4).onUp += OnUp;
		EventTriggerListener.Get(Btn5).onUp += OnUp;
		EventTriggerListener.Get(Btn6).onUp += OnUp;
		EventTriggerListener.Get(Btn7).onUp += OnUp;
		EventTriggerListener.Get(Btn8).onUp += OnUp;
		EventTriggerListener.Get(Btn9).onUp += OnUp;
		EventTriggerListener.Get(Btn10).onUp += OnUp;
		EventTriggerListener.Get(Btn11).onUp += OnUp;
		EventTriggerListener.Get(Btn12).onUp += OnUp;
		EventTriggerListener.Get(Btn13).onUp += OnUp;
		EventTriggerListener.Get(Btn14).onUp += OnUp;


	}

	private void OnUp(GameObject Btn)
	{
		switch (Btn.name)
		{
			case "Btn1":
				UIManager.Instance.ShowPanel("Panel1");
				Btn1c = GameObject.Find("Canvas/Panel1/Btn1c");
				EventTriggerListener.Get(Btn1c).onUp += OnUp;
				break;
			case "Btn2":
				UIManager.Instance.ShowPanel("Panel2");
				Btn2c = GameObject.Find("Canvas/Panel2/Btn2c");
				EventTriggerListener.Get(Btn2c).onUp += OnUp;
				break;
			case "Btn3":
				UIManager.Instance.ShowPanel("Panel3");
				Btn3c = GameObject.Find("Canvas/Panel3/Btn3c");
				EventTriggerListener.Get(Btn3c).onUp += OnUp;
				break;
			case "Btn4":
				UIManager.Instance.ShowPanel("Panel4");
				Btn4c = GameObject.Find("Canvas/Panel4/Btn4c");
				EventTriggerListener.Get(Btn4c).onUp += OnUp;
				break;
			case "Btn5":
				UIManager.Instance.ShowPanel("Panel5");
				Btn5c = GameObject.Find("Canvas/Panel5/Btn5c");
				EventTriggerListener.Get(Btn5c).onUp += OnUp;
				break;
			case "Btn6":
				UIManager.Instance.ShowPanel("Panel6");
				Btn6c = GameObject.Find("Canvas/Panel6/Btn6c");
				EventTriggerListener.Get(Btn6c).onUp += OnUp;
				break;
			case "Btn7":
				UIManager.Instance.ShowPanel("Panel7");
				Btn7c = GameObject.Find("Canvas/Panel7/Btn7c");
				EventTriggerListener.Get(Btn7c).onUp += OnUp;
				break;
			case "Btn8":
				UIManager.Instance.ShowPanel("Panel8");
				Btn8c = GameObject.Find("Canvas/Panel8/Btn8c");
				EventTriggerListener.Get(Btn8c).onUp += OnUp;
				break;
			case "Btn9":
				UIManager.Instance.ShowPanel("Panel9");
				Btn9c = GameObject.Find("Canvas/Panel9/Btn9c");
				EventTriggerListener.Get(Btn9c).onUp += OnUp;
				break;
			case "Btn10":
				UIManager.Instance.ShowPanel("Panel10");
				Btn10c = GameObject.Find("Canvas/Panel10/Btn10c");
				EventTriggerListener.Get(Btn10c).onUp += OnUp;
				break;
			case "Btn11":
				UIManager.Instance.ShowPanel("Panel11");
				Btn11c = GameObject.Find("Canvas/Panel11/Btn11c");
				EventTriggerListener.Get(Btn11c).onUp += OnUp;
				break;
			case "Btn12":
				UIManager.Instance.ShowPanel("Panel12");
				Btn12c = GameObject.Find("Canvas/Panel12/Btn12c");
				EventTriggerListener.Get(Btn12c).onUp += OnUp;
				break;
			case "Btn13":
				UIManager.Instance.ShowPanel("Panel13");
				Btn13c = GameObject.Find("Canvas/Panel13/Btn13c");
				EventTriggerListener.Get(Btn13c).onUp += OnUp;
				break;
			case "Btn14":
				UIManager.Instance.ShowPanel("Panel14");
				Btn14c = GameObject.Find("Canvas/Panel14/Btn14c");
				EventTriggerListener.Get(Btn14c).onUp += OnUp;
				break;

			case "Btn1c":
				UIManager.Instance.ClosePanel("Panel1");
				break;
			case "Btn2c":
				UIManager.Instance.ClosePanel("Panel2");
				break;
			case "Btn3c":
				UIManager.Instance.ClosePanel("Panel3");
				break;
			case "Btn4c":
				UIManager.Instance.ClosePanel("Panel4");
				break;
			case "Btn5c":
				UIManager.Instance.ClosePanel("Panel5");
				break;
			case "Btn6c":
				UIManager.Instance.ClosePanel("Panel6");
				break;
			case "Btn7c":
				UIManager.Instance.ClosePanel("Panel7");
				break;
			case "Btn8c":
				UIManager.Instance.ClosePanel("Panel8");
				break;
			case "Btn9c":
				UIManager.Instance.ClosePanel("Panel9");
				break;
			case "Btn10c":
				UIManager.Instance.ClosePanel("Panel10");
				break;
			case "Btn11c":
				UIManager.Instance.ClosePanel("Panel11");
				break;
			case "Btn12c":
				UIManager.Instance.ClosePanel("Panel12");
				break;
			case "Btn13c":
				UIManager.Instance.ClosePanel("Panel13");
				break;
			case "Btn14c":
				UIManager.Instance.ClosePanel("Panel14");
				break;
			default:
				Debug.LogError("沒這按鈕");
				break;
		}

	}

	}
