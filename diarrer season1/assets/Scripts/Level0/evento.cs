using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class evento : MonoBehaviour {
	//Collider other;
	public GameObject enemigo;
    private Text texto;


	 void sumarContador(){
        int a = 0;
		texto = GameObject.Find ("score").GetComponent<Text> ();
		a = int.Parse(  texto.text.Split (':') [1]);
		Debug.Log (a);
		texto.text = texto.text.Split (':') [0] +":"+ (a + 1);

		}

	 void Start(){

	}


	 void OnMouseDown(){

		    sumarContador ();
			Destroy (gameObject);

		}


	// void OnTriggerEnter2D(Collider2D col){
	//	if(col.tag == "Enemy")
	//	{


	//		Destroy(col.gameObject);


	//	}
	//}
		

}
	
	


