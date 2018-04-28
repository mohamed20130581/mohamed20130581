var CarControl : GameObject;
var dreamcar01 : GameObject;
function Start () {
   CarControl.GetComponent("CarController").enabled = true;	
   dreamcar01.GetComponent("CarAIControl").enabled = true;
}

