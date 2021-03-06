﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class MainPlayerController : MonoBehaviour {
	public float speed;

	public GameObject newjobtext;
	public GameObject newhousetext;
	public GameObject vacationtext1;
	public GameObject vacationtext2;
	public GameObject retirement1text;
	public GameObject retirement2text;
	public GameObject retirement3text;
	public GameObject StartCard;
	public GameObject CheckBox1;
	public GameObject CheckBox2;
	public GameObject CheckBox3;
	public GameObject Movie;
    public GameObject houseparticles1;
    public GameObject houseparticles2;
    public GameObject strobelight;
    public GameObject retire;
    public GameObject BuyHousePrompt;

    public Vector3 offset;
	public Vector3 highttext;
	public Vector3 midtext;
	public Vector3 startCardOffset;
	public Vector3 CheckBox1Offset;

    public AudioSource cantafford;
	public AudioSource canafford;
	public AudioSource vacation;
	public AudioSource cantretire;
	public AudioSource checkboxsound;
    public AudioSource housePartyMusic;
    public AudioSource housePartyVoices;

    public BetterController controller;




    //	public AudioSource textsound;
    //	public float Volume;




    private Rigidbody rb;
	private int count;

	public GameManager gameManager;

	void Start()
	{ 
		rb = GetComponent<Rigidbody>();

	}

    void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal"); 
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		
		rb.AddForce (movement * speed);
	}

	void LateUpdate()
	{
		newjobtext.transform.position = (rb.transform.position) + offset;
		newhousetext.transform.position = (rb.transform.position) + offset;
		vacationtext1.transform.position = (rb.transform.position) + midtext;
		vacationtext2.transform.position = (rb.transform.position) + offset;
		retirement1text.transform.position = (rb.transform.position) + highttext;
		retirement2text.transform.position = (rb.transform.position) + midtext;
		retirement3text.transform.position = (rb.transform.position) + offset;
		StartCard.transform.position = (rb.transform.position) + startCardOffset;
		//CheckBox1.transform.position = (rb.transform.position) + CheckBox1Offset;
		//CheckBox2.transform.position = (rb.transform.position) + CheckBox1Offset;
		//CheckBox3.transform.position = (rb.transform.position) + CheckBox1Offset;


	}
		

	void OnTriggerEnter(Collider other) 
		{



		if (other.gameObject.CompareTag ("Starting Stats")) 
		{	
			StartCard.SetActive (true);
		}

		if (other.gameObject.CompareTag ("checkbox1")) 
		{	
			CheckBox1.SetActive (true);
		}

		if (other.gameObject.CompareTag ("checkbox2")) 
		{	
			checkboxsound.Play();
			CheckBox1.SetActive (false);
			CheckBox2.SetActive (true);
		}

		if (other.gameObject.CompareTag ("checkbox3")) 
		{	
			checkboxsound.Play();
			CheckBox2.SetActive (false);
			CheckBox3.SetActive (true);
		}


		if (other.gameObject.CompareTag ("newjobtexttrigger")) 
			
		{	
			
			AudioSource audio = GetComponent<AudioSource> ();
			audio.Play ();
			newjobtext.SetActive (true);

		}

		if (other.gameObject.CompareTag ("Housing")) 
		{	
			AudioSource audio = GetComponent<AudioSource> ();
			audio.Play ();
			newhousetext.SetActive (true);
		}

		if (other.gameObject.CompareTag ("Vacation")) 
		{	
			AudioSource audio = GetComponent<AudioSource> ();
			audio.Play ();
			vacationtext1.SetActive (true);
			vacationtext2.SetActive (true);
		}

        if (other.gameObject.CompareTag("vacationexit"))
        {
            CheckBox2.SetActive(true);
        }


        if (other.gameObject.CompareTag ("Retirement Party")) 
		{	
			AudioSource audio = GetComponent<AudioSource> ();
			audio.Play ();
			retirement1text.SetActive (true);

		}

		if (other.gameObject.CompareTag ("Retirement2")) 
			
		{	
			AudioSource audio = GetComponent<AudioSource> ();
			audio.Play ();
			retirement2text.SetActive (true);

		}

		if (other.gameObject.CompareTag ("Retirement3")) 
		{	
			AudioSource audio = GetComponent<AudioSource> ();
			audio.Play ();
			retirement3text.SetActive (true);

		}
   

		if (other.gameObject.CompareTag ("Movie")) 
		{
            CheckBox3.SetActive(false);
			Movie.SetActive (true);
		}

        if (other.gameObject.CompareTag("Cant Retire"))
        {
            retire.SetActive(true);
        }

        if (other.gameObject.CompareTag("Buy House"))
        {
            BuyHousePrompt.SetActive(true);
        }

        if (other.gameObject.CompareTag ("House Party")) 
	    {
            houseparticles1.SetActive(true);
            houseparticles2.SetActive(true);
            strobelight.SetActive(true);
            housePartyVoices.Play();
            housePartyMusic.Play();
	    }

        if (other.gameObject.CompareTag("Bought House"))
        {
             canafford.Play();

        }

        if (other.gameObject.CompareTag("Your Vacation"))
        {
                vacation.Play();
        }
    }

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.CompareTag ("Starting Stats")) {	
			StartCard.SetActive (false);
		}

		if (other.gameObject.CompareTag ("newjobtexttrigger")) {	
			newjobtext.SetActive (false);
		}

		if (other.gameObject.CompareTag ("Housing")) {	
			newhousetext.SetActive (false);
		}

		if (other.gameObject.CompareTag ("Vacation")) {	
			vacationtext1.SetActive (false);
			vacationtext2.SetActive (false);
            CheckBox2.SetActive (false); 
		}

        if (other.gameObject.CompareTag("vacation2enter"))
        {
            CheckBox2.SetActive(false);
        }

        if (other.gameObject.CompareTag ("Retirement3")) {	
			retirement1text.SetActive (false);
			retirement2text.SetActive (false);
			retirement3text.SetActive (false);
		}

		if (other.gameObject.CompareTag ("Retirement")) {	
			retirement2text.SetActive (false);
		}

		if (other.gameObject.CompareTag ("End Game")) {	
			gameManager.GameOver ();
			//gameManager.GameOver();
		}

        if (other.gameObject.CompareTag("House Party"))
        {
            houseparticles1.SetActive(false);
            houseparticles2.SetActive(false);
            strobelight.SetActive(false);
            housePartyVoices.Stop();
            housePartyMusic.Stop();
        }

    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Buy House"))
        {

            if (controller.device.GetPressUp(SteamVR_Controller.ButtonMask.Trigger))
            {
                cantafford.Play();
            }

        }

		if (other.gameObject.CompareTag("Cant Retire"))
		{

			if (controller.device.GetPressUp(SteamVR_Controller.ButtonMask.Trigger))
			{
				cantretire.Play();
	
			}

		}
    }
}

