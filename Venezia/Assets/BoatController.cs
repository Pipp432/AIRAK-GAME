using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoatController : MonoBehaviour
{
	public float moveSpeed = 1.0f;
	public float turnSpeed = 1.0f;
    public Text coinText;
    //public Text shopText;
    public Text winText;
    private int coinTotal;
    private int keyTotal;
    private int plushTotal;
	    // Start is called before the first frame update
    void Start()
    {
       print("Welcome to Venezia");
       GameObject[] coinArray = GameObject.FindGameObjectsWithTag("Coin");
       coinTotal = 0;
       keyTotal = 0;
       plushTotal = 0;
        //Might change this later
       //coinTotal = coinArray.Length;
       coinText.text = "เก็บเหรียญได้: " + coinTotal;
       //shopText.text = "";
       winText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
        	this.transform.position = 
        	this.transform.position + this.transform.localRotation*Vector3.forward*moveSpeed;

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
        	this.transform.position = 
        	this.transform.position - this.transform.localRotation*Vector3.forward*moveSpeed;

        }

        if (Input.GetKey(KeyCode.LeftArrow)){
        	this.transform.localRotation = 
        	Quaternion.Euler(0,-turnSpeed,0)*this.transform.localRotation;
        }
        if (Input.GetKey(KeyCode.RightArrow)){
        	this.transform.localRotation = 
        	Quaternion.Euler(0,turnSpeed,0)*this.transform.localRotation;
        }
       
    }
    void OnCollisionEnter(Collision col)
    {
    	
    	if (col.gameObject.tag == "Coin"){
    		Destroy(col.gameObject);
            
            coinTotal += 1;
            coinText.text = "เก็บเหรียญได้: " + coinTotal;
    	}
    	if (col.gameObject.tag == "Key"){
    		Destroy(col.gameObject);

            keyTotal += 1;
           // speedPickup ();
    	}
    	if (col.gameObject.tag == "Plush"){
    		Destroy(col.gameObject);

            plushTotal += 1;
    	}
        if (col.gameObject.tag == "Lion" && keyTotal>= 1){
            //shopText.text = "Press Space after get key and all coins";
            if (Input.GetKeyDown("space")&& coinTotal >= 4) {
    		//shopText.text = "You Win!";
            }
 
    	}

        if (col.gameObject.tag == "DeliveryPier" && plushTotal>= 1){
            GameObject.Find("BoatModel").SendMessage("Finnish");
            winText.text = "You win:)";
            
 
    	}
        
    }
   // void speedPickup ()
    //    {
    //        moveSpeed += 10;
    //        yield WaitForSeconds (1);
    //        moveSpeed -= 10;
    //    }

}
