using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Change : MonoBehaviour {



	//GUIDE
	//public void "name the method " (){
	//SceneManager.LoadScene("Name of scene you want to load");
	//}



	//Use this for initialisation
	public void MainLevel(){							//Creates a new method that's called Level1
		SceneManager.LoadScene("MainLevel"); 			//Changes scene to the referenced one
	}


}
