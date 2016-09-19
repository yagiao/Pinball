using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class touchButton : MonoBehaviour {
	
	//HingiJointコンポーネントを入れる
	private HingeJoint myHingeJoynt;

	//初期の傾き
	private float defaultAngle = 20;
	//弾いた時の傾き
	private float flickAngle = -20;
	//左判定
	private bool isLButtonDown = false;
	//右判定
	private bool isRButtonDown = false;


	// Use this for initialization
	void Start () {
		//HinjiJointコンポーネント取得
		this.myHingeJoynt = GetComponent<HingeJoint>();

		//フリッパーの傾きを設定
		SetAngle(this.defaultAngle);
	}
	

	
	// Update is called once per frame
	void Update () {

		// 左のフリッパー
		if( tag == "LeftFripperTag") {
			// 左矢印か左のボタンが押されたらフリッパーを動かす
			if ((Input.GetKeyDown(KeyCode.LeftArrow) || this.isLButtonDown) ) {
				SetAngle (this.flickAngle);
			}
			// 左矢印も左のボタンも押されていなければフリッパーを戻す
			if (!Input.GetKey(KeyCode.LeftArrow) && !this.isLButtonDown ) {
				SetAngle (this.defaultAngle);
			}
		}
		// 右のフリッパー
		if( tag == "RightFripperTag") {
			// 左矢印か左のボタンが押されたらフリッパーを動かす
			if ((Input.GetKeyDown(KeyCode.RightArrow) || this.isRButtonDown) ) {
				SetAngle (this.flickAngle);
			}
			// 左矢印も左のボタンも押されていなければフリッパーを戻す
			if (!Input.GetKey(KeyCode.RightArrow) && !this.isRButtonDown ) {
				SetAngle (this.defaultAngle);
			}
		}
	}

	//左ボタンを押し続けた場合の処理
	public void GetMyLeftButtonDown() {
		this.isLButtonDown = true;
	}
	//左ボタンを離した場合の処理
	public void GetMyLeftButtonUp() {
		this.isLButtonDown = false;
	}

	//右ボタンを押し続けた場合の処理
	public void GetMyRightButtonDown() {
		this.isRButtonDown = true;
	}
	//右ボタンを離した場合の処理
	public void GetMyRightButtonUp() {
		this.isRButtonDown = false;
	}
	//フリッパーの傾きを設定
	public void SetAngle (float angle){
		JointSpring jointSpr = this.myHingeJoynt.spring;
		jointSpr.targetPosition = angle;
		this.myHingeJoynt.spring = jointSpr;
}
}
