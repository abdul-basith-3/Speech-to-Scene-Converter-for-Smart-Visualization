using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;
public class One : MonoBehaviour {
	
	public InputField field;
	public InputField field2;
	public string reco;
	public SpeechTotext sp;
	public PrintPrompt pmt;

	// public FormatPrompt format;
	public Generate gr;
	public Relation rl;
	public void prepo(string mystr)
	{
		
		gr.gen ();
		rl.relate();
		rl.color();
		rl.dimension();

	}

	public void speech()
	{
		// reco="Recognizing";
		// field.text =reco;
		sp.callpy ();
		// format.formatinput();
		pmt.PrintSentence();
		Debug.Log(pmt.sentenceString);
		field.text =pmt.sentenceString;
		field2.text =pmt.sentenceString;
	}

	public void clear()
	{
		
		string g = "Draw mammoth bird penta table box chair chair2 chair3 chair4 chair1 chair5 car lady tree house box2 skeleton heart Draw Blackink Yellowink Redink human";
		string[] lists = g.Split (' ');
		string tar;
	
		foreach (string target in lists) {
			tar= target + "(Clone)";
			GameObject.Destroy(GameObject.Find (tar));
		}


	}

	public void undo()
	{
	
		string g = "Draw Blackink Yellowink Redink";
		string[] lists = g.Split (' ');
		string tar;
	
		foreach (string target in lists) {
			tar= target + "(Clone)";
			GameObject.Destroy(GameObject.Find (tar));
		}



	}

}
