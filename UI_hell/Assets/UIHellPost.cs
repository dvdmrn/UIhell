using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class UIHellPost : MonoBehaviour {
	public InteractionsPerMin ipm;


    // Use this for initialization
    void Start()
    {
        StartCoroutine(PushPerMin());
    }
    IEnumerator PostRequest(string url)
    {	
		float val = 8000 + (ipm.ipm *10f);
        string value = val.ToString("#00");
        WWWForm form = new WWWForm();
        form.AddField("artname", "wARves");
        form.AddField("artvalue", value);
        form.AddField("key", "testkey");
        UnityWebRequest uwr = UnityWebRequest.Post(url, form);
        yield return uwr.SendWebRequest();
        if (uwr.isNetworkError)
        {
            Debug.Log("Error While Sending: " + uwr.error);
        }
        else
        {
            Debug.Log("Received: " + uwr.downloadHandler.text);
        }
    }
    
	IEnumerator PushPerMin(){
		while(true){
			yield return new WaitForSeconds(63f);
			StartCoroutine(PostRequest("http://danksy.paulbucci.ca/site/money.php"));
		}

	}
}