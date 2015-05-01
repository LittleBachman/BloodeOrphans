using UnityEngine;
using System.Collections;

public class click_select : MonoBehaviour 
{
	// References to game controller script
	private master_script master_script;

	public AudioClip wombat1;
	public AudioClip wombat2;
	public AudioClip wombat3;
	public AudioClip wombat4;
	public AudioClip wombat5;
	public AudioClip wombat6;
	public AudioClip wombat7;
	public AudioClip wombat8;
	public AudioClip wombat9;
	public AudioClip wombat10;

	public AudioClip feman1;
	public AudioClip feman2;
	public AudioClip feman3;
	public AudioClip feman4;
	public AudioClip feman5;
	public AudioClip feman6;

	public AudioClip orphans1;
	public AudioClip orphans2;
	public AudioClip orphans3;

	private int W = 1;
	private int F = 1;
	private int R = 1;

	// Use this for initialization
	void Start () 
	{
		// Find and initialize game controller script so it can be referenced later
		master_script = GameObject.Find("master_index").GetComponent <master_script> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(master_script.talking == false)
		{
			if (Input.GetMouseButtonDown(0))
			{		
				RaycastHit rayHit2;
				
				if (Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out rayHit2)) 
				{
					if (rayHit2.collider.tag == "wombatman")
					{
						master_script.selected = 0;

						if(!audio.isPlaying && W == 1)
						{
							audio.clip = wombat1;
							audio.Play();
							W = 2;
						}
						else if(!audio.isPlaying && W == 2)
						{
							audio.clip = wombat2;
							audio.Play();
							W = 3;
						}
						else if(!audio.isPlaying && W == 3)
						{
							audio.clip = wombat3;
							audio.Play();
							W = 4;
						}
						else if(!audio.isPlaying && W == 4)
						{
							audio.clip = wombat4;
							audio.Play();
							W = 5;
						}
						else if(!audio.isPlaying && W == 5)
						{
							audio.clip = wombat5;
							audio.Play();
							W = 6;
						}
						else if(!audio.isPlaying && W == 6)
						{
							audio.clip = wombat6;
							audio.Play();
							W = 7;
						}
						else if(!audio.isPlaying && W == 7)
						{
							audio.clip = wombat7;
							audio.Play();
							W = 8;
						}
						else if(!audio.isPlaying && W == 8)
						{
							audio.clip = wombat8;
							audio.Play();
							W = 9;
						}
						else if(!audio.isPlaying && W == 9)
						{
							audio.clip = wombat9;
							audio.Play();
							W = 10;
						}
						else if(!audio.isPlaying && W == 10)
						{
							audio.clip = wombat10;
							audio.Play();
							W = 1;
						}
					}
					if (rayHit2.collider.tag == "fe_man")
					{
						master_script.selected = 1;

						if(!audio.isPlaying && F == 1)
						{
							audio.clip = feman1;
							audio.Play();
							F = 2;
						}
						else if(!audio.isPlaying && F == 2)
						{
							audio.clip = feman2;
							audio.Play();
							F = 3;
						}
						else if(!audio.isPlaying && F == 3)
						{
							audio.clip = feman3;
							audio.Play();
							F = 4;
						}
						else if(!audio.isPlaying && F == 4)
						{
							audio.clip = feman4;
							audio.Play();
							F = 5;
						}
						else if(!audio.isPlaying && F == 5)
						{
							audio.clip = feman5;
							audio.Play();
							F = 6;
						}
						else if(!audio.isPlaying && F == 6)
						{
							audio.clip = feman6;
							audio.Play();
							F = 1;
						}
					}
					if (rayHit2.collider.tag == "R_unit1" || rayHit2.collider.tag == "R_unit2" || rayHit2.collider.tag == "R_unit3")
					{
						if(!audio.isPlaying && R == 1)
						{
							audio.clip = orphans1;
							audio.Play();
							R = 2;
						}
						else if(!audio.isPlaying && R == 2)
						{
							audio.clip = orphans2;
							audio.Play();
							R = 3;
						}
						else if(!audio.isPlaying && R == 3)
						{
							audio.clip = orphans3;
							audio.Play();
							R = 1;
						}
					}
					if (rayHit2.collider.tag == "R_unit1")
					{
						master_script.selected = 2;
					}
					if (rayHit2.collider.tag == "R_unit2")
					{
						master_script.selected = 3;
					}
					if (rayHit2.collider.tag == "R_unit3")
					{
						master_script.selected = 4;
					}

				}
			}
		}
	}
}
