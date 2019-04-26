using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {
	private GameObject scoreText;
	private int score = 0;


	// Use this for initialization
	void Start () {
		this.scoreText = GameObject.Find("Score");
	}

	void OnCollisionEnter(Collision collision) {

		string textscore = this.score.ToString();
		
		if (collision.gameObject.tag == "SmallStarTag") {
			//スコア処理を追加
			this.score +=1;
			this.scoreText.GetComponent<Text>().text= textscore;

		}
		if (collision.gameObject.tag == "LargeStarTag") {
			//スコア処理を追加
			this.score +=5;
			this.scoreText.GetComponent<Text>().text= textscore;

		}
		if (collision.gameObject.tag == "SmallCloudTag") {
			//スコア処理を追加
			this.score +=10;
			this.scoreText.GetComponent<Text>().text= textscore;

		}
		if (collision.gameObject.tag == "LargeCloudTag") {
			//スコア処理を追加
			this.score +=20;
			this.scoreText.GetComponent<Text>().text= textscore;

		}
	}


	
	// Update is called once per frame
	void Update () {
		
	}
}
