using UnityEngine;
using System.Collections;

public class textworld : MonoBehaviour {

	string currentRoom = "Barn";
			// remembers our current location in world
	bool hasCarrots = false;
	bool hasKnife = false;
	// Update is called once per frame
	void Update () {
		// if I declare a variable inside Update(),
		// then I can ONLY use this variable inside Update() !! 
		// also, a "buffer" is a staging area for prepare data 
		string textBuffer = "You are currently in the " + currentRoom;

		if (currentRoom == "Barn" ) {
				// all your lobby code will go here later!
			textBuffer += "\nYou see a Piglet!"; 
			textBuffer += "\npress [W] to bring the Piggy to the house";
			textBuffer += "\npress [S] to bring the Piggy outside";

			if (Input.GetKeyDown (KeyCode.W) ) {
				currentRoom = "House";
			} else if (Input.GetKeyDown (KeyCode.S) ) {
				currentRoom = "Outside";
			}

			} else if (currentRoom == "House") { 
			textBuffer += "\nYou're waiting with Piggy.";

			if (hasCarrots == false) {
				textBuffer += "\nPiggy won't follow you into the House!";
				textBuffer += "\nGo back to the Barn! Press [W].";
				if (Input.GetKeyDown (KeyCode.W) ) {
					currentRoom = "Barn";
				}
			} else if (currentRoom == "Bedroom") {
				textBuffer += "\nYou try to take a nap with Piggy but he's hungry!";
				textBuffer += "\nGo back to the House entrance to go to the kitchen.";
				textBuffer += "\nPress [H] to return.";
				if (Input.GetKeyDown (KeyCode.H) ) {
					currentRoom = "House";
				}
			}
			}else if (currentRoom == "Kitchen" ) {
			textBuffer += "\nPiggy wants a bowl of apples and pears.";
			
			if (hasKnife == false) {
				textBuffer += "\nYou don't have a knife! Find one by the stove.";
				textBuffer +="\nPress [S] to go to the stove.";
				if (Input.GetKeyDown (KeyCode.S) ) {
					currentRoom = "Stove";
				}
			}
			} else if (currentRoom == "Stove" ) {
			textBuffer += "\nYou walk towards the stove and see on the side a knife.";
			textBuffer += "\nPress [F] to go back to the kitchen to make some fruit salad for Piggy!";
			hasKnife = true;
			if (Input.GetKeyDown (KeyCode.F) ) {
				currentRoom = "Kitchen";
				
			} else {
			}if (currentRoom == "Kitchen" ) {
				textBuffer += "\nYou make a fruit salad for Piggy and he is ready to go to sleep.";
				textBuffer += "\nTo go to the bedroom, Press [B] ";
				if (Input.GetKeyDown (KeyCode.Q) ) {
					currentRoom = "Bedroom";
				}

			} else {
			textBuffer += "\nY use the Carrot to lure Piggy into the House.";
			}if (currentRoom == "House")
					textBuffer += "\n Press [Q] to take Piggy up to your bedroom.";
					textBuffer += "\n Press [E] to take Piggy to the kitchen."; 
					if (Input.GetKeyDown (KeyCode.Q) ) {
						currentRoom = "Bedroom";
					} else if (Input.GetKeyDown (KeyCode.E) ) {
						currentRoom = "Kitchen";
		
		} else if (currentRoom == "Outside" ) {
			textBuffer += "\nYou walk outside and see the bright sun!";
			textBuffer += "\npress [S] to go back INSIDE Piggy is scared!";
			textBuffer += "\nYou found some carrots! Piggy loves these! Save them for later!";
			hasCarrots = true;
			if (Input.GetKeyDown (KeyCode.S) )
				currentRoom = "Barn";
				
			}
		}

		GetComponent<TextMesh>().text = textBuffer; 
	
	}

}