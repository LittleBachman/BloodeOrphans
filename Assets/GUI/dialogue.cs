using UnityEngine;
using System.Collections;

public class dialogue : MonoBehaviour 
{
	public Texture2D text1;
	public Texture2D text2;
	public Texture2D text3;
	public Texture2D text4;
	public Texture2D text5;
	public Texture2D text6;
	public Texture2D text7;
	public Texture2D text8;
	public Texture2D text9;
	public Texture2D text10;
	public Texture2D text11;
	public Texture2D text12;
	public Texture2D text13;
	public Texture2D text14;
	public Texture2D text15;

	public GameObject door;

	public Texture2D text_snakes;

	static public Rect basic;

	public int current_dialogue = 0;

	public AudioClip dialogue1;
	public AudioClip dialogue2;
	public AudioClip dialogue3;
	public AudioClip dialogue4;
	public AudioClip dialogue5;
	public AudioClip dialogue6;
	public AudioClip dialogue7;
	public AudioClip dialogue8;
	public AudioClip dialogue9;
	public AudioClip dialogue10;
	public AudioClip dialogue11;
	public AudioClip dialogue12;
	public AudioClip dialogue13;
	public AudioClip dialogue14;
	public AudioClip dialogue15;

	public AudioClip dialogue_snakes;

	//upstairs dialogue
	public Texture2D text_finish_searching;
	public Texture2D text_must_be_upstairs;
	public AudioClip dialogue_finish_searching;
	public AudioClip dialogue_must_be_upstairs;
	
	public int x = 1;
	private int i = 1;

	// References to game controller script
	private master_script master_script;
	
	// Use this for initialization
	void Start () 
	{
		// Find and initialize game controller script so it can be referenced later
		master_script = GameObject.Find("master_index").GetComponent <master_script> ();
		
		basic = new Rect(0f, 0f, Screen.width,Screen.height);
	}

	void OnGUI () 
	{
	//trying to go upstairs the first time without all enemies being dead
		if(master_script.keep_searching_prompt == true)
		{
			if(current_dialogue == 16 && master_script.talking == true)
			{
				if(!audio.isPlaying && i == 1)
				{
					audio.clip = dialogue_finish_searching;
					audio.Play();
					i = 2;
				}
				
				if(!audio.isPlaying && i == 2)
				{
					current_dialogue++;
					master_script.keep_searching_prompt = false;
					master_script.talking = false;
					i = 1;
				}
				else
				{
					GUI.DrawTexture (basic, text_finish_searching);
				}
			}
		}

		//all enemies are dead
		if(master_script.go_upstairs_prompt == true)
		{
			if(master_script.enemies_dead >= 12)
			{
				if(!audio.isPlaying && i == 1)
				{
					audio.clip = dialogue_must_be_upstairs;
					audio.Play();
					i = 2;
				}
				
				if(!audio.isPlaying && i == 2)
				{
					master_script.go_upstairs_prompt = false;
					master_script.talking = false;
				}
				else
				{
					GUI.DrawTexture (basic, text_must_be_upstairs);
				}
			}
		}
	//gate talking
		if(master_script.gate == true)
		{
			if(current_dialogue == 1 && master_script.talking == true)
			{
				if(!audio.isPlaying && x == 1)
				{
					audio.clip = dialogue1;
					audio.Play();
					x = 2;
				}

				if(!audio.isPlaying && x == 2)
				{
					current_dialogue++;
				}
				else
				{
					GUI.DrawTexture (basic, text1);
				}
			}
			if(current_dialogue == 2 && master_script.talking == true)
			{
				if(!audio.isPlaying && x == 2)
				{
					audio.clip = dialogue2;
					audio.Play();
					x = 3;
				}
				
				if(!audio.isPlaying && x == 3)
				{
					current_dialogue++;
				}
				else
				{
					GUI.DrawTexture (basic, text2);
				}
			}
			if(current_dialogue == 3 && master_script.talking == true)
			{
				if(!audio.isPlaying && x == 3)
				{
					audio.clip = dialogue3;
					audio.Play();
					x = 4;
				}
				
				if(!audio.isPlaying && x == 4)
				{
					current_dialogue++;
					master_script.gate = false;
					master_script.talking = false;
				}
				else
				{
					GUI.DrawTexture (basic, text3);
				}
			}
		}
		//door
		if(master_script.door == true)
		{
			if(current_dialogue == 4 && master_script.talking == true)
			{
				if(!audio.isPlaying && x == 4)
				{
					audio.clip = dialogue4;
					audio.Play();
					x = 5;
				}
				
				if(!audio.isPlaying && x == 5)
				{
					current_dialogue = 23;
				}
				else
				{
					GUI.DrawTexture (basic, text4);
				}
			}
			if(current_dialogue == 23 && master_script.talking == true)
			{
				if(!audio.isPlaying && x == 5)
				{
					audio.clip = dialogue_snakes;
					audio.Play();
					x = 6;
				}
				
				if(!audio.isPlaying && x == 6)
				{
					master_script.door = false;
					master_script.talking = false;
					current_dialogue = 5;
					x = 5;
				}
				else
				{
					GUI.DrawTexture (basic, text_snakes);
				}
			}
		}

		//Jarvis One
		if(master_script.jarvis1 == true)
		{
			if(current_dialogue == 5 && master_script.talking == true)
			{
				if(!audio.isPlaying && x == 5)
				{
					audio.clip = dialogue5;
					audio.Play();
					x = 6;
				}
				
				if(!audio.isPlaying && x == 6)
				{
					current_dialogue++;
				}
				else
				{
					GUI.DrawTexture (basic, text5);
				}
			}
			if(current_dialogue == 6 && master_script.talking == true)
			{
				if(!audio.isPlaying && x == 6)
				{
					audio.clip = dialogue6;
					audio.Play();
					x = 7;
				}
				
				if(!audio.isPlaying && x == 7)
				{
					current_dialogue++;
				}
				else
				{
					GUI.DrawTexture (basic, text6);
				}
			}
			if(current_dialogue == 7 && master_script.talking == true)
			{
				if(!audio.isPlaying && x == 7)
				{
					audio.clip = dialogue7;
					audio.Play();
					x = 8;
				}
				
				if(!audio.isPlaying && x == 8)
				{
					current_dialogue++;
					master_script.jarvis1 = false;
					master_script.talking = false;
				}
				else
				{
					GUI.DrawTexture (basic, text7);
				}
			}
		}

		//Jarvis Two
		if(master_script.jarvis2 == true)
		{
			if(current_dialogue == 8 && master_script.talking == true)
			{
				if(!audio.isPlaying && x == 8)
				{
					audio.clip = dialogue8;
					audio.Play();
					x = 9;
				}
				
				if(!audio.isPlaying && x == 9)
				{
					current_dialogue++;
					master_script.jarvis2 = false;
					master_script.talking = false;
				}
				else
				{
					GUI.DrawTexture (basic, text8);
				}
			}
		}
		//Jarvis Three (needs key card)
		if(master_script.jarvis3 == true && master_script.card == true)
		{
			if(current_dialogue == 9 && master_script.talking == true)
			{
				if(!audio.isPlaying && x == 9)
				{
					audio.clip = dialogue9;
					Debug.Log ("giibs");
					audio.Play();
					x = 10;
				}
				
				if(!audio.isPlaying && x == 10)
				{
					current_dialogue++;
					master_script.jarvis3 = false;
					master_script.talking = false;
					DestroyObject(door);
				}
				else
				{
					GUI.DrawTexture (basic, text9);
				}
			}
		}
		//alfred
		if(master_script.alfred == true)
		{
			if(current_dialogue == 10 && master_script.talking == true)
			{
				if(!audio.isPlaying && x == 10)
				{
					audio.clip = dialogue10;
					audio.Play();
					x = 11;
				}
				
				if(!audio.isPlaying && x == 11)
				{
					current_dialogue++;
				}
				else
				{
					GUI.DrawTexture (basic, text10);
				}
			}
			if(current_dialogue == 11 && master_script.talking == true)
			{
				if(!audio.isPlaying && x == 11)
				{
					audio.clip = dialogue11;
					audio.Play();
					x = 12;
				}
				
				if(!audio.isPlaying && x == 12)
				{
					current_dialogue++;
				}
				else
				{
					GUI.DrawTexture (basic, text11);
				}
			}
			if(current_dialogue == 12 && master_script.talking == true)
			{
				if(!audio.isPlaying && x == 12)
				{
					audio.clip = dialogue12;
					audio.Play();
					x = 13;
				}
				
				if(!audio.isPlaying && x == 13)
				{
					current_dialogue++;
				}
				else
				{
					GUI.DrawTexture (basic, text12);
				}
			}
			if(current_dialogue == 13 && master_script.talking == true)
			{
				if(!audio.isPlaying && x == 13)
				{
					audio.clip = dialogue13;
					audio.Play();
					x = 14;
				}
				
				if(!audio.isPlaying && x == 14)
				{
					current_dialogue++;
				}
				else
				{
					GUI.DrawTexture (basic, text13);
				}
			}
			if(current_dialogue == 14 && master_script.talking == true)
			{
				if(!audio.isPlaying && x == 14)
				{
					audio.clip = dialogue14;
					audio.Play();
					x = 15;
				}
				
				if(!audio.isPlaying && x == 15)
				{
					current_dialogue++;
				}
				else
				{
					GUI.DrawTexture (basic, text14);
				}
			}
			if(current_dialogue == 15 && master_script.talking == true)
			{
				if(!audio.isPlaying && x == 15)
				{
					audio.clip = dialogue15;
					audio.Play();
					x = 16;
				}
				
				if(!audio.isPlaying && x == 16)
				{
					current_dialogue++;
					master_script.alfred = false;
					master_script.talking = false;
					Application.LoadLevel("closing");
				}
				else
				{
					GUI.DrawTexture (basic, text15);
				}
			}
		}
	}
}