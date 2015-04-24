using UnityEngine;
using System.Collections;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms.GameCenter;

public class GPGDemo : MonoBehaviour
{
	public Text text;

	void Start()
	{
		Social.localUser.Authenticate(Process);
	}

	void Process(bool sucess)
	{
		if(sucess)
		{
		}
		else
		{
			
		}
	}

	public void Loggin()
	{
		Social.localUser.Authenticate((bool success) => {
			// handle success or failure
			if(success)
			{
				text.text = "Logo";
			}
		});
	}

	public void Lead()
	{
		Social.ReportScore(55, "CgkIsZ6ut68TEAIQAA", (bool success) => {
			if(success)
			{
				text.text = "FOI";
			}
		});
	}

	public void Show()
	{
		Social.CreateLeaderboard();
		Social.CreateLeaderboard().id = "pontos";
		Social.ShowLeaderboardUI();
		//PlayGamesPlatform.Instance.ShowLeaderboardUI("CgkIsZ6ut68TEAIQAA");
	}
}