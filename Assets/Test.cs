﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test : MonoBehaviour {

	//Use this for initialization
	void Start () {

		//要素数5の配列を初期化する
	int[] array = new int[5];

	//配列の各要素に値を代入する
	array [0] = 30;
	array [1] = 10;
	array [2] = 25;
	array [3] = 40;
	array [4] = 55;

	//配列の要素を全て表示する
	for (int i = 4; i >= 0 ; i--) {
		Debug.Log (array [i]);
	}
}
		
	// Update is called once per frame
	void Update () {
		
	}
}
