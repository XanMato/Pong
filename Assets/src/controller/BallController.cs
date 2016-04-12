using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BallController : MonoBehaviour
{

	int speedX = 0;
	int speedY = 0;
	int leftScoreCount = 0;
	int rigthScoreCount = 0;
    
	public int speedA;
	public int speedB;
	public GameObject goalLeft;
	public GameObject goalRigth;
	public Text leftScore;
	public Text rigthScore;

	// Use this for initialization
	void Start ()
	{       

		speedX = Random.Range (0, 2) == 0 ? 1 : -1;
		speedY = Random.Range (0, 2) == 0 ? 1 : -1;
		leftScore.text = "0";
		rigthScore.text = "0";


		GetComponent<Rigidbody> ().velocity = new Vector3 (Random.Range (speedA, speedB) * speedX, Random.Range (speedA, speedB) * speedY, 0);
	}
	
	// Update is called once per frame
	void Update ()
	{	
	}

	void OnCollisionEnter (Collision collision)
	{

		//Debug.Log ("The ball has collisions xO");

		if (goalLeft != null && goalRigth != null) {
			if (collision.gameObject.Equals (goalLeft)) {
				rigthScoreCount++;
				rigthScore.text = rigthScoreCount.ToString();
				Debug.Log ("puntuacion rigth: " + rigthScoreCount);
				reset ();
			} else if (collision.gameObject.Equals (goalRigth)) {
				leftScoreCount++;
				leftScore.text = leftScoreCount.ToString();
				Debug.Log ("puntuacion left: " + leftScoreCount);
				reset ();
			}
		} else {
			Debug.LogError ("Miss goals... ");
		}
	}
	void reset(){
		
		//Time.timeScale = 0; //esto no funciona en una collision
		PauseController.pause = true; //dentro de un update si lo hace
		//OTRAS FORMAS DE PARAR LA BOLA
		//GetComponent<Rigidbody> ().velocity = Vector3.zero;
		//transform.position = new Vector3 (0,0,0);
	}
}
