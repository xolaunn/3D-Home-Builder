﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Sahnegecis : MonoBehaviour

{
	public void Sahnedegistir(int sahne_id) {
		SceneManager.LoadScene(sahne_id);
	}
}
