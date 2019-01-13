using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
public enum eCardState {
	drawpile,
	tableau,
	target,
	discard
}

public class CardProspector : Card {
	[Header ("Set Dynamically : CardProspector")]
	public eCardState state = eCardState.drawpile;
	public List<CardProspector> hiddenBy = new List<CardProspector> ();
	public int layoutID;
	public SlotDef slotDef;

	public override void OnMouseUpAsButton () {
		Prospector.S.CardClicked (this);
		base.OnMouseUpAsButton ();
	}

	void Start() {
=======
=======
>>>>>>> parent of 5553b2b... layers + other progress
=======
>>>>>>> parent of 5553b2b... layers + other progress
=======
>>>>>>> parent of 5553b2b... layers + other progress
=======
>>>>>>> parent of 5553b2b... layers + other progress
public class CardProspector : MonoBehaviour {
    
    void Start() {
>>>>>>> parent of 5553b2b... layers + other progress
        
    }

    void Update() {
        
    }
}
