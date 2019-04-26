using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {
	private int score = 0;
	private GameObject scoreText;



	// Use this for initialization


	void OnCollisionEnter(Collision collision) {


		
		if (collision.gameObject.tag == "SmallStarTag") {
			//スコア処理を追加
			this.score +=1;
			string textscore = this.score.ToString();
			this.scoreText.GetComponent<Text>().text= textscore;

		}
		if (collision.gameObject.tag == "LargeStarTag") {
			//スコア処理を追加
			this.score +=5;
			string textscore = this.score.ToString();
			this.scoreText.GetComponent<Text>().text= textscore;

		}
		if (collision.gameObject.tag == "SmallCloudTag") {
			//スコア処理を追加
			this.score +=10;
			string textscore = this.score.ToString();
			this.scoreText.GetComponent<Text>().text= textscore;

		}
		if (collision.gameObject.tag == "LargeCloudTag") {
			//スコア処理を追加
			this.score +=20;
			string textscore = this.score.ToString();
			this.scoreText.GetComponent<Text>().text= textscore;

		}

	}

	void Start () {
		this.scoreText = GameObject.Find("Score");
	}


	
	// Update is called once per frame
	void Update () {
		
	}
}
