using UnityEngine;
using System.Collections;

public class World : MonoBehaviour {
	ArrayList allRooms = new ArrayList ();

	void Start () {
		Rooms livingRoom = new Rooms();
		allRooms.Add (livingRoom);

	}
	
	public static void addRoom (string roomName){
		Rooms r = new Rooms (roomName);

	}

	// Update is called once per frame
	void Update () {
		
	}
}

