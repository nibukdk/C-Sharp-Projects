using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max = 1000;
    int min = 1;
    int guess=500;

	void Start () {
		max=max+1;
        print("Welcome to number wizard.");
        print("Pick a number in your head, but don't tell me.");
       
        print("The  number you can pick is from "+min+" to "+ max);
        print("Is the number higher or lower than "+ guess);
        print("Up arrow for higher, down for lower and return for equal");
	}
	
	void Update () {
		
	
		if (Input.GetKeyDown(KeyCode.UpArrow)){
           // print("Up Arrow key was pressed");
            min=guess;
            guess=(max+min)/2;
            print("Higher or Lower than "+ guess);
		}else if (Input.GetKeyDown(KeyCode.DownArrow)){
			max=guess;
            guess=(max+min)/2;
            print("Higher or Lower than "+ guess);
        }else if (Input.GetKeyDown(KeyCode.Return)){
            print("I won the game.");
        }

	}
}
 
