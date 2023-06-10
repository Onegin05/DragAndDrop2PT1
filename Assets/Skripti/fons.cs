using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fons : MonoBehaviour {

	public void UzSakumu(){
		SceneManager.LoadScene ("sakum menu", LoadSceneMode.Single); // Ielādē "sakum menu" scēnu, izmantojot Unity sēžu pārvaldības funkciju "LoadScene", ar LoadSceneMode.Single režīmu, kas aizvieto esošo scēnu.
	}
	public void PilsetasKarte(){
		
		SceneManager.LoadScene ("PilsetasKarte", LoadSceneMode.Single); // elādē "PilsetasKarte" scēnu, izmantojot Unity sēžu pārvaldības funkciju "LoadScene", ar LoadSceneMode.Single režīmu, kas aizvieto esošo scēnu.
	}

	public void Apturet(){
		Application.Quit (); // Aizver spēli, izmantojot Unity lietojumprogrammu pārvaldības funkciju "Quit".
	}
}