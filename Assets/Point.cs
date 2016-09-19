using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Point : MonoBehaviour {
	
	private GameObject pointText;
	//初期ポイント
	private int Pointgage = 0;
	//小さい星ポイント 
	private int SmallStarPoint = 10;
	//小さい雲ポイント
	private int SmallCloudPoint = 20;
	//大きい星ポイント
	private int LargeStarpoint = 50;
	//大きい雲ポイント
	private int LargeCloudPoint = 100;


	// Use this for initialization
	void Start () {
		this.pointText = GameObject.Find("pointText");
	}
	// Update is called once per frame
	void Update () {
			this.pointText.GetComponent<Text> ().text = "Point " + Pointgage.ToString();

		}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "SmallStarTag") {
			this.Pointgage += SmallStarPoint;
		} else if (col.gameObject.tag == "LargeStarTag") {
			this.Pointgage += LargeStarpoint;
		} else if (col.gameObject.tag == "SmallCloudTag") {
			this.Pointgage += SmallCloudPoint;
		} else if (col.gameObject.tag == "LargeCloudTag") {
			this.Pointgage += LargeCloudPoint;
		}
	}
}
